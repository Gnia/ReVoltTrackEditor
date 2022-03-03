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

using TMPro;
using UnityEngine;

public class FailScreen : MonoBehaviour
{
    public static string FailMessage;

    public TMP_Text Text;

    public static void Show()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("FailScene");
    }

    private void Awake()
    {
        string text = "<u>Track editor failed to initialize</u>\n\n";
        if (!string.IsNullOrEmpty(FailMessage))
        {
            text += FailMessage + "\n\n";
        }
        text += "Press Any Button to Exit";

        Text.text = text;
    }

    void Update()
    {
        if (Controls.AnyButtonPressed())
            Application.Quit();
    }
}