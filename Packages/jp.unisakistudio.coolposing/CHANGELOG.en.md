# Changelog

## [1.2.0] - Unreleased

### Added

- Added thirty-language display for the Inspector, editing actions, installation dialogs, standard pose names and generated VRChat menus.
- Unified language selection for the Inspector and in-game menu. The default follows the computer's language, and the last choice is reused in other projects belonging to the same OS user.
- README, changelog and offline manuals can be opened in the selected language.
- Prepared display names for all 128 standard poses and feature descriptions using the established terminology.

### Compatibility

- Existing avatar settings, custom names, asset references, parameter identifiers and license storage are preserved.

## [1.1.0] - 2026-11-07

- 43 of the 50 included poses use IK to fit limbs to the avatar's body. The other 7 use existing per-pose adjustments.
- Photo Mode adjusts avatar position and rotation, with optional synchronization and visibility of your own head during photography.
- Floor Height moves the whole body up/down by 3m, separately from Foot Height.
- Added breathing motion, suppression of default idle sway and reduction of neck-orientation pose distortion.
- The Inspector shows enabled features and parameter usage. Added pose search, batch addition, reordering and quick Scene previews.
- Sped up standing/crouching/sitting switching in desktop mode.
- Improved stale-prebuild warnings, Inspector scrolling overhead and long stalls during generated-data cleanup.
- Added support for Unisaki Posing System 3.1.0.
- No roll-over motions are included with the supplied poses.

## [1.1.0-beta.2] - Open beta (2026-11-05)

- Configured automatic limb adjustment (IK) for 43 of the 50 included poses. The other 7 use existing per-pose adjustments.
- Added support for shared package 3.1.0-beta.2. The poses supplied in this version do not include roll-over motions.

## [1.1.0-beta.1] - Open beta (2026-11-04)

- Added support for Unisaki Posing System 3.1.0-beta.1.
- Changed normal desktop posture switching to a single-evaluation approach for regular builds and prebuilds; VR and special conditions retain existing paths.
- Prebuilds from alpha.3 or earlier are recognized as needing an update.
- Preserved the viewpoint when changing floor height during photography, then restored the latest floor height when photography ends.
- Included improvements through alpha.3 to automatic import, imported-motion adjustments and generated-Controller management.

## [1.1.0-alpha.1] - Before publication

### Added

- Added Roll Over and per-pose animation settings.
- Added dedicated menu icons for Breathing, Roll Over, Floor Height, Photo Mode, Distance, Rotation and Exit Photo Mode.
- Added Photo Mode with forward movement and rotation.
- Added optional Photo Mode synchronization: 0 bit locally, 16 bit synchronized.
- Added an option to keep your avatar's head visible during Photo Mode.
- Added Floor Height to raise the whole body, including the head.
- Added breathing motion, intensity settings and an in-game ON/OFF menu.
- Added suppression of VRChat's default idle sway.
- Added reduction of pose distortion caused by neck-orientation differences.
- Added prevention of backward knee bending and minimum knee angle settings.
- Added per-feature ON/OFF and ExpressionParameters usage display.
- Added quick Scene previews, pose search, batch addition and destination-order selection.
- Added changelogs in the Inspector.

### Changed

- Organized the Inspector into Features, Poses and Avatar Setup tabs.
- Reorganized breathing details, custom-motion imports and presets.
- Reduced duplicated animations generated for foot-height adjustment.
- Added confirmation for pose-image updates and grouped warning settings under Check settings.
- Removed the new-installation 8bit menu in favor of feature selection on regular Prefabs, preserving existing references.
- Added Unisaki Posing System 3.1.0-alpha.1 support and raised the minimum VRChat Avatars SDK version to 3.10.4.

### Fixed

- Fixed pose-name input moving to another pose and details closing during reordering.
- Fixed overlapping/displaced previews and errors on some avatars.
- Fixed warning/prebuild status updates after settings changes and some build errors.

## [1.0.0] - 2026-09-06

- Official release.
- Added avatar presets (トネール, 狛乃, 士堂, 真央).

## [1.0.0-alpha.1] - 2026-09-06

- Release.

🌐 [日本語 · English · Français · Italiano · 简体中文 · 繁體中文 · 한국어 · ไทย · Deutsch · Español · Português · Português (Brasil) · Русский · Українська · Polski · Nederlands · Svenska · Dansk · Suomi · Norsk · Čeština · Türkçe · Bahasa Indonesia · Tiếng Việt · हिन्दी · বাংলা · தமிழ் · తెలుగు · العربية · עברית](Documentation~/Localization/index.md)
