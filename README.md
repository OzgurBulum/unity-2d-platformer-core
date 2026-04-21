# 🎮 Unity 2D Platformer Core

A 2D platformer game built with Unity, featuring movement mechanics, jump systems, enemy interactions, collectibles, and HUD.

![Unity](https://img.shields.io/badge/Unity-6.3_LTS-black?logo=unity)
![Platform](https://img.shields.io/badge/Platform-macOS%20%7C%20Windows%20%7C%20Android-blue)
![License](https://img.shields.io/badge/License-MIT-green)

## ✨ Features

### 🎮 Core Mechanics
- **🏃 Player Movement** - Smooth WASD and arrow key controls with air control
- **⬆️ Jump Mechanics** - Variable jump height based on button hold duration
- **⏸️ Pause System** - Full pause menu with resume, restart, and quit options
- **🎮 Input System** - Modern Unity Input System integration
- **🔧 Physics-Based** - Rigidbody2D with custom gravity multipliers

### 🎯 Week 5 Update (Enemy & Hazards)
- **👾 Enemy Patrol** - Enemies patrol between waypoints
- **💥 Stomp Mechanic** - Jump on enemies to defeat them (Mario-style!)
- **⚠️ Hazards** - Damage-dealing obstacles
- **🪙 Collectibles** - Coin system with counter
- **❤️ Health System** - Player health with damage feedback
- **📊 HUD** - Real-time display of coins and HP

## 🎮 Controls

| Action | Keys |
|--------|------|
| Move | `A` `D` or `←` `→` |
| Jump | `Space` |
| Pause | `Escape` |

**Gameplay Tips:**
- Jump on enemies from above to defeat them
- Avoid touching enemies from the side (you'll take damage!)
- Collect coins scattered throughout the level
- Watch your HP - it's displayed in the top-left corner

## 🚀 Quick Start

1. Clone the repository
2. Open project in Unity 6.3 LTS or newer
3. Press Play in the Editor

## 📦 Download

Check out the [**Releases**](https://github.com/OzgurBulum/unity-2d-platformer-core/releases) page for:
- 🎥 Gameplay videos
- 💻 Playable builds (macOS)
- 📝 Changelogs

**Latest:** [v0.1.1 - Week 5 Prototype](https://github.com/OzgurBulum/unity-2d-platformer-core/releases)

## 🛠️ Technical Details

- **Engine:** Unity 6.3 LTS
- **Language:** C#
- **Physics:** 2D Rigidbody + Collider
- **Input:** Unity Input System
- **UI:** TextMeshPro
- **Platform:** PC (macOS/Windows) + Android

## 🎯 Current Prototype Features

### Player Systems
- ✅ Movement (WASD/Arrows)
- ✅ Variable jump
- ✅ Ground detection (Raycast)
- ✅ Jump buffer (0.1s)
- ✅ Health system (3 HP)
- ✅ Death on HP = 0

### Enemy Systems
- ✅ Patrol AI (waypoint-based)
- ✅ Stomp detection (top vs side collision)
- ✅ Damage dealing (side collision)
- ✅ Enemy destruction on stomp

### Hazards & Collectibles
- ✅ Trigger-based hazards
- ✅ Coin collection
- ✅ Static coin counter

### UI/UX
- ✅ Coin counter display
- ✅ HP display
- ✅ Pause menu
- ✅ Real-time HUD updates

## 📅 Development Timeline

| Date | Milestone |
|------|-----------|
| Feb 21, 2026 | Player movement and jump system |
| Feb 27, 2026 | Variable jump and fall multiplier |
| Mar 3, 2026 | Pause menu, Input System, WASD support |
| Mar 6-8, 2026 | Enemy patrol, stomp, hazards, coins, HUD |
| **Apr 20, 2026** | **Mobile checkpoint - Android build + touch controls** |

## 🐛 Bug Fixes

- ✅ Fixed double jump issue with jump buffer system (0.1s)
- ✅ Improved ground detection with Raycast
- ✅ Fixed UI anchor positioning for responsive layout
- ✅ Fixed enemy patrol child/parent transform issues

## 🔮 Roadmap

- [x] Enemy AI
- [x] Collectibles system
- [x] Mobile checkpoint (Android)
- [ ] Animation system
- [ ] Sound effects
- [ ] Level design
- [ ] Multiple levels
- [ ] Power-ups

## 📱 Mobile Checkpoint

**Android Build - April 2026**

- ✅ Android Build Support configured (Unity Hub)
- ✅ APK generated (`com.freedxdev.platformer`)
- ✅ Touch controls implemented (LEFT, RIGHT, JUMP buttons)
- ✅ Canvas Scaler configured (Scale With Screen Size, 1920x1080)
- ✅ Landscape orientation locked
- ✅ Platform detection (buttons visible on mobile only, hidden on PC)
- ✅ Input System integration (keyboard + touch working simultaneously)
- ✅ Pause/Resume tested
- ✅ Profiler snapshot analyzed (CPU/Memory stable)
- ⚠️ Real device test not completed yet (no Android device available)

**Mobile Controls:**
- Touch LEFT button → Move left
- Touch RIGHT button → Move right  
- Touch JUMP button → Jump (variable height based on hold duration)
- PC keyboard controls remain functional for testing

**Technical Implementation:**
- `MobileInputHandler.cs` - Touch input handling (IPointerDown/IPointerUp)
- `PlatformDetection.cs` - Runtime platform detection
- `PlayerMovement.cs` - Unified input system (keyboard + touch)
- Mobile buttons scale with screen size (1920x1080 reference)

## 📝 License

This project is open source and available under the MIT License.

## 🔗 Links

- **Repository:** [github.com/OzgurBulum/unity-2d-platformer-core](https://github.com/OzgurBulum/unity-2d-platformer-core)
- **Releases:** [Latest builds](https://github.com/OzgurBulum/unity-2d-platformer-core/releases)

---

**Made with ❤️ using Unity**