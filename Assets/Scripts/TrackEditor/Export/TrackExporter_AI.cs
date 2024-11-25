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
using UnityEngine;

public partial class TrackExporter
{
    public bool AIIsValid { get; private set; } = false;
    public int AINodeCount => processedAiNodes.Count;
    public Vector2Int LastAICell { get; private set; }

    const float AIMergeThreshold =  20f;
    const float AIHeightMergeThreshold = 0.25f;

    private readonly List<ReVolt.TrackUnit.AINode> processedAiNodes = new List<ReVolt.TrackUnit.AINode>(1024);

    private IEnumerable<ReVolt.TrackUnit.AINode> EnumRoute(ReVolt.TrackUnit.Route route, int direction, bool flipped)
    {
        for (int i = 0; i < route.Nodes.Count; i++)
        {
            int index = (direction < 0) ? route.Nodes.Count - i - 1 : i;
            var node = route.Nodes[index];

            yield return new ReVolt.TrackUnit.AINode()
            {
                RedPosition = (flipped) ? node.GreenPosition : node.RedPosition,
                GreenPosition = (flipped) ? node.RedPosition : node.GreenPosition,
                Priority = node.Priority,
                RacingLine = (flipped) ? 1f - node.RacingLine : node.RacingLine
            };
        }
    }

    private bool IsJumpModule(in int ModuleIndex)
    {
        return ModuleIndex == (int)Modules.ID.TWM_JUMP;
    }
    private bool CheckNodeMatch(Vector3 next, Vector3 current, in bool isJump)
    {
        bool isWithinXYRange = Vector2.Distance(next.ToVec2XZ(), current.ToVec2XZ()) <= AIMergeThreshold;
        return isJump ? isWithinXYRange : isWithinXYRange && (current.y - next.y) < AIHeightMergeThreshold;
    }

    private bool CheckNodeMatch(Vector3 lastGreenPos, Vector3 lastRedPos, ModulePlacement nextModule, 
                                out int routeIndex, out bool flipped, out int direction, out float heightDelta,
                                in bool prevWasJump, out bool wasReallyJump)
    {
        direction = 0;
        routeIndex = -1;
        flipped = false;
        heightDelta = 0f;
        wasReallyJump = false;

        var module = unitFile.Modules[nextModule.ModuleIndex];
        var modMatrix = MakeModuleMatrix(nextModule);

        for (int i = 0; i < module.Routes.Count; i++)
        {
            routeIndex = i;
            var route = module.Routes[i];
            for (int j = 0; j < 2; j++)
            { 
                var checkNode = route.Nodes[(j == 0) ? 0 : route.Nodes.Count - 1];
                Vector3 greenPos = modMatrix.MultiplyPoint3x4(checkNode.GreenPosition);
                Vector3 redPos = modMatrix.MultiplyPoint3x4(checkNode.RedPosition);

                if (CheckNodeMatch(greenPos, lastRedPos, prevWasJump) || CheckNodeMatch(redPos, lastGreenPos, prevWasJump))
                {
                    heightDelta = ((lastRedPos.y - greenPos.y) + (lastGreenPos.y - redPos.y)) / 2f;
                    wasReallyJump = prevWasJump && heightDelta > 0f;
                    direction = (j == 0) ? 1 : -1;
                    flipped = true;
                    return true;
                }
                else if (CheckNodeMatch(redPos, lastRedPos, prevWasJump) || CheckNodeMatch(greenPos, lastGreenPos, prevWasJump))
                {
                    heightDelta = ((lastRedPos.y - redPos.y) + (lastGreenPos.y - greenPos.y)) / 2f;
                    wasReallyJump = prevWasJump && heightDelta > 0f;
                    direction = (j == 0) ? 1 : -1;
                    flipped = false;
                    return true;
                }
             }
        }
        return false;
    }

    public void CreateAINodes()
    {
        var perfLogger = new PerfTimeLogger("Export:AI");
        LastAICell = Vector2Int.zero;
        processedAiNodes.Clear();

        if (zoneSequence.Count == 0 || this.startModule == null)
        {
            AIIsValid = false;
            return;
        }

        Vector3 lastGreenPos = Vector3.zero;
        Vector3 lastRedPos = Vector3.zero;
        bool lastWasJump = false;
        
        var startZone = zones[zoneSequence[0].ZoneID];
        var startCell = track.GetCell(startZone.CellCoordinate);
        var startModule = unitFile.Modules[startCell.Module.ModuleIndex];
        var startModMatrix = MakeModuleMatrix(startCell.Module);

        //add the start nodes
        if (startModule.Routes.Count == 0) // this shouldn't happen
        {
            AIIsValid = false;
            return;
        }

        foreach (var node in EnumRoute(startModule.Routes[0], 1, false))
        {
            lastRedPos = startModMatrix.MultiplyPoint3x4(node.RedPosition);
            lastGreenPos = startModMatrix.MultiplyPoint3x4(node.GreenPosition);
            processedAiNodes.Add(new ReVolt.TrackUnit.AINode() { RedPosition = lastRedPos, GreenPosition = lastGreenPos, 
                                                                 RacingLine = node.RacingLine, Priority = node.Priority });
        }

        //now go through the rest of the modules
        foreach(var placement in EnumModules())
        {
            LastAICell = placement.Position;

            // if this fails, there has been a continuity error
            if (!CheckNodeMatch(lastGreenPos, lastRedPos, placement, out int routeIndex, out bool flipped, out int direction, out float heightDelta, lastWasJump, out bool lastWasReallyJump))
            {
                Debug.LogError($"AI Continuity Error");
                AIIsValid = false;
                return;
            }

            var module = unitFile.Modules[placement.ModuleIndex];
            var modMatrix = MakeModuleMatrix(placement);

            bool first = true;
            foreach(var node in EnumRoute(module.Routes[routeIndex], direction, flipped))
            {
                //merge and blend if first
                if (first)
                {
                    // If jump really occured, modify first AI priority to JumpWall
                    // Dont rely solely on Jump Module index but also on height difference:
                    // we dont want to alter slowDown priorities if not necessary
                    var currentPriority = lastWasReallyJump ? ReVolt.Track.AINodePriority.JumpWall : node.Priority;
                    first = false;
                    processedAiNodes[AINodeCount - 1].RacingLine = (processedAiNodes[AINodeCount - 1].RacingLine + node.RacingLine) / 2f;
                    processedAiNodes[AINodeCount - 1].Priority = currentPriority;

                    if (lastWasReallyJump)
                    {
                        lastRedPos = modMatrix.MultiplyPoint3x4(node.RedPosition);
                        lastGreenPos = modMatrix.MultiplyPoint3x4(node.GreenPosition);
                        processedAiNodes[AINodeCount - 1].RedPosition = lastRedPos;
                        processedAiNodes[AINodeCount - 1].GreenPosition = lastGreenPos;
                    }
                    continue;
                }

                // add the rest of the nodes to the list
                lastRedPos = modMatrix.MultiplyPoint3x4(node.RedPosition);
                lastGreenPos = modMatrix.MultiplyPoint3x4(node.GreenPosition);
                processedAiNodes.Add(new ReVolt.TrackUnit.AINode() { GreenPosition = lastGreenPos, RedPosition = lastRedPos, 
                                                                     RacingLine = node.RacingLine, Priority = node.Priority });
            }

            lastWasJump = IsJumpModule(placement.ModuleIndex);
        }

        // check if a valid loop has been made
        // count > start module node count
        AIIsValid = processedAiNodes.Count > 2;
        if (!TrackFormsSprint)
        {
            // In case we jumped, didnt bother check if JumpWall property is needed
            // it wont change anything on straight start grid
            // (Priority should be set on RacingLine wich should not change anything in AI speed)
            if (lastWasJump)
            {
                processedAiNodes[0].Priority = ReVolt.Track.AINodePriority.JumpWall;
            }
            // check end == start
            AIIsValid &= CheckNodeMatch(processedAiNodes[0].RedPosition, processedAiNodes[processedAiNodes.Count - 1].RedPosition, lastWasJump)
                      && CheckNodeMatch(processedAiNodes[0].GreenPosition, processedAiNodes[processedAiNodes.Count - 1].GreenPosition, lastWasJump);

            // remove last node, it's on top of the first node
            processedAiNodes.RemoveAt(processedAiNodes.Count - 1);
        }

        perfLogger.Log("Create");
    }

    public void WriteAINodes()
    {
        var aiNodesFile = new ReVolt.Track.AINodesFile()
        {
            TotalDistance = lapDistance,
            StartNode = 1
        };

        for(int i=0; i < AINodeCount; i++)
        {
            var node = processedAiNodes[i];

            var fileNode = new ReVolt.Track.AINode()
            {
                StartNode = 1,
                RacingLine = 1f - node.RacingLine,
                OvertakingLine = 1f - node.RacingLine,
                RacingLineSpeed = 30,
                CenterSpeed = 30,
                PreviousLinkIDs = new int[2] { (i + (AINodeCount - 1)) % AINodeCount, -1 },
                NextLinkIDs = new int[2] { (i + 1) % AINodeCount, -1 },
                Priority = node.Priority,
                RedEnd = new ReVolt.Track.AINodeEnd()
                {
                    Speed = 30,
                    Position = node.RedPosition
                },
                GreenEnd = new ReVolt.Track.AINodeEnd()
                {
                    Speed = 30,
                    Position = node.GreenPosition
                }
            };

            aiNodesFile.Nodes.Add(fileNode);
        }

        if (TrackFormsSprint)
        {
            // Unlink end nodes
            aiNodesFile.Nodes[0].PreviousLinkIDs[0] = -1;
            aiNodesFile.Nodes[aiNodesFile.Nodes.Count - 1].NextLinkIDs[0] = -1;
        }

        if(exportScale != 1f)
        {
            aiNodesFile.Scale(exportScale);
        }

        string aiFilePath = Path.Combine(exportPath, $"{trackFolderName}.fan");
        aiNodesFile.Save(aiFilePath);
    }
}
