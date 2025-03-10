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

using ReVolt.TrackUnit;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public partial class TrackExporter
{
    private ReVolt.Track.WorldFile world;
    private ReVolt.Track.SmallCube[] cellCubes;

    private Color GetShadedColor(Color color, Vector3 normal)
    {
        float shading = 1f - (normal.x * 0.05f);
        return color * shading;
    }

    private Color GetWallColor(float height, Vector3 normal)
    {
        return GetShadedColor(Color.Lerp(wallMin,
                                         wallMax,
                                         Mathf.Abs(height) / (maxElevation * RVConstants.SMALL_CUBE_SIZE)),
                                         normal);
    }

    private float GetPolyTexCoord(float pos, float polyCenterPos)
    {
        return pos / RVConstants.SMALL_CUBE_SIZE;

        // Contain UVs in the [0~1] space.
        // This would need to cut tall walls
        // Since TEXTUREPROPS allow for multiple out-of-the-box wrapping options: dropped this impl.
        /*
        float modPos = pos % RVConstants.SMALL_CUBE_SIZE;
        float modPolyCenter = polyCenterPos % RVConstants.SMALL_CUBE_SIZE;
        if (modPos < 0f)
        {
            modPos += RVConstants.SMALL_CUBE_SIZE;
        }
        if (modPolyCenter < 0f)
        {
            modPolyCenter += RVConstants.SMALL_CUBE_SIZE;
        }
        if (pos > polyCenterPos)
        {
            if (modPos < modPolyCenter)
            {
                modPos += RVConstants.SMALL_CUBE_SIZE;
            }
        }
        else
        {
            if(modPos > modPolyCenter)
            {
                modPos -= RVConstants.SMALL_CUBE_SIZE;
            }
        }
        return modPos / RVConstants.SMALL_CUBE_SIZE;
        */
    }

    private Vector2 GetWallUVs(Vector3 pos, Vector3 normal, Vector3 polyCenterPos)
    {
        // offset by half unit horizontally so wall side will end up normalized between [0~1] and not [0.5~1.5]
        Vector3 polyUVW = new Vector3(
            GetPolyTexCoord(pos.x - RVConstants.SMALL_CUBE_HALF, polyCenterPos.x - RVConstants.SMALL_CUBE_HALF),
            GetPolyTexCoord(pos.y, polyCenterPos.y),
            GetPolyTexCoord(pos.z - RVConstants.SMALL_CUBE_HALF, polyCenterPos.z - RVConstants.SMALL_CUBE_HALF)
        );
        return new Vector2(polyUVW.x * Mathf.Abs(normal.z) + polyUVW.z * Mathf.Abs(normal.x), polyUVW.y);
    }

    private ReVolt.Track.SmallCube UnitToSmallCube(Unit unit, Matrix4x4 matrix, bool[] wallData = null)
    {
        var cube = new ReVolt.Track.SmallCube();
        
        Vector3 unitPosition = matrix.GetColumn(3);
        Vector3 unitFloorPosition = new Vector3(unitPosition.x, 0f, unitPosition.z);

        var mesh = unitFile.Meshes[unit.MeshID];
        int vertexIndexCounter = 0;

        // create root
        if (wallData != null)
        {
            int tpage = wallTex >= 0 ? wallTex : -1;
            for (int i = 0; i < 4; i++)
            {
                if (!wallData[i])
                    continue;

                var wallVerts = rootVertsArray[i];
                var wallNormal = rootNormalsArray[i];

                var wallColorTop = GetWallColor(unitPosition.y, wallNormal);
                var wallColorBottom = GetShadedColor(wallMin, wallNormal);
                Vector2[] uvCoordinates = new Vector2[] { Vector2.zero, Vector2.zero, Vector2.zero, Vector2.zero };
                Vector3[] vertPos = new Vector3[] {
                    wallVerts[0] + unitFloorPosition,
                    wallVerts[1] + unitFloorPosition,
                    wallVerts[1] + unitPosition,
                    wallVerts[0] + unitPosition
                };
                Vector3 polyCenter = (vertPos[0] + vertPos[1] + vertPos[2] + vertPos[3]) / 4.0f;
                if (wallTex >= 0)
                {
                    uvCoordinates[0] = GetWallUVs(vertPos[0], wallNormal, polyCenter);
                    uvCoordinates[1] = GetWallUVs(vertPos[1], wallNormal, polyCenter);
                    uvCoordinates[2] = GetWallUVs(vertPos[2], wallNormal, polyCenter);
                    uvCoordinates[3] = GetWallUVs(vertPos[3], wallNormal, polyCenter);
                }

                // add wall quad to cube
                cube.Vertices.Add(new ReVolt.Track.Vertex(vertPos[0], wallNormal));
                cube.Vertices.Add(new ReVolt.Track.Vertex(vertPos[1], wallNormal));
                cube.Vertices.Add(new ReVolt.Track.Vertex(vertPos[2], wallNormal));
                cube.Vertices.Add(new ReVolt.Track.Vertex(vertPos[3], wallNormal));

                cube.Polygons.Add(new ReVolt.Track.Polygon()
                {
                    Colors = new Color[] { wallColorBottom, wallColorBottom, wallColorTop, wallColorTop },
                    TextureNum = (short)tpage,
                    VertexIndices = new int[] { vertexIndexCounter++, vertexIndexCounter++, vertexIndexCounter++, vertexIndexCounter++ },
                    UVCoordinates = uvCoordinates,
                    Flags = ReVolt.Track.PolygonFlags.Quad
                });
            }
        }

        // export unit
        for (int i = RVConstants.PEG_INDEX; i <= RVConstants.PAN_INDEX; i++)
        {
            var polySet = unitFile.PolySets[mesh.PolySets[i]];
            for (int j = 0; j < polySet.PolygonIndices.Count; j++)
            {
                var poly = unitFile.Polygons[polySet.PolygonIndices[j] & ~RVConstants.GOURAUD_SHIFTED];
                int polyIndexCount = (poly.Indices.Length == 3) ? 3 : 4;

                ReVolt.Track.PolygonFlags polyFlags = (polyIndexCount == 3) ? ReVolt.Track.PolygonFlags.None :
                                                                              ReVolt.Track.PolygonFlags.Quad;

                Vector3[] transformedPolyVerts = new Vector3[polyIndexCount];
                for (int k = 0; k < polyIndexCount; k++)
                {
                    transformedPolyVerts[k] = matrix.MultiplyPoint3x4(unitFile.Vertices[poly.Indices[k]]);
                }
                Vector3 polyCenter = transformedPolyVerts[0];
                for (int k = 1; k < polyIndexCount; k++)
                {
                    polyCenter += transformedPolyVerts[k];
                }
                polyCenter /= polyIndexCount;

                // add verts
                Vector3 normal = CalculateNormal(transformedPolyVerts);
                for (int k = 0; k < polyIndexCount; k++)
                    cube.Vertices.Add(new ReVolt.Track.Vertex(transformedPolyVerts[k], normal));

                // add poly
                // Shift IDs!
                int[] vertexIndices = (polyIndexCount == 3) ? new int[] { vertexIndexCounter + 1, vertexIndexCounter + 0, vertexIndexCounter + 2, vertexIndexCounter + 3 }
                                                            : new int[] { vertexIndexCounter + 2, vertexIndexCounter + 1, vertexIndexCounter + 0, vertexIndexCounter + 3 };

                Color[] colors = new Color[] { Color.white, Color.white, Color.white, Color.white };
                Vector2[] uvCoordinates = new Vector2[] { Vector2.zero, Vector2.zero, Vector2.zero, Vector2.zero };
                int tpage = -1;

                if (i == RVConstants.PAN_INDEX)
                {
                    var uvPolyInst = unit.UVPolys[j];
                    var uvPoly = unitFile.UVPolygons[uvPolyInst.PolyID];
                    var rgbPoly = unitFile.ColorPolygons[unit.RGBs[j]];

                    tpage = (uvPolyInst.TPage & ~RVConstants.UV_REVERSED) - 1;

                    int uModValue = polyIndexCount;
                    int uvIndex = uvPolyInst.Rotation;
                    int uvStep = ((uvPolyInst.TPage & RVConstants.UV_REVERSED) != 0) ? (uModValue - 1) : 1;

                    for (int k = 0; k < polyIndexCount; k++)
                    {
                        int id = (polyIndexCount * 2 - k - 2) % polyIndexCount; // Shift IDs!
                        uvCoordinates[id] = unitFile.UVs[uvPoly.Indices[uvIndex]];
                        colors[id] = rgbPoly.Colors[k];
                        colors[id].a = 1f;

                        uvIndex = (uvIndex + uvStep) % uModValue;
                    }
                }
                else
                {
                    if (wallTex >= 0)
                    {
                        tpage = wallTex;
                    }
                    for (int k = 0; k < polyIndexCount; k++)
                    {
                        int id = (polyIndexCount * 2 - k - 2) % polyIndexCount; // Shift IDs!
                        colors[id] = GetWallColor(transformedPolyVerts[k].y, normal);
                        if (wallTex >= 0)
                        {
                            uvCoordinates[id] = GetWallUVs(transformedPolyVerts[k], normal, polyCenter);
                        }
                    }
                }

                cube.Polygons.Add(new ReVolt.Track.Polygon()
                {
                    Colors = colors,
                    TextureNum = (short)tpage,
                    VertexIndices = vertexIndices,
                    UVCoordinates = uvCoordinates,
                    Flags = polyFlags
                });

                vertexIndexCounter += polyIndexCount;
            }
        }

        //
        cube.CalculateBounds();
        return cube;
    }

    private ReVolt.Track.SmallCube CellToSmallCube(EditorTrackCell cell)
    {
        var unit = unitFile.Units[GetUnitInCell(cell)];
        var cellMatrix = MakeCellMatrix(cell);
        bool[] wallData = new bool[] { unit.CheckRootEdge(mod(0 - cell.Module.Rotation, 4)) && cell.CheckWall(track, Modules.Direction.North),
                                       unit.CheckRootEdge(mod(1 - cell.Module.Rotation, 4)) && cell.CheckWall(track, Modules.Direction.East),
                                       unit.CheckRootEdge(mod(2 - cell.Module.Rotation, 4)) && cell.CheckWall(track, Modules.Direction.South),
                                       unit.CheckRootEdge(mod(3 - cell.Module.Rotation, 4)) && cell.CheckWall(track, Modules.Direction.West)};
        
        return UnitToSmallCube(unit, cellMatrix, wallData);
    }

    private void FixUpWorld(int x, int y)
    {
        var srcCube = cellCubes[(y * track.Width) + x];
        ReVolt.Track.SmallCube[] adjacentCubes = new ReVolt.Track.SmallCube[4];

        if (x > 0)                 adjacentCubes[0] = cellCubes[(y * track.Width) + (x - 1)];
        if (x < track.Width - 1)   adjacentCubes[1] = cellCubes[(y * track.Width) + (x + 1)];
        if (y > 0)                 adjacentCubes[2] = cellCubes[((y - 1) * track.Width) + x];
        if (y < track.Height - 1)  adjacentCubes[3] = cellCubes[((y + 1) * track.Width) + x];

        for (int adjCubeIndex = 0; adjCubeIndex < 4; adjCubeIndex++)
        {
            if (adjacentCubes[adjCubeIndex] == null)
                continue;

            var adjCube = adjacentCubes[adjCubeIndex];

            for (int i = srcCube.Polygons.Count - 1; i >= 0; i--)
            {
                var srcPoly = srcCube.Polygons[i];
                var normalI = srcCube.Vertices[srcPoly.VertexIndices[0]].Normal;

                for (int j = adjCube.Polygons.Count - 1; j >= 0; j--)
                {
                    
                    var adjPoly = adjCube.Polygons[j];
                    var normalJ = adjCube.Vertices[adjPoly.VertexIndices[0]].Normal;

                    bool facing = (srcPoly.Flags & ReVolt.Track.PolygonFlags.Quad) == (adjPoly.Flags & ReVolt.Track.PolygonFlags.Quad) &&
                                  Mathf.Abs(normalI.x - -normalJ.x) <= FIX_TOLERANCE && Mathf.Abs(normalI.y - -normalJ.y) <= FIX_TOLERANCE &&
                                  Mathf.Abs(normalI.z - -normalJ.z) <= FIX_TOLERANCE;
                    
                    if (!facing)
                        continue;

                    // first we find the start vertex (the first matching vertex)
                    int vertCount = ((srcPoly.Flags & ReVolt.Track.PolygonFlags.Quad) != 0) ? 4 : 3;
                    int startVertex = 0; 
                    bool matching = false;
                    
                    for(int k=0; k < vertCount && !matching; k++)
                    {
                        var vertA = srcCube.Vertices[srcPoly.VertexIndices[0]].Position;
                        var vertB = adjCube.Vertices[adjPoly.VertexIndices[k]].Position;

                        matching = Mathf.Abs(vertA.x - vertB.x) <= FIX_TOLERANCE
                                && Mathf.Abs(vertA.y - vertB.y) <= FIX_TOLERANCE 
                                && Mathf.Abs(vertA.z - vertB.z) <= FIX_TOLERANCE;

                        startVertex = k;
                    }

                    // can't find a matching start vertex
                    if (!matching)
                        continue;
                    
                    // compare vertex positions in opposite winding order
                    for(int k=0; k < vertCount && matching; k++)
                    {
                        int index0 = k;
                        int index1 = mod(startVertex - k, vertCount);

                        var vertA = srcCube.Vertices[srcPoly.VertexIndices[index0]].Position;
                        var vertB = adjCube.Vertices[adjPoly.VertexIndices[index1]].Position;

                        matching = Mathf.Abs(vertA.x - vertB.x) <= FIX_TOLERANCE
                                && Mathf.Abs(vertA.y - vertB.y) <= FIX_TOLERANCE
                                && Mathf.Abs(vertA.z - vertB.z) <= FIX_TOLERANCE;
                    }

                    if (matching)
                    {
                        srcCube.Polygons.RemoveAt(i);
                        adjCube.Polygons.RemoveAt(j);
                        break;
                    }
                }
            }
        }
    }

    private void FixUpWorld()
    {
        // checkerboard search
        for (int y = 0; y < track.Height; y++)
        {
            for (int x = y % 2; x < track.Width; x += 2)
            {
                FixUpWorld(x, y);
            }
        }
    }

    public void CreateWorld()
    {
        world = new ReVolt.Track.WorldFile();
        var perfLogger = new PerfTimeLogger("Export:World");

        // create user track visuals
        cellCubes = new ReVolt.Track.SmallCube[track.Width * track.Height];
        for(int i=0; i < cellCubes.Length; i++)
        {
            int x = i % track.Width;
            int y = i / track.Width;
            var cell = track.GetCell(x, y);
            cellCubes[i] = CellToSmallCube(cell);
        };
        perfLogger.Log("Create cell cubes");

        // remove polygons inside module connections that exactly face each other
        FixUpWorld();
        perfLogger.Log("Remove extra polygons");

        // add user track
        world.SmallCubes.AddRange(cellCubes);

        // add external walls
        if (exportScenery)
        {
        for (int i = 0; i < 6; i++)
            {
                var wallUnit = unitFile.Units[i + unitFile.WallIndex];
                var wallCube = UnitToSmallCube(wallUnit, wallMatrices[i]);
                world.SmallCubes.AddRange(wallCube.SplitCube(RVConstants.SMALL_CUBE_SIZE));
            }
            perfLogger.Log("Create walls");
        }

        // generate big cubes
        world.GenerateBigCubes(RVConstants.BIG_CUBE_SIZE);
        perfLogger.Log("Create big cubes");

        // scale
        if (exportScale != 1f)
        {
            world.Scale(exportScale);
            perfLogger.Log("Scale");
        }
    }

    public void WriteWorldFile()
    {
        string worldFilePath = Path.Combine(exportPath, $"{trackFolderName}.w");
        world.Save(worldFilePath);
    }
}
