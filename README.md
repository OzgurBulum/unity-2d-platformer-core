# 🎮 Unity 2D Platformer Core

A 2D platformer game built with Unity, featuring movement mechanics, jump systems, enemy interactions, collectibles, sound effects, and mobile support.

![Unity](https://img.shields.io/badge/Unity-6.3_LTS-black?logo=unity)
![Platform](https://img.shields.io/badge/Platform-PC%20%7C%20Android-blue)
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

### 📱 Mobile Support
- **📱 Android Build** - APK generated and tested
- **🎮 Touch Controls** - On-screen buttons (LEFT, RIGHT, JUMP)
- **🔍 Platform Detection** - Buttons visible on mobile only
- **📐 Responsive UI** - Canvas Scaler with landscape orientation

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
- Collect coins scattered throughout the level
- Variable jump: Hold jump button longer for higher jumps

## 🚀 Quick Start

1. Clone the repository
2. Open project in Unity 6.3 LTS or newer
3. Press Play in the Editor

## 📦 Download

Check out the [**Releases**](https://github.com/OzgurBulum/unity-2d-platformer-core/releases) page for:
- 📱 Android APK builds
- 💻 Playable builds (macOS)
- 📝 Changelogs

**Latest:** [v0.1.3 - Mobile Checkpoint](https://github.com/OzgurBulum/unity-2d-platformer-core/releases)

## 🛠️ Technical Details

- **Engine:** Unity 6.3 LTS
- **Language:** C#
- **Physics:** 2D Rigidbody + Collider
- **Input:** Unity Input System (new)
- **UI:** TextMeshPro + Canvas Scaler
- **Audio:** AudioSource + AudioClip
- **Platform:** PC (macOS/Windows) + Android

## 🎯 Current Prototype Features

### Player Systems
- ✅ Movement (WASD/Arrows + Touch)
- ✅ Variable jump with cut mechanic
- ✅ Ground detection (Raycast)
- ✅ Jump buffer (0.1s)
- ✅ Health system (3 HP)
- ✅ Death on HP = 0
- ✅ Damage flash effect (red tint)

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

### Audio & Visual Effects
- ✅ Jump sound effect
- ✅ Coin collect sound
- ✅ Damage/hit sound
- ✅ Jump particle effect
- ✅ Coin particle effect
- ✅ Damage flash VFX

### UI/UX
- ✅ Coin counter display
- ✅ HP display
- ✅ Pause menu
- ✅ Real-time HUD updates
- ✅ Mobile touch buttons (platform-aware)

### Mobile Features
- ✅ Android build support
- ✅ Touch controls (LEFT, RIGHT, JUMP)
- ✅ Platform detection (buttons hidden on PC)
- ✅ Canvas Scaler (responsive UI)
- ✅ Landscape orientation locked

## 📅 Development Timeline

| Date | Milestone |
|------|-----------|
| Feb 21, 2026 | Player movement and jump system |
| Feb 27, 2026 | Variable jump and fall multiplier |
| Mar 3, 2026 | Pause menu, Input System, WASD support |
| Mar 6-8, 2026 | Enemy patrol, stomp, hazards, coins, HUD |
| Mar 15-20, 2026 | Event-driven UI, Object pooling |
| Apr 1-5, 2026 | Sound effects and particle VFX |
| **Apr 20, 2026** | **Mobile checkpoint - Android build + touch controls** |

## 🐛 Bug Fixes

- ✅ Fixed double jump issue with jump buffer system (0.1s)
- ✅ Improved ground detection with Raycast
- ✅ Fixed UI anchor positioning for responsive layout
- ✅ Fixed enemy patrol child/parent transform issues
- ✅ Fixed Input System compatibility with Android builds

## ✅ Completed Features

**Core Mechanics:**
- [x] Player movement & controls (keyboard + touch)
- [x] Variable jump mechanics with jump cut
- [x] Jump buffer system
- [x] Ground detection
- [x] Pause system

**Gameplay:**
- [x] Enemy AI (patrol & stomp)
- [x] Collectibles system (coins)
- [x] Health system
- [x] Hazards
- [x] HUD/UI (event-driven)

**Polish:**
- [x] Sound effects (jump, coin, hit)
- [x] Particle effects (VFX)
- [x] Damage feedback (flash effect)
- [x] Basic level design

**Mobile:**
- [x] Android build support
- [x] Touch controls
- [x] Platform detection
- [x] Responsive UI

## 🔮 Future Improvements

_This project focused on core 2D platformer mechanics as a learning exercise. The following features could be added in future iterations but are currently out of scope:_

- [ ] Character sprite animation (currently uses sprite flipping only)
- [ ] Multiple levels/scenes
- [ ] Power-up system
- [ ] Advanced level design with complex layouts
- [ ] Main menu system
- [ ] Game over/restart flow

## 📱 Mobile Checkpoint

**Android Build - April 2026**

**✅ Completed:**
- Android Build Support configured (Unity Hub)
- APK generated (`com.freedxdev.platformer`)
- Touch controls implemented (LEFT, RIGHT, JUMP buttons)
- Canvas Scaler configured (Scale With Screen Size, 1920x1080)
- Landscape orientation locked
- Platform detection (buttons visible on mobile only, hidden on PC)
- Input System integration (keyboard + touch working simultaneously)
- Pause/Resume tested
- Profiler snapshot analyzed (CPU/Memory stable)

**⚠️ Limitations:**
- Real device test not completed yet (no Android device available)
- Tested in Unity Editor with platform detection

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