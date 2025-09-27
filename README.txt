Hex of Steel – Template Mod for Harmony
====================================================================

This template project contains the very basics necessary for creating mods for Hex of Steel using the Harmony library.
Mods allow you to change or extend the game’s behavior without touching the original game files.

====================================================================



What is Harmony?
----------------
Harmony is a .NET library that lets you patch, replace, or extend methods in existing code at runtime.
In short: it’s the tool that makes modding possible for Unity-based games like Hex of Steel.

====================================================================

Getting Started
----------------
1. Install the prerequisites
- .NET 8 SDK (see Resources section for download link)
- Visual Studio Code (or any other C# IDE) (see Resources section for download link)

2. Open the project
- Launch your IDE and open this example mod project.

3. Explore the code
- Take a look at the .cs (C# source code) files. These are where your mod logic goes.

4. Build the project
- In VS Code: Terminal → Run Task → dotnet: build
Or from the terminal: dotnet build

After building, the mod DLL will be created in the output folder.

What’s a DLL?
----------------
A DLL (Dynamic Link Library) is the compiled version of your mod. The game loads it when your mod is enabled.

5. Add the DLL to your mod folder
- In Hex of Steel, create a new mod (or open one you’ve already made).
- Place the DLL into your mod’s libraries folder.

6. Enable your mod in the game
- Launch Hex of Steel.
- Go to the mod menu and enable your mod.
- Check the game for your changes!

====================================================================

Debugging
----------------
If your mod doesn’t work or crashes, check the Player.log file. It records all errors and helpful debug messages.

Player.log locations:
- Windows: %USERPROFILE%\AppData\LocalLow\War Frogs Studio\Hex of Steel\Player.log
- MacOS: ~/Library/Logs/War Frogs Studio/Hex of Steel/Player.log
- Linux: ~/.config/unity3d/War Frogs Studio/Hex of Steel/Player.log

====================================================================

Resources
---------------------------------------------------------------------
- Hex of Steel Community: https://discord.gg/Tn63mrwJyH
- .NET 8 SDK: https://dotnet.microsoft.com/en-us/download/dotnet/8.0
- Visual Studio Code (lightweight IDE): https://code.visualstudio.com
- Harmony Documentation: https://harmony.pardeike.net/

====================================================================

Tips
----------------
- Install IDE extensions (like the Unity extension for VS Code) to improve your workflow.
- Always check Hex of Steel updates for compatibility — mods may break after a new patch.
- Coding assistants (like ChatGPT or Copilot) can help you write and debug Harmony patches faster.
- Share your mods and collaborate with the community!

====================================================================

Advanced Notes
----------------
- Inlining & tiny methods: Some very short methods (1–2 lines) may silently fail to patch because of runtime optimizations. If this happens, let the developer know — inlining can be disabled.
- Key system: The current system uses int32 hashes for modded property keys. Collisions are extremely rare (~0.000115%) but technically possible.
- Code refactoring: If you need parts of the game code refactored to make modding easier, reach out — improvements can often be added.