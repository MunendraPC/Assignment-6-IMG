Pathfinding Ninja Game 🥷🍎

A small 2D platformer built in Godot 4.4 (C#) where you play as a nimble ninja, collect apples, and avoid an enemy that pathfinds to your position using Godot’s navigation system.

Gameplay

Explore a tile-based level with platforms and obstacles.

Collect apples to increase your score.

Enemy AI chases you via NavigationAgent2D pathfinding, forcing you to keep moving.

Simple, satisfying platformer movement with jump + run animations.

Features

✅ 2D platformer controller (run, jump, gravity).

✅ Animated player states (idle / run / jump / fall).

✅ Collectible apples that update score.

✅ Enemy that follows the player using real-time pathfinding.

✅ TileMap + NavigationRegion2D setup for walkable paths.

✅ Particle / visual flair in the level.

Controls
Action	Key
Move Left	A / Left Arrow
Move Right	D / Right Arrow
Jump	Space
Quit	Esc (or window close)
How to Play

Start the game.

Move through the level and grab apples.

Don’t let the enemy catch you—use platforms and terrain to escape.

Try to collect everything!

Running the Project
Requirements

Godot 4.4+ with .NET / C# support enabled.

Optional: VS Code / Visual Studio for editing scripts.

Steps

Download / clone the repo.

Open the folder in Godot.

Press Play (F5) to run main.tscn.

Project Structure (quick tour)

main.tscn — The main level scene (TileMap, NavigationRegion2D, Player, Enemy, Apples).

player.tscn + Player.cs — Player character, movement + animation control.

enemy.tscn + Enemy.cs — Pathfinding enemy driven by NavigationAgent2D.

area_2d.tscn + Area2d.cs — Apple pickup logic.

Free/ — Art / sprites / tiles / items used in the game.

Built With

Godot Engine 4.4 (.NET)

C# scripts for player, enemy, and pickups

NavigationAgent2D + NavigationRegion2D for AI pathfinding

Credits & Sources
Tutorial

This project was created by following the Coco Code Godot beginner tutorial. The video is part of Coco Code’s free “Godot Mega Tutorial” course and covers the core pieces used here:

setting up sprites + animations

building a TileMap / TileSet level

adding player movement + jumping

creating pickups / collectibles

assembling a first playable platformer scene 
Coco Code Learn
+2
YouTube
+2

Tutorial title:
“Start Your Game Creation Journey Today! (Godot beginner tutorial)” – Coco Code 
YouTube
+1

Assets

All game art used in this repo is included under the Free/ folder.
These are free-to-use pixel platformer assets (characters, terrain, items, traps).
Please check the original asset pack/license if you plan to redistribute commercially.

Notes / Future Ideas

Add health / damage system.

Add multiple enemy types or patrol behaviors.

Add UI for apple count and win/lose states.

More levels + level select.

Citation 

Tutorial title:
“Start Your Game Creation Journey Today! (Godot beginner tutorial)” – Coco Code 
YouTube - https://www.youtube.com/watch?v=5V9f3MT86M8&t=1198s


ChatGPT (Assitance in code fixing)
