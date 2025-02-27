/*
    Re-Volt Track Editor - Unity Edition
    A version of the track editor re-built from the ground up in Unity
    Copyright (C) 2022 Dummiesman

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using UnityEngine;
using ReVolt.TrackUnit;

public struct ZoneSequenceEntry
{
    public int ZoneID;
    public bool Forwards;
}

public struct TrackZone
{
    public Vector3 Center;
    public Vector3 Size;
    public Vector3[] Links;
    public bool IsPipe;
    public bool IsDouble;

    public Vector2Int CellCoordinate =>  new Vector2Int(Mathf.RoundToInt(Center.x / RVConstants.SMALL_CUBE_SIZE), 
                                                        Mathf.RoundToInt(Center.z / RVConstants.SMALL_CUBE_SIZE));
}

struct PipeWeld
{
    public int NoSides;
    public int NoExit;
    public int NoEntry;

    public PipeWeld(int noSides, int noExit, int noEntry)
    {
        this.NoSides = noSides;
        this.NoExit = noExit;
        this.NoEntry = noEntry;
    }
};

[System.Flags]
enum BridgeFlags
{
    None,
    LowerDeckReversed,
    UpperDeckReversed
}

public partial class TrackExporter
{
    public bool LastZoneIsPipe => zoneSequence.Count != 0 && zones[zoneSequence.Last().ZoneID].IsPipe;
    public bool TrackFormsLoop { get; private set; }
    public bool TrackFormsSprint { get; private set; }
    public float TrackLength => lapDistance;
    public IReadOnlyList<ZoneSequenceEntry> ZoneSequence => zoneSequence;
    public IReadOnlyList<TrackZone> Zones => zones;

    private readonly TrackUnitFile unitFile;
    private EditorTrack originalTrack; // the reference to the original track, do not modify!
    public EditorTrack track; // our processed track with non user-accessible modules

    private float exportScale = 1f;
    private bool reversed = false;
    private bool reverseSprintTrack = false;

    private bool exportScenery = true;
    private Color wallMin = EditorConstants.RootColorInGameMin;
    private Color wallMax = EditorConstants.RootColorInGameMax;
    private int wallTex = -1;


    private readonly string exportPath;
    private readonly string trackFolderName;

    private float maxElevation;

    private List<TrackZone> zones = new List<TrackZone>();
    private List<ZoneSequenceEntry> zoneSequence = new List<ZoneSequenceEntry>();

    private List<Vector3> posNodes = new List<Vector3>();
    private List<float> posNodeDistances = new List<float>();
    private float lapDistance;

    private ModulePlacement startModule;
    private ModulePlacement endModule;

    public ModulePlacement GetStartModule()
    {
        return startModule;
    }
    public ModulePlacement GetEndModule()
    {
        return endModule;
    }

    /* 
        Common Data 
    */

    // tolerance used for fix functions (ex. removing excess colliision and world polys)
    private const float FIX_TOLERANCE = 0.01f; 

    // IDs of pos Nodes for sprint tracks
    private const int SPRINT_POS_NODE_START_ID = 1; // ID starting at 0
    private const int SPRINT_POS_NODE_END_REVERSE_ID = 2; // ID counting backward from end

    private readonly Dictionary<int, PipeWeld> pipeWelds = new Dictionary<int, PipeWeld>()
    {
        {(int)Modules.ID.TWM_PIPE_2,                            new PipeWeld((int)Modules.ID.TWM_PIPE_0,                        (int)Modules.ID.TWM_PIPE_1,                         (int)Modules.ID.TWM_PIPE_1A)},
        {(int)Modules.ID.TWM_PIPEC_2,                           new PipeWeld((int)Modules.ID.TWM_PIPEC_0,                       (int)Modules.ID.TWM_PIPEC_1,                        (int)Modules.ID.TWM_PIPEC_1A)},
        {(int)Modules.ID.TWM_PIPE_SMOOTH_TURN_1X1_BOTH_ENDS,    new PipeWeld((int)Modules.ID.TWM_PIPE_SMOOTH_TURN_1X1_NO_ENDS,  (int)Modules.ID.TWM_PIPE_SMOOTH_TURN_1X1_FRONT_END, (int)Modules.ID.TWM_PIPE_SMOOTH_TURN_1X1_SIDE_END)},
        {(int)Modules.ID.TWM_PIPE_SMOOTH_TURN_2X2_BOTH_ENDS,    new PipeWeld((int)Modules.ID.TWM_PIPE_SMOOTH_TURN_2X2_NO_ENDS,  (int)Modules.ID.TWM_PIPE_SMOOTH_TURN_2X2_FRONT_END, (int)Modules.ID.TWM_PIPE_SMOOTH_TURN_2X2_SIDE_END)},
        {(int)Modules.ID.TWM_PIPE_RAMP_BOTTOM_BOTH_ENDS,        new PipeWeld((int)Modules.ID.TWM_PIPE_RAMP_BOTTOM_NO_ENDS,      (int)Modules.ID.TWM_PIPE_RAMP_BOTTOM_FRONT_END,     (int)Modules.ID.TWM_PIPE_RAMP_BOTTOM_BACK_END)},
        {(int)Modules.ID.TWM_PIPE_RAMP_5_BOTH_ENDS,             new PipeWeld((int)Modules.ID.TWM_PIPE_RAMP_5_NO_ENDS,           (int)Modules.ID.TWM_PIPE_RAMP_5_FRONT_END,          (int)Modules.ID.TWM_PIPE_RAMP_5_BACK_END)},
        {(int)Modules.ID.TWM_PIPE_RAMP_10_BOTH_ENDS,            new PipeWeld((int)Modules.ID.TWM_PIPE_RAMP_10_NO_ENDS,          (int)Modules.ID.TWM_PIPE_RAMP_10_FRONT_END,         (int)Modules.ID.TWM_PIPE_RAMP_10_BACK_END)},
        {(int)Modules.ID.TWM_PIPE_RAMP_15_BOTH_ENDS,            new PipeWeld((int)Modules.ID.TWM_PIPE_RAMP_15_NO_ENDS,          (int)Modules.ID.TWM_PIPE_RAMP_15_FRONT_END,         (int)Modules.ID.TWM_PIPE_RAMP_15_BACK_END)},
        {(int)Modules.ID.TWM_PIPE_20_2,                         new PipeWeld((int)Modules.ID.TWM_PIPE_20_0,                     (int)Modules.ID.TWM_PIPE_20_1_BOT,                  (int)Modules.ID.TWM_PIPE_20_1_TOP)},
        {(int)Modules.ID.TWM_PIPE_RAMP_UP_BOTH_ENDS,            new PipeWeld((int)Modules.ID.TWM_PIPE_RAMP_UP_NO_ENDS,          (int)Modules.ID.TWM_PIPE_RAMP_UP_FRONT_END,         (int)Modules.ID.TWM_PIPE_RAMP_UP_BACK_END)},
    };

    private readonly Vector3[][] rootVertsArray = new Vector3[][]
    {
        new []{ new Vector3(-RVConstants.SMALL_CUBE_HALF, 0f, RVConstants.SMALL_CUBE_HALF), new Vector3(RVConstants.SMALL_CUBE_HALF, 0f, RVConstants.SMALL_CUBE_HALF)},
        new []{ new Vector3( RVConstants.SMALL_CUBE_HALF, 0f,  RVConstants.SMALL_CUBE_HALF), new Vector3(RVConstants.SMALL_CUBE_HALF, 0f, -RVConstants.SMALL_CUBE_HALF) },
        new []{ new Vector3( RVConstants.SMALL_CUBE_HALF, 0f, -RVConstants.SMALL_CUBE_HALF), new Vector3(-RVConstants.SMALL_CUBE_HALF, 0f, -RVConstants.SMALL_CUBE_HALF) },
        new []{ new Vector3(-RVConstants.SMALL_CUBE_HALF, 0f, -RVConstants.SMALL_CUBE_HALF), new Vector3(-RVConstants.SMALL_CUBE_HALF, 0f, RVConstants.SMALL_CUBE_HALF) }
    };

    private readonly Vector3[] rootNormalsArray = new Vector3[]
    {
        Vector3.forward,
        Vector3.right,
        Vector3.back,
        Vector3.left
    };

    private Matrix4x4[] wallMatrices;

    /*
        Utility Functions 
    */
    int mod(int x, int m)
    {
        //modulo supporting negative
        return (x % m + m) % m;
    }

    private static Vector3 CalculateNormal(Vector3 a, Vector3 b, Vector3 c)
    {
        return Vector3.Cross(c - b, a - b).normalized;
    }

    private static Vector3 CalculateNormal(Vector3[] verts)
    {
        return CalculateNormal(verts[0], verts[1], verts[2]);
    }

    private static int ReverseDirection(int direction)
    {
        return (direction + 2) % 4;
    }

    private Matrix4x4 MakeCellMatrix(int xPos, int elevation, int yPos, int rotation)
    {
        var rotMtx = Matrix4x4.Rotate(Quaternion.Euler(0f, rotation * 90f, 0f));
        var translateMtx = Matrix4x4.Translate(new Vector3(xPos * RVConstants.SMALL_CUBE_SIZE,
                                                           elevation * -RVConstants.ElevationStep,
                                                           yPos * RVConstants.SMALL_CUBE_SIZE));
        return translateMtx * rotMtx;
    }

    private Matrix4x4 MakeCellMatrix(EditorTrackCell cell)
    {
        float elevation = (cell.Module != null) ? cell.Module.Elevation : 0f;
        int rotation = (cell.Module != null) ? cell.Module.Rotation : 0;

        return MakeCellMatrix(cell.Position.x, Mathf.RoundToInt(elevation / EditorConstants.ElevationStep),
                              cell.Position.y, rotation);
    }

    private Matrix4x4 MakeModuleMatrix(ModulePlacement placement)
    {
        return MakeCellMatrix(placement.Position.x, Mathf.RoundToInt(placement.Elevation / EditorConstants.ElevationStep),
                              placement.Position.y, placement.Rotation);
    }

    private static Quaternion MakeModuleQuat(ModulePlacement placement)
    {
        return Quaternion.Euler(0f, 90f * placement.Rotation, 0f);
    }

    private static bool ModuleIsPipeBase(int modId)
    {
        return (
            modId == (int)Modules.ID.TWM_PIPE_0 ||
            modId == (int)Modules.ID.TWM_PIPE_1 ||
            modId == (int)Modules.ID.TWM_PIPE_1A ||
            modId == (int)Modules.ID.TWM_PIPE_2 ||
            modId == (int)Modules.ID.TWM_PIPE_20_0 ||
            modId == (int)Modules.ID.TWM_PIPE_20_1_BOT ||
            modId == (int)Modules.ID.TWM_PIPE_20_1_TOP ||
            modId == (int)Modules.ID.TWM_PIPE_20_2 ||
            modId == (int)Modules.ID.TWM_PIPEC_0 ||
            modId == (int)Modules.ID.TWM_PIPEC_1 ||
            modId == (int)Modules.ID.TWM_PIPEC_1A ||
            modId == (int)Modules.ID.TWM_PIPEC_2 ||
            modId == (int)Modules.ID.TWM_PIPE_SMOOTH_TURN_1X1_BOTH_ENDS ||
            modId == (int)Modules.ID.TWM_PIPE_SMOOTH_TURN_1X1_FRONT_END ||
            modId == (int)Modules.ID.TWM_PIPE_SMOOTH_TURN_1X1_SIDE_END ||
            modId == (int)Modules.ID.TWM_PIPE_SMOOTH_TURN_1X1_NO_ENDS ||
            modId == (int)Modules.ID.TWM_PIPE_SMOOTH_TURN_2X2_BOTH_ENDS ||
            modId == (int)Modules.ID.TWM_PIPE_SMOOTH_TURN_2X2_FRONT_END ||
            modId == (int)Modules.ID.TWM_PIPE_SMOOTH_TURN_2X2_SIDE_END ||
            modId == (int)Modules.ID.TWM_PIPE_SMOOTH_TURN_2X2_NO_ENDS ||
            modId == (int)Modules.ID.TWM_PIPE_RAMP_BOTTOM_NO_ENDS ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_BOTTOM_FRONT_END ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_BOTTOM_BACK_END ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_BOTTOM_BOTH_ENDS ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_UP_NO_ENDS ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_UP_FRONT_END ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_UP_BACK_END ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_UP_BOTH_ENDS ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_15_NO_ENDS ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_15_FRONT_END ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_15_BACK_END ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_15_BOTH_ENDS ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_10_NO_ENDS ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_10_FRONT_END ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_10_BACK_END ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_10_BOTH_ENDS ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_5_NO_ENDS ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_5_FRONT_END ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_5_BACK_END ||
		    modId == (int)Modules.ID.TWM_PIPE_RAMP_5_BOTH_ENDS
        );
    }

    private static bool ModuleIsDoubleBase(int modId)
    {
        return (
            modId == (int)Modules.ID.TWM_DOUBLE_STRAIGHT ||
            modId == (int)Modules.ID.TWM_DOUBLE_SIDE_ENTRY ||
            modId == (int)Modules.ID.TWM_DOUBLE_SIDE_ENTRY_2 ||
            modId == (int)Modules.ID.TWM_DOUBLE_SQUARE_TURN ||
            modId == (int)Modules.ID.TWM_DOUBLE_SQUARE_TURN_2 ||
            modId == (int)Modules.ID.TWM_DOUBLE_ROUND_TURN ||
            modId == (int)Modules.ID.TWM_DOUBLE_ROUND_TURN_2 ||
            modId == (int)Modules.ID.TWM_DOUBLE_ROUND_TURN_L ||
            modId == (int)Modules.ID.TWM_DOUBLE_ROUND_TURN_L_2 ||
            modId == (int)Modules.ID.TWM_DOUBLE_ROUND_TURN_R ||
            modId == (int)Modules.ID.TWM_DOUBLE_ROUND_TURN_R_2
        );
    }

    private int GetUnitInCell(EditorTrackCell cell)
    {
        if (cell.Module == null)
            return -1;

        // not the nicest way to handle this
        var root = cell.Module.RootCell;
        var module = unitFile.Modules[cell.Module.ModuleIndex];

        foreach(var instance in module.Instances)
        {
            var instanceCellPos = root.Position + instance.Position.Rotate(cell.Module.Rotation);
            if(instanceCellPos == cell.Position)
                return instance.UnitID;
        }
        return -1;
    }

    /// <summary>
    /// Enumerate zone sequences
    /// Returns tuples of Prev, Current, Next
    /// </summary>
    private IEnumerable<Tuple<ZoneSequenceEntry?, ZoneSequenceEntry, ZoneSequenceEntry?>> EnumZoneSequence()
    {
        for (int i = 0; i < zoneSequence.Count; i++)
        {
            ZoneSequenceEntry seqEntry = zoneSequence[i];
            ZoneSequenceEntry? prevSeqEntry = null;
            ZoneSequenceEntry? nextSeqEntry = null;

            if (i > 0)
                prevSeqEntry = zoneSequence[i - 1];
            if (i < zoneSequence.Count - 1)
                nextSeqEntry = zoneSequence[i + 1];

            yield return new Tuple<ZoneSequenceEntry?, ZoneSequenceEntry, ZoneSequenceEntry?>(prevSeqEntry, seqEntry, nextSeqEntry);
        }
    }

    /// <summary>
    /// Enumerate zones in order
    /// Returns tuples of Prev, Current, Next
    /// </summary>
    private IEnumerable<Tuple<TrackZone?, TrackZone, TrackZone?>> EnumZones()
    {
        foreach((ZoneSequenceEntry? prevSeqEntry, ZoneSequenceEntry seqEntry, ZoneSequenceEntry? nextSeqEntry) in EnumZoneSequence())
        {
            TrackZone zone = zones[seqEntry.ZoneID];
            TrackZone? prevZone = null;
            TrackZone? nextZone = null;

            if(prevSeqEntry.HasValue)
                prevZone = zones[prevSeqEntry.Value.ZoneID];
            if (nextSeqEntry.HasValue)
                nextZone = zones[nextSeqEntry.Value.ZoneID];

            yield return new Tuple<TrackZone?, TrackZone, TrackZone?>(prevZone, zone, nextZone);
        }
    }

    /// <summary>
    /// Enumerate modules in order
    /// </summary>
    private IEnumerable<ModulePlacement> EnumModules()
    { 
        Vector2Int lastCheckedModulePos = new Vector2Int(-1, -1); //start with an invalid zone

        for (int i = 1; i < zoneSequence.Count; i++)
        {
            var zone = zones[zoneSequence[i].ZoneID];
            var cell = track.GetCell(zone.CellCoordinate);

            if (cell.Module == null || cell.Module.RootCell.Position == lastCheckedModulePos)
                continue;

            lastCheckedModulePos = cell.Module.RootCell.Position;
            yield return cell.Module;
        }
    }

    /*
        Export Functions 
    */
    public void WriteInfoFile(bool reverseSprintTrack = false)
    {
        string formatFloat(float f) => f.ToString("F6", CultureInfo.InvariantCulture);
        string formatInt(int i) => i.ToString(CultureInfo.InvariantCulture);

        var startModulePos = MakeModuleMatrix(startModule).GetColumn(3) * exportScale;
        var endModulePos = new Vector3(0, 0, 0);
        if (TrackFormsSprint)
        {
            endModulePos = MakeModuleMatrix(endModule).GetColumn(3) * exportScale;
        }

        string infoTemplate = Resources.Load<TextAsset>("InfoTemplate").text;
        infoTemplate = infoTemplate.Replace("%TRACKNAME%", track.Name);
        infoTemplate = infoTemplate.Replace("%GAMETYPE%", formatInt(TrackFormsSprint ? 4 : 0));
        infoTemplate = infoTemplate.Replace("%STARTROT%", formatFloat(startModule.Rotation * 0.25f));
        infoTemplate = infoTemplate.Replace("%INVSTARTROT%", formatFloat(ReverseDirection(startModule.Rotation) * 0.25f));
        infoTemplate = infoTemplate.Replace("%STARTPOS%", $"{formatFloat(startModulePos.x)} {formatFloat(startModulePos.y)} {formatFloat(startModulePos.z)}"); 
        infoTemplate = infoTemplate.Replace("%ENDPOS%", $"{formatFloat(endModulePos.x)} {formatFloat(endModulePos.y)} {formatFloat(endModulePos.z)}");
        infoTemplate = infoTemplate.Replace("%OPTIONALTEXWALLPROP%", wallTex < 0 ? "\n" : $"\nTEXTUREPROPS    {wallTex} 1 1 1  ; Index - mipmaps - wrap mode - colorkey\n");

        string infoFilePath = exportPath;
        if (reverseSprintTrack)
        {
            infoFilePath = Path.Combine(infoFilePath, "reverse");
        }
        infoFilePath = Path.Combine(infoFilePath, $"{trackFolderName}.inf");
        File.WriteAllText(infoFilePath, infoTemplate);
    }

    public void WriteZonesFile()
    {
        int getZoneIndex(int i) => TrackFormsLoop ? ((i + 1) % zoneSequence.Count) : i;
        var zonesFile = new ReVolt.Track.ZonesFile();
        
        if (TrackFormsSprint)
        {
            // Add a start zone just before start grid
            var startZone = zones[zoneSequence[0].ZoneID];
            var startCell = track.GetCell(startZone.CellCoordinate);
            var startModMatrix = MakeModuleMatrix(startCell.Module);
            Vector3 sprintPreZonePos = new Vector3(0, -2500, -750);
            sprintPreZonePos = startModMatrix.MultiplyPoint3x4(sprintPreZonePos);
            Matrix4x4 sprintPreZoneScaleMat = Matrix4x4.Scale(new Vector3(500, 2500, 250));
            sprintPreZoneScaleMat *= startModMatrix;
            Vector3 sprintPreZoneScale = sprintPreZoneScaleMat.lossyScale;

            zonesFile.Zones.Add(new ReVolt.Track.Zone()
            {
                ID = 0,
                Matrix = Matrix4x4.identity,
                Position = sprintPreZonePos,
                Size = sprintPreZoneScale
            });
        }

        for(int i=0; i < zoneSequence.Count; i++)
        {
            var zone = zones[zoneSequence[getZoneIndex(i)].ZoneID];
            zonesFile.Zones.Add(new ReVolt.Track.Zone()
            {
                ID = TrackFormsSprint ? i + 1 : i,
                Matrix = Matrix4x4.identity,
                Position = zone.Center,
                Size = zone.Size 
            });
        }

        if(exportScale != 1f)
        {
            zonesFile.Scale(exportScale);
        }

        string zoneFilePath = Path.Combine(exportPath, $"{trackFolderName}.taz");
        zonesFile.Save(zoneFilePath);
    }

    public void WritePosNodesFile()
    {
        var posFile = new ReVolt.Track.POSNodesFile()
        {
            StartNodeIndex = TrackFormsLoop ? 0 : SPRINT_POS_NODE_START_ID,
            EndNodeIndex = TrackFormsLoop ? -1 : posNodes.Count - SPRINT_POS_NODE_END_REVERSE_ID,
            TotalLength = lapDistance
        };

        for(int i=0; i < posNodes.Count; i++)
        {
            var node = new ReVolt.Track.POSNode()
            {
                Position = posNodes[i],
                Distance = posNodeDistances[i],
                PreviousNodeIDs = new int[] { (i + (posNodes.Count - 1)) % posNodes.Count, -1, -1, -1 },
                NextNodeIDs = new int[] { (i + 1) % posNodes.Count, -1, -1, -1 },
            };
            posFile.Nodes.Add(node);
        }

        if (TrackFormsSprint)
        {
            // Unlink end nodes
            posFile.Nodes[0].PreviousNodeIDs[0] = -1;
            posFile.Nodes[posFile.Nodes.Count - 1].NextNodeIDs[0] = -1;
        }

        if(exportScale != 1f)
        {
            posFile.Scale(exportScale);
        }

        string posNodeFilePath = Path.Combine(exportPath, $"{trackFolderName}.pan");
        posFile.Save(posNodeFilePath);
    }

    public void WriteObjectsFile()
    {
        var objectsFile = new ReVolt.Track.ObjectsFile();

        foreach (var cell in track.Cells.Where(x => x.HasPickup))
        {
            Vector3 unitOffset = new Vector3((cell.Position.x - cell.Module.RootCell.Position.x) * RVConstants.SMALL_CUBE_SIZE,
                                 0f,
                                 (cell.Position.y - cell.Module.RootCell.Position.y) * RVConstants.SMALL_CUBE_SIZE);

            var unit = unitFile.Units[GetUnitInCell(cell)];
            var modMatrix = MakeModuleMatrix(cell.Module);

            Vector3 transformedPickupPosition = modMatrix.MultiplyPoint3x4(unit.PickupPosition) + unitOffset;

            objectsFile.Objects.Add(new ReVolt.Track.Object()
            {
                DirectionMatrix = Matrix4x4.identity,
                Position = transformedPickupPosition,
                Type = ReVolt.Track.ObjectType.Pickup
            });
        }

        if (exportScale != 1f)
        {
            objectsFile.Scale(exportScale);
        }

        string objectsFilePath = Path.Combine(exportPath, $"{trackFolderName}.fob");
        objectsFile.Save(objectsFilePath);
    }

    public void WriteLightsFile()
    {
        var lightsFile = new ReVolt.Track.LightsFile();

        foreach (var moduleRootPlacement in track.GetAllModuleRootPlacements())
        {
            var module = unitFile.Modules[moduleRootPlacement.ModuleIndex];
            var cell = moduleRootPlacement.RootCell;

            foreach (var modLight in module.Lights)
            {
                var light = new ReVolt.Track.Light
                {
                    Color = modLight.Color,
                    Cone = modLight.Cone,
                    Reach = modLight.Reach,
                    Type = (byte)modLight.Type,
                    Flags = ReVolt.Track.LightFlags.File | ReVolt.Track.LightFlags.Fixed | ReVolt.Track.LightFlags.Moving
                };

                Matrix4x4 directionMatrix = Matrix4x4.LookAt(Vector3.down, Vector3.up, Vector3.forward);
                if (modLight.UpDirection.sqrMagnitude > 0f && modLight.ForwardDirection.sqrMagnitude > 0f)
                {
                    // untested
                    var moduleQuat = MakeModuleQuat(cell.Module);
                    Vector3 sideDirection = Vector3.Cross(modLight.ForwardDirection, modLight.UpDirection);
                    directionMatrix.SetColumn(0, moduleQuat * sideDirection);
                    directionMatrix.SetColumn(1, moduleQuat * modLight.UpDirection);
                    directionMatrix.SetColumn(2, moduleQuat * modLight.ForwardDirection);
                }

                light.Position = MakeModuleMatrix(moduleRootPlacement).MultiplyPoint3x4(modLight.Position);
                light.DirectionMatrix = directionMatrix;

                lightsFile.Lights.Add(light);
            }
        }

        if (exportScale != 1f)
        {
            lightsFile.Scale(exportScale);
        }

        string lightFilePath = Path.Combine(exportPath, $"{trackFolderName}.lit");
        lightsFile.Save(lightFilePath);
    }

    public void CreateTrackFolder()
    {
        Directory.CreateDirectory(exportPath);
    }

    private bool FileIsNotFromFromTrackEditor(FileInfo file)
    {
        switch (file.Extension)
        {
            case ".fan":
            case ".fob":
            case ".inf":
            case ".lit":
            case ".ncp":
            case ".pan":
            case ".taz":
            case ".w":
                return false;
            default:
                return true;
        }
    }
    // Remove only files that will be overwritten
    // That way if user have some instances they will not be lost
    public void EmptyTrackFolderContents()
    {
        var di = new DirectoryInfo(exportPath);
        if (di.Exists)
        {
            foreach (FileInfo file in di.EnumerateFiles())
            {
                if (file.Name.StartsWith(trackFolderName) && !FileIsNotFromFromTrackEditor(file))
                {
                    file.Delete();
                }
            }
            //foreach (DirectoryInfo dir in di.EnumerateDirectories())
            //    dir.Delete(true);
            var reverseDir = new DirectoryInfo(Path.Combine(exportPath, "reverse"));
            if (reverseDir.Exists)
            {
                foreach (FileInfo file in di.EnumerateFiles())
                {
                    if (file.Name.StartsWith(trackFolderName) && !FileIsNotFromFromTrackEditor(file))
                    {
                        file.Delete();
                    }
                }
            }
        }
    }

    public void CopyBitmaps()
    {
        for(int i=1; i <= RVConstants.TPAGE_COUNT; i++)
        {
            string tpagePath = FileHelper.GetTPagePath(i);
            if (File.Exists(tpagePath))
            {
                string targetFileName = Path.Combine(exportPath, $"{trackFolderName}{(char)('a' + (i - 1))}.bmp");
                File.Copy(tpagePath, targetFileName, true);
            }
        }
    }

    BridgeFlags GetBridgeFlags(ModulePlacement placement)
    {
        int index = 0;
        bool[] reversed = new bool[] { false, false };
        float[] elevation = new float[] { 0f, 0f };

        for (int i = 0; i < zoneSequence.Count; i++) 
        {
            var zone = zones[zoneSequence[i].ZoneID];
            if (zone.CellCoordinate == placement.Position)
            {
                elevation[index] = zone.Center.y;
                reversed[index] = !zoneSequence[i].Forwards;
                index = Mathf.Min(index + 1, 1);
            }
        }

        BridgeFlags flags = BridgeFlags.None;
        int lowerDeckIndex = (elevation[0] < elevation[1]) ? 0 : 1;
        int upperDeckIndex = 1 - lowerDeckIndex;

        if(reversed[lowerDeckIndex])
            flags |= BridgeFlags.LowerDeckReversed;
        if (reversed[upperDeckIndex])
            flags |= BridgeFlags.UpperDeckReversed;

        return flags;
    }

    void CorrectBridgeDirections()
    {
       foreach(var placement in track.GetAllModuleRootPlacements())
        {
            if(placement.ModuleIndex >= (int)Modules.ID.TWM_BRIDGE_10_2_N && placement.ModuleIndex <= (int)Modules.ID.TWM_BRIDGE_80_2_N)
            {
                int moduleid = placement.ModuleIndex - ((int)Modules.ID.TWM_BRIDGE_10_2_N - (int)Modules.ID.TWM_BRIDGE_10_2);
                var flags = GetBridgeFlags(placement);

                if((flags & BridgeFlags.LowerDeckReversed) != 0)
                {
                    placement.Rotation = ReverseDirection(placement.Rotation);
                }
                if(flags == BridgeFlags.LowerDeckReversed || flags == BridgeFlags.UpperDeckReversed)
                {
                    moduleid += ((int)Modules.ID.TWM_BRIDGE_10_2_LH - (int)Modules.ID.TWM_BRIDGE_10_2);
                }
                placement.ModuleIndex = moduleid;
            }
        }
    }

    void FillFloorWithSpacers()
    {
        foreach (var cell in track.Cells.Where(x => x.Module == null))
        {
            cell.Module = new ModulePlacement()
            {
                Elevation = 0f,
                ModuleIndex = (int)Modules.ID.TWM_SPACE_B,
                Position = cell.Position,
                RootCell = cell,
            };
            cell.Module.TouchedCells.Add(cell);
        }
    }

    private void WeldPipes()
    {
        foreach((ZoneSequenceEntry? prevSeqEntry, ZoneSequenceEntry seqEntry, ZoneSequenceEntry? nextSeqEntry) in EnumZoneSequence())
        {
            TrackZone zone = zones[seqEntry.ZoneID];
            ModulePlacement originalPlacement = originalTrack.GetCell(zone.CellCoordinate).Module;
            bool currentIsPipe = ModuleIsPipeBase(originalPlacement.ModuleIndex);

            if (!currentIsPipe)
                continue;

            TrackZone prevZone, nextZone;
            ModulePlacement prevPlacement = null, nextPlacement = null;

            if(prevSeqEntry.HasValue)
            {
                prevZone = zones[prevSeqEntry.Value.ZoneID];
                prevPlacement = originalTrack.GetCell(prevZone.CellCoordinate).Module;
            }
            if (nextSeqEntry.HasValue)
            {
                nextZone = zones[nextSeqEntry.Value.ZoneID];
                nextPlacement = originalTrack.GetCell(nextZone.CellCoordinate).Module;
            }

            // check if the previous/next modules are pipes, and not the same pipe
            // custom trackunits may have >1 unit pipe modules
            bool previousIsPipe = prevPlacement != null && prevPlacement.Position != originalPlacement.Position && ModuleIsPipeBase(prevPlacement.ModuleIndex);
            bool nextIsPipe = nextPlacement != null && nextPlacement.Position != originalPlacement.Position && ModuleIsPipeBase(nextPlacement.ModuleIndex);
            
            if (previousIsPipe || nextIsPipe)
            {
                // perfect, now we need to see how to weld things
                var weldData = pipeWelds[originalPlacement.ModuleIndex];
                ModulePlacement placement = track.GetCell(originalPlacement.Position).Module;
                
                if (previousIsPipe && nextIsPipe)
                    placement.ModuleIndex = weldData.NoSides; //remove both walls
                else if (previousIsPipe)
                {
                    placement.ModuleIndex = (seqEntry.Forwards) ? weldData.NoEntry : weldData.NoExit; //remove front wall
                }
                else if (nextIsPipe)
                {
                    // because trackunits may have >1 unit
                    // we must not erase flags already set
                    if (placement.ModuleIndex == weldData.NoExit || placement.ModuleIndex == weldData.NoEntry)
                    {
                        placement.ModuleIndex = weldData.NoSides;
                    }
                    else
                    {
                        placement.ModuleIndex = (seqEntry.Forwards) ? weldData.NoExit : weldData.NoEntry; //remove back wall
                    }
                }
            }
        }
    }

    private void MakeModulesDirectional()
    {
        foreach ((_, ZoneSequenceEntry seqEntry, _) in EnumZoneSequence())
        {
            var zone = zones[seqEntry.ZoneID];
            var placement = track.GetCell(zone.CellCoordinate).Module;

            if (seqEntry.Forwards)
            {
                placement.ModuleIndex = Modules.Lookup.Changes[placement.ModuleIndex].Forward;
            }
            else
            {
                if (Modules.Lookup.Changes[placement.ModuleIndex].HasSingleDirectionVariant())
                {
                    placement.Rotation = ReverseDirection(placement.Rotation);
                }

                placement.ModuleIndex = Modules.Lookup.Changes[placement.ModuleIndex].Reverse;
            }
        }
    }

    private void CreateZoneList()
    {
        foreach (var moduleRootPlacement in track.GetAllModuleRootPlacements())
        {
            if (reversed)
            {
                if (moduleRootPlacement.ModuleIndex == (int)Modules.ID.TWM_JUMP)
                {
                    moduleRootPlacement.Rotation = ReverseDirection(moduleRootPlacement.Rotation);
                }
            }
            // if (reverseSprintTrack)
            // {
            //     if (moduleRootPlacement.ModuleIndex == (int)Modules.ID.TWM_START)
            //     {
            //         // module = unitFile.Modules[(int)Modules.ID.TWM_FINISH];
            //         moduleRootPlacement.Rotation = ReverseDirection(moduleRootPlacement.Rotation);
            //     }
            //     else if (moduleRootPlacement.ModuleIndex == (int)Modules.ID.TWM_FINISH)
            //     {
            //         // module = unitFile.Modules[(int)Modules.ID.TWM_START];
            //         moduleRootPlacement.Rotation = ReverseDirection(moduleRootPlacement.Rotation);
            //     }
            // }

            var module = unitFile.Modules[moduleRootPlacement.ModuleIndex];
            var modMatrix = MakeModuleMatrix(moduleRootPlacement);

            foreach (var modZone in module.Zones)
            {
                var zone = new TrackZone
                {
                    Center = modMatrix.MultiplyPoint3x4(modZone.Center),
                    Size = modZone.Size,
                    Links = new Vector3[]
                    {
                        modMatrix.MultiplyPoint3x4(modZone.LinkPositions[0]),
                        modMatrix.MultiplyPoint3x4(modZone.LinkPositions[1])
                    }
                };

                zone.IsPipe = ModuleIsPipeBase(moduleRootPlacement.ModuleIndex);
                zone.IsDouble = ModuleIsDoubleBase(moduleRootPlacement.ModuleIndex);

                if (moduleRootPlacement.Rotation == (int)Modules.Direction.East
                    || moduleRootPlacement.Rotation == (int)Modules.Direction.West)
                {
                    zone.Size = new Vector3(zone.Size.z, zone.Size.y, zone.Size.x);
                }

                zones.Add(zone);
            }
        }
    }

    bool CheckForFinishLine(int currentZoneIndex)
    {
        var currentZone = zones[currentZoneIndex];
        var currentModule = track.GetCell(currentZone.CellCoordinate).Module;
        bool isFinishLine = currentModule.ModuleIndex == (int)Modules.ID.TWM_FINISH;
        if (isFinishLine)
        {
            TrackFormsSprint = true;
            endModule = currentModule;
        }
        return isFinishLine;
    }

    bool FindNextZone(int currentZoneIndex, int currentLink, out int nextZoneIndex, out int nextLinkIndex, out bool nextIsDouble)
    {
        nextZoneIndex = -1;
        nextLinkIndex = -1;
        nextIsDouble = false;

        //
        var currentZone = zones[currentZoneIndex];
        var currentLinkPos = currentZone.Links[currentLink];

        float distanceThreshold = 25.0f; // was set to 0.25f but precision in 3dsmax can lead to more than 1.f variations

        for (int i = 0; i < zones.Count; i++)
        {
            if (i == currentZoneIndex)
                continue;

            var otherZone = zones[i];
            for (int link = 0; link < 2; link++)
            {
                var linkPos = otherZone.Links[link];
                if (Mathf.Abs(linkPos.x - currentLinkPos.x) < distanceThreshold && Mathf.Abs(linkPos.z - currentLinkPos.z) < distanceThreshold)
                {
                    // must match Y coordinate if in a pipe
                    if (currentZone.IsPipe && otherZone.IsPipe)
                    {
                        if (Mathf.Abs(linkPos.y - currentLinkPos.y) < distanceThreshold)
                        {
                            nextZoneIndex = i;
                            nextLinkIndex = link;
                            return true;
                        }
                    }
                    else
                    {
                        if ((currentLinkPos.y - linkPos.y) < distanceThreshold)
                        {
                            nextZoneIndex = i;
                            nextLinkIndex = link;
                            nextIsDouble = otherZone.IsDouble;
                            return true;
                        }
                    }
                }
            }
        }

        return false;
    }

    private void DetermineZoneSequence()
    {
        //find the start zone
        int startZoneIndex = -1;
        if(startModule != null)
        {
            var startModulePos = MakeModuleMatrix(startModule).GetColumn(3);
            for(int i=0; i < zones.Count; i++)
            {
                var zone = zones[i];
                float xD = Mathf.Abs(startModulePos.x - zone.Center.x);
                float zD = Mathf.Abs(startModulePos.z - zone.Center.z);
                if(xD < zone.Size.x && zD < zone.Size.z)
                {
                    startZoneIndex = i;
                    break;
                }
            }
        }

        //cannot create zone information, no start
        if (startZoneIndex < 0)
            return;

        var startZone = zones[startZoneIndex];

        var firstPosNode = startZone.Links[1] + ((startZone.Links[0] - startZone.Links[1]) / 100f);
        posNodes.Add(firstPosNode);
        var firstPosNodeForSprintTrack = startZone.Links[0];

        //try and create a loop!
        int currentZoneIndex = startZoneIndex;
        int currentLink = 1;
        bool currentIsDouble = false;

        int nextZoneIndex = -1;
        int nextLink = 0;
        bool nextIsDouble = false;

        bool jumped = false;

        for(int i=0; i < zones.Count; i++)
        {
            var seqEntry = new ZoneSequenceEntry
            {
                ZoneID = currentZoneIndex,
                Forwards = (currentLink == 1)
            };
            zoneSequence.Add(seqEntry);

            var currentZone = zones[currentZoneIndex];
            if (jumped)
            {
                posNodes[posNodes.Count - 1] = currentZone.Links[1 - currentLink];
            }

            float slope = currentZone.Links[1-currentLink].y - currentZone.Links[currentLink].y;
            jumped = (slope > (10f * RVConstants.GameScale));
            // Double modules introduced an issue with U turns: too sharp angle between nodes. To mitigate this we replace ends nodes by center nodes
            if (currentIsDouble)
            {
                posNodes.Add(0.5f * (currentZone.Links[currentLink] + currentZone.Links[1 - currentLink])); // Add a pos node inbetween each node of double modules
            }

            if(FindNextZone(currentZoneIndex, currentLink, out nextZoneIndex, out nextLink, out nextIsDouble))
            {
                if (!(nextIsDouble && currentIsDouble))
                {
                    posNodes.Add(currentZone.Links[currentLink]); // Dont add a pos node inbetween each double modules.
                }
                currentZoneIndex = nextZoneIndex;
                currentLink = (1 - nextLink);
                currentIsDouble = nextIsDouble;

                if (jumped)
                {
                    posNodes[posNodes.Count - 1] = zones[nextZoneIndex].Links[nextLink];
                }
            }
            else if (CheckForFinishLine(currentZoneIndex))
            {
                posNodes.Add(currentZone.Links[currentLink]);
                posNodes.Add(currentZone.Links[currentLink] + ((currentZone.Links[currentLink] - currentZone.Links[1 - currentLink]) / 2f)); // Add one after finish line
                break;
            }
            else
            {
                // track doesn't form a loop or a sprint race
                break;
            }

            // check if we've looped around
            if (zoneSequence.Count > 0 && startZoneIndex == nextZoneIndex)
                break;
        }

        //if (jumped)
        //{
        //    posNodes[posNodes.Count - 1] = startZone.Links[1 - currentLink];
        //}

        TrackFormsLoop = (nextZoneIndex == startZoneIndex);

        if (TrackFormsSprint)
        {
            posNodes.Insert(0, firstPosNodeForSprintTrack);
        }
    }

    public int GetStartGridCount()
    {
        return track.GetAllModuleRootPlacements().Count(x => x.ModuleIndex == (int)Modules.ID.TWM_START);
    }

    /// <summary>
    /// Step one, before Validate()
    /// </summary>
    public void Initialize()
    {
        var perfLogger = new PerfTimeLogger("Export");

        // locate the start module
        if (startModule != null && endModule != null && reverseSprintTrack)
        {
            startModule.ModuleIndex = (int)Modules.ID.TWM_START;
            startModule.Rotation = ReverseDirection(startModule.Rotation);
            endModule.ModuleIndex = (int)Modules.ID.TWM_FINISH;
            endModule.Rotation = ReverseDirection(endModule.Rotation);
        }
        else
        {
            startModule = track.GetAllModuleRootPlacements().FirstOrDefault(x => x.ModuleIndex == (int)Modules.ID.TWM_START);
            if (startModule != null && reversed)
            {
                startModule.Rotation = ReverseDirection(startModule.Rotation);
            }
        }

        // create wall matrices which will be shared between mesh/collision exporting
        Vector2Int[] wallCells = new Vector2Int[6]
        {
            Vector2Int.zero,                                        //0 is roof, leave it where it is                                
            new Vector2Int(0, -20 + track.Height),                  //1 is top left, move it by (-20 + track height) units on Y axis          
            Vector2Int.zero,                                        //2 is bottom left, leave it where it is
            new Vector2Int(-20 + track.Width, -20 + track.Height),  //3 is top right, move it by (-20 + track height) units on Y and (-20 + track width) units X axis   
            new Vector2Int(-20 + track.Width, -20 + track.Height),  //4 is top right (boxes), move it just like 3     
            new Vector2Int(-20 + track.Width, 0)                    //5 is bottom right, move it by (-20 + track width) units X axis          
        };

        wallMatrices = new Matrix4x4[6];
        for(int i=0; i < 6; i++)
        {
            wallMatrices[i] = MakeCellMatrix(wallCells[i].x, 0, wallCells[i].y, 0);
        }

        // get max elevation
        maxElevation = EditorConstants.MaxElevation;
        foreach(var mod in track.GetAllModuleRootPlacements())
        {
            maxElevation = Mathf.Max(mod.Elevation, maxElevation);
        }

        // raise roof if needed
        float roofRaise = Mathf.Max(0f, maxElevation - EditorConstants.MaxElevation);
        wallMatrices[0].SetColumn(3, new Vector3(0f, roofRaise * RVConstants.SMALL_CUBE_SIZE * -1f, 0f));

        // init zoning stuff
        CreateZoneList();
        DetermineZoneSequence();

        // fix up directional stuff
        MakeModulesDirectional();
        CorrectBridgeDirections();
        
        // weld the pipes
        WeldPipes();

        // fill empty cells with space units
        FillFloorWithSpacers();

        // calculate lap length and pos node distances
        lapDistance = 0f;
        if (TrackFormsSprint)
        {
            for (int i = 0; i < SPRINT_POS_NODE_START_ID; i++)
            {
                posNodeDistances.Add(lapDistance);
            }
            for (int i = SPRINT_POS_NODE_START_ID; i < posNodes.Count - SPRINT_POS_NODE_END_REVERSE_ID; i++)
            {
                posNodeDistances.Add(lapDistance);
                lapDistance += Vector3.Distance(posNodes[i], posNodes[(i + 1) % posNodes.Count]);
            }
            for (int i = posNodes.Count - SPRINT_POS_NODE_END_REVERSE_ID; i < posNodes.Count; i++)
            {
                posNodeDistances.Add(lapDistance);
            }
            for (int i = SPRINT_POS_NODE_START_ID + 1; i < posNodes.Count - SPRINT_POS_NODE_END_REVERSE_ID; i++)
                posNodeDistances[i] = lapDistance - posNodeDistances[i];
            for (int i = posNodes.Count - SPRINT_POS_NODE_END_REVERSE_ID; i < posNodes.Count; i++)
                posNodeDistances[i] = 0f;
        }
        else // TrackFormsLoop
        {
            for (int i = 0; i < posNodes.Count; i++)
            {
                posNodeDistances.Add(lapDistance);
                lapDistance += Vector3.Distance(posNodes[i], posNodes[(i + 1) % posNodes.Count]);
            }
            for (int i = 1; i < posNodes.Count; i++)
                posNodeDistances[i] = lapDistance - posNodeDistances[i];
        }
        
        perfLogger.Log("Initialize");
    }

    public TrackExporter(EditorTrack track, TrackUnitFile unitFile, Color32 wallMin, Color32 wallMax, int wallTex, float scale = 1f, bool exportScenery = true) : this(track, unitFile, false, wallMin, wallMax, wallTex, scale, exportScenery, false)
    {
    }

    public TrackExporter(EditorTrack track, TrackUnitFile unitFile, bool reversed, Color32 wallMin, Color32 wallMax, int wallTex, float scale = 1f, bool exportScenery = true, bool reverseSprintTrack = false, ModulePlacement startModule = null, ModulePlacement endModule = null)
    {
        this.trackFolderName = FileHelper.TrackNameToExportDirectory(track.Name);
        this.originalTrack = track;
        this.unitFile = unitFile;

        if(reversed)
            this.exportPath = Path.Combine(FileHelper.GetCompiledLevelsPath(), trackFolderName, "reversed");
        else
            this.exportPath = Path.Combine(FileHelper.GetCompiledLevelsPath(), trackFolderName);

        this.track = track.Clone(false);
        this.exportScale = scale;
        this.exportScenery = exportScenery;
        this.reversed = reversed;
        this.reverseSprintTrack = reverseSprintTrack;

        this.wallMin = wallMin;
        this.wallMax = wallMax;
        this.wallTex = wallTex;

        if (startModule != null && endModule != null)
        {
            this.startModule = this.track.GetAllModuleRootPlacements().FirstOrDefault(x => x.RootCell.Position == startModule.RootCell.Position);
            this.endModule = this.track.GetAllModuleRootPlacements().FirstOrDefault(x => x.RootCell.Position == endModule.RootCell.Position);
        }
    }
}
