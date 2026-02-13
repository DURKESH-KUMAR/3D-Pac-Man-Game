# Maze Muncher 3D 🎮

A 3D **Pac-Man inspired arcade game** developed using **Unity (C#)**.\
Navigate through a 3D maze, collect dots, avoid ghosts, use power
pellets strategically, and compete for the highest score on the
leaderboard.

------------------------------------------------------------------------

## 🧠 Project Overview

Maze Muncher 3D is a 3D adaptation of the classic Pac-Man gameplay
mechanics. The game features:

-   A structured 3D maze environment
-   AI-driven ghost enemies
-   Collectible dots and energizers
-   Score and lives management
-   Persistent leaderboard system

This project was developed as part of a technical game development
assignment.

------------------------------------------------------------------------

## 🚀 Features

-   🎮 3D Top-Down Maze Gameplay\
-   👻 4 Ghost Enemies with AI (NavMesh-based movement)\
-   ⚡ Energizer (Power Pellet) System\
-   🔢 Score System with Ghost Multiplier\
-   ❤️ Lives System (Game Over on 0 lives)\
-   🕒 3-Second Countdown Before Game Start\
-   🏆 Leaderboard (Top 5 Scores Saved Locally)\
-   💾 Persistent Data using PlayerPrefs

------------------------------------------------------------------------

## 🎮 Controls

  Action       Key
  ------------ -----------------
  Move Up      W / Up Arrow
  Move Down    S / Down Arrow
  Move Left    A / Left Arrow
  Move Right   D / Right Arrow

------------------------------------------------------------------------

## 🎯 Gameplay Mechanics

-   Collect **Small Dots** to earn 10 points each.
-   Collect **Energizers** to:
    -   Earn 50 points
    -   Make ghosts vulnerable for a short duration.
-   Eat ghosts during frightened mode to earn:
    -   1st Ghost: 200 points\
    -   2nd Ghost: 400 points\
    -   3rd Ghost: 800 points\
    -   4th Ghost: 1600 points\
-   Player starts with limited lives.
-   On collision with ghost (normal mode), player loses a life.
-   Game Over when all lives are lost.
-   Final score is saved to the leaderboard.

------------------------------------------------------------------------

## 🏗 Scene Structure

### 1️⃣ HomeScene

-   Player name input
-   Start game button
-   Input validation

### 2️⃣ GameScene

-   Maze environment
-   Player character
-   4 Ghost enemies
-   Dots & Energizers
-   Score & Lives UI
-   Countdown system

### 3️⃣ LeaderboardScene

-   Displays Top 5 scores
-   Sorted in descending order
-   Persistent storage using PlayerPrefs
-   Option to return to HomeScene

------------------------------------------------------------------------

## 📂 Project Structure

    Assets/
     ├── Scenes/
     │   ├── HomeScene.unity
     │   ├── GameScene.unity
     │   ├── LeaderboardScene.unity
     ├── Scripts/
     │   ├── Managers/
     │   ├── Player/
     │   ├── Ghosts/
     │   ├── Collectibles/
     │   ├── UI/
     ├── Prefabs/
     ├── Materials/
     ├── Audio/
    ProjectSettings/
    Packages/
    README.md

------------------------------------------------------------------------

## 🛠 Unity Version

Developed using:

Unity 2021 LTS (or later)

------------------------------------------------------------------------

## 💻 How to Run the Project

### Option 1: Run in Unity

1.  Clone the repository.
2.  Open the project in Unity 2021 LTS or later.
3.  Open **HomeScene**.
4.  Click Play.

------------------------------------------------------------------------

## 📦 How to Build

1.  Go to **File → Build Settings**
2.  Add scenes in this order:
    -   HomeScene
    -   GameScene
    -   LeaderboardScene
3.  Select **PC, Mac & Linux Standalone**
4.  Click **Build**
5.  Run the generated `.exe` file.

------------------------------------------------------------------------

## 📌 Known Limitations

-   Ghost AI behavior is simplified.
-   No mobile input implementation.
-   Basic visual effects (no advanced animations).

------------------------------------------------------------------------

## 👨‍💻 Developer

DURKESH KUMAR S\
Game Developer \| Unity \| C#
