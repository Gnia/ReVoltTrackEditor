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
using System.IO;
using System.Text;
using UnityEngine;

#if USE_32BITS_IDS
using rtuIDs = System.Int32;
#else
using rtuIDs = System.Int16;
#endif

namespace ReVolt.TrackUnit
{
    public class FileCommon
    {
        public static void CheckIndexExtended(ushort fileVersion)
        {
            bool use32BitsIndexes = fileVersion > 13;
#if USE_32BITS_IDS
            if (!use32BitsIndexes)
                Debug.LogError("RTU file is using 16 bits IDs (older format <= RTU v.13) but it should be using 32 bits IDs.");
            else
                Debug.Log("Using 32 bits IDs in RTU");
#else
            if (use32BitsIndexes)
                Debug.LogError("RTU file is using 32 bits IDs (newer format > RTU v.13) but it should be using 16 bits IDs.");
            else
                Debug.Log("Using 16 bits IDs in RTU");
#endif
        }

        public static void SetIdReader(BinaryReader reader)
        {
#if USE_32BITS_IDS
            TrackUnitFile.IdReader = reader.ReadUInt32;
#else
            TrackUnitFile.IdReader = reader.ReadUInt16;
#endif
        }
        public static void SetIdReader(BinaryWriter writer)
        {
            TrackUnitFile.IdWriter = writer.Write;
        }
#if USE_32BITS_IDS
        public static int ReadIDs()
        {
            return (int)TrackUnitFile.IdReader();
        }
        public static void WriteIDs(int value)
        {
            TrackUnitFile.IdWriter((uint)value);
        }
#else
        public static ushort ReadIDs()
        {
            return TrackUnitFile.IdReader();
        }
        public static void WriteIDs(int value)
        {
            TrackUnitFile.IdWriter((ushort)value);
        }
#endif
    }
    public class TrackUnitFile : IBinSerializable
    {
        public const int MAX_MODULE_ROUTES = 2;
        private readonly byte[] HEADER = Encoding.Default.GetBytes("RTU ");
#if USE_32BITS_IDS
        private const ushort VERSION = 14;
#else
        private const ushort VERSION = 13;
#endif
        private const ushort TARGET = 2; // set to 2 with new modules update

        public readonly List<Vector3> Vertices = new List<Vector3>();
        public readonly List<Vector2> UVs = new List<Vector2>();

        public readonly List<Mesh> Meshes = new List<Mesh>();
        public readonly List<Polygon> Polygons = new List<Polygon>();
        public readonly List<ColorPolygon> ColorPolygons = new List<ColorPolygon>();
        public readonly List<Polygon> UVPolygons = new List<Polygon>();
        public readonly List<PolySet> PolySets = new List<PolySet>();

        public readonly List<Unit> Units = new List<Unit>();
        public readonly List<Module> Modules = new List<Module>();

        public int TPageCount;
        public int WallIndex;
    #if USE_32BITS_IDS
        public static Func<uint> IdReader { get; set; }
        public static Action<uint> IdWriter { get; set; }
    #else
        public static Func<ushort> IdReader { get; set; }
        public static Action<ushort> IdWriter { get; set; }
    #endif

        public void ReadBinary(BinaryReader reader)
        {
            byte[] header = reader.ReadBytes(4);
            ushort version = reader.ReadUInt16();
            ushort target = reader.ReadUInt16();
            var headerStr = Encoding.Default.GetString(header);
            var HEADERStr = Encoding.Default.GetString(HEADER);
            if (headerStr != HEADERStr)
                throw new InvalidDataException("Incorrect RTU header.");
            if (version != VERSION || target != TARGET)
                throw new InvalidDataException("RTU file version mismatch: found " + version.ToString() + "." + target.ToString() + ". Requires version " + VERSION.ToString() + "." + TARGET.ToString() + ".");
            
            FileCommon.CheckIndexExtended(version);
            FileCommon.SetIdReader(reader);

            Vertices.Clear();
            UVs.Clear();
            Meshes.Clear();
            Polygons.Clear();
            ColorPolygons.Clear();
            UVPolygons.Clear();
            PolySets.Clear();
            Units.Clear();
            Modules.Clear();

            int vertexCount = FileCommon.ReadIDs();
            for (int i = 0; i < vertexCount; i++)
            {
                Vertices.Add(reader.ReadVector3());
            }

            int polyCount = FileCommon.ReadIDs();
            for (int i = 0; i < polyCount; i++)
            {
                var poly = new Polygon();
                poly.ReadBinary(reader);
                Polygons.Add(poly);
            }

            int rgbPolyCount = FileCommon.ReadIDs();
            for (int i = 0; i < rgbPolyCount; i++)
            {
                var rgbPoly = new ColorPolygon();
                rgbPoly.ReadBinary(reader);
                ColorPolygons.Add(rgbPoly);
            }

            int polySetCount = FileCommon.ReadIDs();
            for (int i = 0; i < polySetCount; i++)
            {
                var polySet = new PolySet();
                polySet.ReadBinary(reader);
                PolySets.Add(polySet);
            }

            int meshCount = FileCommon.ReadIDs();
            for (int i = 0; i < meshCount; i++)
            {
                var mesh = new Mesh();
                mesh.ReadBinary(reader);
                Meshes.Add(mesh);
            }

            int uvCount = FileCommon.ReadIDs();
            for (int i = 0; i < uvCount; i++)
            {
                UVs.Add(reader.ReadVector2());
            }

            int uvPolyCount = FileCommon.ReadIDs();
            for (int i = 0; i < uvPolyCount; i++)
            {
                var poly = new Polygon();
                poly.ReadBinary(reader);
                UVPolygons.Add(poly);
            }

            int unitCount = FileCommon.ReadIDs();
            for (int i = 0; i < unitCount; i++)
            {
                var unit = new Unit();
                unit.ReadBinary(reader);
                Units.Add(unit);

                // the original trackunit file had garbage surface indices
                unit.TrimExcessSurfaces(this);
            }

            int moduleCount = FileCommon.ReadIDs();
            for (int i = 0; i < moduleCount; i++)
            {
                var module = new Module();
                module.ReadBinary(reader);
                Modules.Add(module);

                // set AI node priorities
                // this is really yucky
                foreach(var route in module.Routes)
                {
                    foreach(var node in route.Nodes)
                    {
                        node.Priority = global::Modules.Lookup.ModulePriority[i];
                    }
                }
            }

            this.TPageCount = reader.ReadUInt16();
            this.WallIndex = FileCommon.ReadIDs();
        }

        public void WriteBinary(BinaryWriter writer)
        {
            writer.Write(HEADER);
            writer.Write(VERSION);
            writer.Write(TARGET);
            
            FileCommon.WriteIDs(Vertices.Count);
            for(int i=0; i < Vertices.Count; i++)
            {
                writer.WriteVector3(Vertices[i]);
            }

            FileCommon.WriteIDs(Polygons.Count);
            for (int i = 0; i < Polygons.Count; i++)
            {
                Polygons[i].WriteBinary(writer);
            }
            
            FileCommon.WriteIDs(ColorPolygons.Count);
            for (int i = 0; i < ColorPolygons.Count; i++)
            {
                ColorPolygons[i].WriteBinary(writer);
            }

            FileCommon.WriteIDs(PolySets.Count);
            for (int i = 0; i < PolySets.Count; i++)
            {
                PolySets[i].WriteBinary(writer);
            }

            FileCommon.WriteIDs(Meshes.Count);
            for (int i = 0; i < Meshes.Count; i++)
            {
                Meshes[i].WriteBinary(writer);
            }

            FileCommon.WriteIDs(UVs.Count);
            for (int i = 0; i < UVs.Count; i++)
            {
                writer.WriteVector2(UVs[i]);
            }

            FileCommon.WriteIDs(UVPolygons.Count);
            for (int i = 0; i < UVPolygons.Count; i++)
            {
                UVPolygons[i].WriteBinary(writer);
            }

            FileCommon.WriteIDs(Units.Count);
            for (int i = 0; i < Units.Count; i++)
            {
                Units[i].WriteBinary(writer);
            }

            FileCommon.WriteIDs(Modules.Count);
            for (int i = 0; i < Modules.Count; i++)
            {
                Modules[i].WriteBinary(writer);
            }

            writer.Write((ushort)TPageCount);
            FileCommon.WriteIDs(WallIndex);
        }

        public TrackUnitFile() { }
        public TrackUnitFile(BinaryReader reader)
        {
            ReadBinary(reader);
        }

        public TrackUnitFile(Stream stream)
        {
            ReadBinary(new BinaryReader(stream));
        }
    }
}



