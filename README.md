# 🎮 Unity 2D Platformer Core

A 2D platformer game built with Unity, featuring movement mechanics, jump systems, enemy interactions, collectibles, sound effects, mobile support, and a complete game flow with main menu and game over screens.

![Unity](https://img.shields.io/badge/Unity-6.3_LTS-black?logo=unity)
![Platform](https://img.shields.io/badge/Platform-PC%20%7C%20Android%20%7C%20macOS%20%7C%20iOS-blue)
![License](https://img.shields.io/badge/License-MIT-green)

## ✨ Features

### 🎮 Core Mechanics
- **🏃 Player Movement** - Smooth WASD/arrow key controls with air control
- **⬆️ Jump Mechanics** - Variable jump height based on button hold duration
- **⏸️ Pause System** - Full pause menu with resume, restart, and quit options
- **🎮 Input System** - Modern Unity Input System (keyboard + touch)
- **🔧 Physics-Based** - Rigidbody2D with custom gravity multipliers

### 🎯 Gameplay Features
- **👾 Enemy AI** - Patrol-based enemies with stomp mechanic (Mario-style!)
- **⚠️ Hazards** - Damage-dealing obstacles
- **🪙 Collectibles** - Coin system with counter
- **❤️ Health System** - Player health with damage feedback
- **📊 HUD** - Real-time display of coins and HP
- **🔊 Sound Effects** - Jump, coin collect, and damage sounds
- **✨ Visual Effects** - Jump particles, coin particles, damage flash
- **🏃 Moving Platforms** - Platforms that carry the player between two points
- **🚩 Checkpoint System** - Save respawn point on contact
- **🏁 Finish Flag** - Level completion with coin requirement check
- **☠️ Fall Detection** - Automatic respawn when falling off the level
- **🌄 Parallax Background** - 5-layer scrolling background

### 🖥️ Game Flow
- **🎬 Main Menu** - Platform Hero title screen with Play button
- **💀 Game Over Screen** - Restart and Main Menu buttons on death
- **🏆 Finish Screen** - Congratulations screen showing coins collected

### 📱 Platform Support
- **💻 Windows** - Full PC build
- **🍎 macOS** - Native Mac build
- **📱 Android** - APK with touch controls
- **📱 iOS** - iOS build support

## 🎮 Controls

| Platform | Action | Input |
|----------|--------|-------|
| **PC** | Move Left/Right | `A` `D` or `←` `→` |
| **PC** | Jump | `Space` |
| **PC** | Pause | `Escape` |
| **Mobile** | Move Left | Touch **LEFT** button |
| **Mobile** | Move Right | Touch **RIGHT** button |
| **Mobile** | Jump | Touch **JUMP** button |

**Gameplay Tips:**
- Jump on enemies from above to defeat them
- Avoid touching enemies from the side (you'll take damage!)
- Collect ALL coins before reaching the finish flag
- Checkpoints save your progress — fall safely!
- Moving platforms carry you across gaps

## 🚀 Quick Start

1. Clone the repository
2. Open project in Unity 6.3 LTS or newer
3. Open the `MainMenu` scene
4. Press Play in the Editor

## 📦 Download

Check out the [**Releases**](https://github.com/OzgurBulum/unity-2d-platformer-core/releases) page for:
- 📱 Android APK builds
- 💻 Windows builds
- 🍎 macOS builds
- 📝 Changelogs

**Latest:** [v0.1.4 - Platform Hero](https://github.com/OzgurBulum/unity-2d-platformer-core/releases)

## 🛠️ Technical Details

- **Engine:** Unity 6.3 LTS
- **Language:** C#
- **Physics:** 2D Rigidbody + Collider
- **Input:** Unity Input System (new)
- **UI:** TextMeshPro + Canvas Scaler
- **Audio:** AudioSource + AudioClip
- **Camera:** Cinemachine
- **Platform:** Windows + macOS + Android + iOS

## 🎯 Current Features

### Player Systems
- ✅ Movement (WASD/Arrows + Touch)
- ✅ Variable jump with cut mechanic
- ✅ Ground detection (3-point Raycast)
- ✅ Jump buffer (0.1s)
- ✅ Health system (3 HP)
- ✅ Death and respawn system
- ✅ Damage flash effect (red tint)
- ✅ Invincibility frames after damage
- ✅ Fall detection and respawn

### Enemy Systems
- ✅ Patrol AI (waypoint-based)
- ✅ Stomp detection (top vs side collision)
- ✅ Damage dealing (side collision)
- ✅ Enemy destruction on stomp

### Hazards & Collectibles
- ✅ Trigger-based hazards
- ✅ Coin collection with sound
- ✅ Coin counter display
- ✅ Particle effects on collect

### Level Systems
- ✅ Moving platforms (player carried)
- ✅ Checkpoint system (respawn points)
- ✅ Finish flag with coin requirement
- ✅ Fall detector (auto respawn)

### Audio & Visual Effects
- ✅ Jump sound effect
- ✅ Coin collect sound
- ✅ Damage/hit sound
- ✅ Jump particle effect
- ✅ Coin particle effect
- ✅ Damage flash VFX
- ✅ Parallax background (5 layers)

### UI/UX & Game Flow
- ✅ Main menu (Platform Hero)
- ✅ Game Over screen (Restart / Main Menu)
- ✅ Finish screen (Congratulations + coin count)
- ✅ Coin counter display
- ✅ HP display
- ✅ Pause menu
- ✅ Warning message (collect all coins)
- ✅ Mobile touch buttons (platform-aware)

### Mobile Features
- ✅ Android build support
- ✅ iOS build support
- ✅ Touch controls (LEFT, RIGHT, JUMP)
- ✅ Platform detection (buttons hidden on PC/Mac)
- ✅ Canvas Scaler (responsive UI)
- ✅ Landscape orientation locked
- ✅ Real device testing completed

## 📅 Development Timeline

| Date | Milestone |
|------|-----------|
| Feb 21, 2026 | Player movement and jump system |
| Feb 27, 2026 | Variable jump and fall multiplier |
| Mar 3, 2026 | Pause menu, Input System, WASD support |
| Mar 6-8, 2026 | Enemy patrol, stomp, hazards, coins, HUD |
| Mar 15-20, 2026 | Event-driven UI, Object pooling |
| Apr 1-5, 2026 | Sound effects and particle VFX |
| Apr 20-22, 2026 | Mobile checkpoint - Android build + touch controls |
| **Apr 27, 2026** | **v0.1.4 - Platform Hero - Full game flow, moving platforms, checkpoints, parallax** |

## 🐛 Bug Fixes

- ✅ Fixed double jump issue with jump buffer system
- ✅ Improved ground detection with 3-point Raycast
- ✅ Fixed UI anchor positioning for responsive layout
- ✅ Fixed enemy patrol child/parent transform issues
- ✅ Fixed Input System compatibility with Android builds
- ✅ Fixed invincibility frames (no instant death from enemies)
- ✅ Fixed coin counter reset on restart
- ✅ Fixed mobile controls hidden on PC/Mac builds
- ✅ Fixed jump reliability with simultaneous key inputs

## ✅ Completed Features

**Core Mechanics:**
- [x] Player movement & controls (keyboard + touch)
- [x] Variable jump mechanics with jump cut
- [x] Jump buffer system
- [x] Ground detection (3-point)
- [x] Pause system

**Gameplay:**
- [x] Enemy AI (patrol & stomp)
- [x] Collectibles system (coins)
- [x] Health system
- [x] Hazards
- [x] HUD/UI (event-driven)
- [x] Moving platforms
- [x] Checkpoint system
- [x] Finish flag with coin requirement
- [x] Fall detection

**Game Flow:**
- [x] Main menu screen
- [x] Game over screen
- [x] Level completion screen
- [x] Scene management

**Polish:**
- [x] Sound effects (jump, coin, hit)
- [x] Particle effects (VFX)
- [x] Damage feedback (flash + invincibility)
- [x] Parallax background (5 layers)
- [x] Level design

**Mobile:**
- [x] Android build support
- [x] iOS build support
- [x] Touch controls
- [x] Platform detection
- [x] Responsive UI
- [x] Real device testing

## 🔮 Future Improvements

- [x] Main menu system ✅
- [x] Game over/restart flow ✅
- [x] Multiple scenes (MainMenu + Game) ✅
- [ ] Character sprite animation
- [ ] More levels
- [ ] Power-up system
- [ ] Save/load system
- [ ] Advanced enemy AI (chase, attack patterns)
- [ ] Background music
- [ ] Leaderboard / high score system

## 📝 License

This project is open source and available under the MIT License.

## 🔗 Links

- **Repository:** [github.com/OzgurBulum/unity-2d-platformer-core](https://github.com/OzgurBulum/unity-2d-platformer-core)
- **Releases:** [Latest builds](https://github.com/OzgurBulum/unity-2d-platformer-core/releases)

---

**Made with ❤️ using Unity**
