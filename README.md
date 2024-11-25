# ReVoltTrackEditor
A re-make of the Re-Volt Track Editor in Unity 2020.3.21f1  
![Preview Image](preview.png?raw=true "Preview")

## Releases
You can find releases over on Re-Volt World: https://www.revoltworld.net/dl/track-editor-unity-edition/

## Installation
Put all the files in a folder named `editor` placed alongside your `levels` folder.

This 'editor' folder should contain the original Track Editor files (wavs, bitmaps, and trackunit.rtu).

You can obtain these files [here](https://www.mediafire.com/file/6rimevzh3xljmzn/editor_files.zip/file) (Note that these files come from the original editor and are not covered under the LICENSE)
Note: these files can also be found alongside track editor releases.

This is what the original Re-Volt installation folder structure would look like:

YourDrive:\YourGames\Re-Volt  
\-- editor  
\--- trackunit.rtu  
\--- (other track editor files...)  
\-- levels 
\--- (re-volt levels)  

Exporting levels to Android works by automatically detecting an RVGL installation.

## Custom installation
From version 1.4, you can put the editor in any folder but you will need to provide paths to the game content folder and/or to the editor files.

If you dont install the editor in the proper folder structure as stated above:
- add a `game_path.txt` file next to the track editor executable file with the path to the game content (in the example above it would be `YourDrive:\YourGames\Re-Volt`)

If you wish to keep editor files in a separate folder than the track editor executable folder:
- add a `editor_path.txt` file next to the track editor executable file with the path to the `editor` files folder  (in the example above it would be `YourDrive:\YourGames\Re-Volt\editor`)

Example with RVGL install: you can either put the editor folder in your local folder alongside the `levels` folder. If not: add a line like `C:\Your Rvgl Path\rvmm\packs\local` in `game_path.txt` next to the track editor executable file.
Then put all original track editor files in the same folder as the track editor executable. If not: add a `editor_path.txt` pointing to the proper location.

## Running (in the Unity Editor)
This requires the `editor_path.txt` file properly filled. Open it and set this to the path where your editor files exist, from there it will just run.

## Platform Support
The editor has been tested on Windows, Linux, and Android. It should also work on Mac. There is currently no Android UI and to use it on Android you must use a gamepad.

## Builds
Pre-built binaries are available on the [Releases](https://github.com/Dummiesman/ReVoltTrackEditor/releases) page
