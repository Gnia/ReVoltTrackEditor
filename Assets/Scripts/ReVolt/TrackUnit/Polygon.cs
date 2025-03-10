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

using System.IO;

namespace ReVolt.TrackUnit
{
    public class Polygon : IBinSerializable
    {
        public int[] Indices;

        public void ReadBinary(BinaryReader reader)
        {
            int sideCount = reader.ReadUInt16();

            Indices = new int[sideCount];
            for (int i = 0; i < sideCount; i++)
            {
                this.Indices[i] = FileCommon.ReadIDs();
            }
        }

        public void WriteBinary(BinaryWriter writer)
        {
            writer.Write((ushort)Indices.Length);

            for(int i=0; i < Indices.Length; i++)
            {
                FileCommon.WriteIDs(Indices[i]);
            }
        }
    }
}