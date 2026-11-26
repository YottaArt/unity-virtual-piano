# Unity Virtual Piano

## Overview

A small 3D virtual piano project developed in Unity as part of a Computer Games Development study task.

The project features an interactive piano keyboard. Players can click individual piano keys using the mouse to play corresponding musical notes.

The main purpose of the project was to practise working with Unity scenes, C# scripts, user interaction and audio playback.

## Features

- **3D Piano:** A piano keyboard constructed using Unity 3D objects.
- **Interactive Keys:** Piano keys respond to mouse clicks.
- **Audio Playback:** Each key is connected to an Audio Source that plays its corresponding musical note.
- **18 Piano Keys:** Includes 11 white keys and 7 black keys.
- **Single Scene:** The project contains one playable piano scene.

## Technologies Used

- Unity
- C#
- Unity Audio System
- Unity Physics and Raycasting

## Project Structure

- `Assets/Scenes/` – Contains the piano scene.
- `Assets/Scripts/` – Contains the C# scripts used for piano interaction and audio playback.
- `Assets/` – Contains audio files and other project resources.
- `Packages/` – Contains Unity package dependencies.
- `ProjectSettings/` – Contains project configuration.

## How It Works

The project uses two main scripts:

- **ButtonScript:** Uses mouse input and raycasting to detect clicks on piano keys.
- **MusicNoteCode:** Stores references to the Audio Sources and provides functions for playing individual notes.

Each piano key is connected to the appropriate note-playing function through Unity's Inspector and Button click events.

## Learning Outcomes

Through this project, I practised:

- Creating and positioning 3D objects in Unity.
- Working with C# scripts and MonoBehaviour.
- Detecting mouse interaction using raycasting.
- Connecting GameObjects and scripts through the Unity Inspector.
- Configuring Audio Sources and playing audio clips.
- Using Unity events to trigger functions.

## Development Status

Completed as a small study project. The project focuses on basic interactive functionality and audio playback rather than a fully featured piano application.
