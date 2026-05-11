# Never End

Never End is a small WinForms RPG about returning home with the trail of a missing wife, a handful of quests, a compact world map, simple combat, loot, saving, and a short ending.

## How to Run

Requirements:

- Windows
- .NET 8 SDK or newer

Build:

```powershell
dotnet build .\NeverEnd.sln
```

Run the game:

```powershell
dotnet run --project .\NeverEnd\NeverEnd.csproj
```

Run the engine smoke tests:

```powershell
dotnet run --project .\Engine.SmokeTests\Engine.SmokeTests.csproj
```

## Gameplay

You start at home with a rusty sword, one healing potion, and a trail in the yard.

Main route:

1. Go north from home to the yard and take the main quest.
2. Help the alchemist and farmer to collect supplies and earn the guard pass.
3. Visit the town square for an optional bow quest.
4. Use the guard pass to cross the guard post.
5. Fight through the bridge and dark forest.
6. Bring Anna's ring back to the yard to finish the story.

The game autosaves to `PlayerData.xml` and also has an explicit Save button. Use New Game to reset progress.

## Project Structure

- `Engine` contains the game model: player, world, locations, quests, monsters, loot, and items.
- `NeverEnd` contains the WinForms UI.
- `Engine.SmokeTests` contains a lightweight executable test pass for the most important world rules.

## Current Status

The project has been modernized to SDK-style .NET 8 projects. The game has a playable start-to-finish loop, location images, quest progression, combat, potion buying, save/load, and a final completion state.
