# Cool Posing Tool

A VRChat pose-locking tool for cool postures with three-point tracking or desktop mode. Includes 50 poses: 11 standing, 9 crouching, 14 sitting, 9 back-lying and 7 front-lying.

This README covers v1.2.0, currently in development. A release date has not been set. Check the installed version at the top of the Inspector.

- [BOOTH product page](https://yunisaki.booth.pm/items/8797334)
- [Changelog](CHANGELOG.md)

## Display language and offline documentation

Choose a display language with Language / 言語 at the top of the Inspector. One selection controls both the Inspector and generated VRChat menu. Re-upload the avatar to change its in-game language.

Without a saved choice, the tool follows the computer's language and uses English for unsupported languages. This works on Windows, macOS and Linux. The last selection is saved in EditorPrefs and reused in other projects belonging to the same OS user on this computer. An explicit selection already saved on an avatar is preserved. Preferences do not sync to other computers. License storage is unchanged.

Choose a README, changelog or manual from the bundled [language index](../index.html). The Inspector's Manual and View changelog also follow the selected language. Original agreements and reference translations remain separately available.

## Main features

- Automatic limb adjustment (IK): 43 poses adjust limb positions and orientations to fit the avatar's body.

- Photo Mode: move the avatar up to 3m forward and adjust its rotation. Uses 0 bit locally, or 16 bit to show position and rotation to others.
- Head visibility during photography: prevent your nearby avatar's head from disappearing specifically during Photo Mode.
- Floor Height: move the whole body, including the head, up/down by 3m. This is separate from Foot Height, which moves the feet side while preserving head position.
- Roll Over: available for poses where you assign suitable motions yourself. The included poses do not contain roll-over motions.
- Breathing: add breathing motion to the chest and other parts, with None, Weak, Medium, Strong, Rapid and Custom settings for each posture category.
- Disable VRChat idle sway: suppress default idle sway while retaining the tool's breathing and other custom motions.
- Reduce pose distortion from head rotation: reduce distortion when releasing head lock if the neck orientation differs from the original pose.
- Feature selection: include only required in-game menu features and check ExpressionParameters usage in the Inspector.
- Pose search, batch addition and reordering: search across categories, load multiple clips and select destination order.
- Quick Scene previews: use Preview in the pose list to inspect the posture in place.

- Menu icons for new features: dedicated images for Breathing, Roll Over, Floor Height, Photo Mode and related controls match this product's existing icons.

### Configuring Roll Over

Open Details for a lying pose, enable Enable roll over and assign an animation to Sideways roll-over pose. Normal MotionTime settings become unavailable. Also enable Features > Menu features > Roll Over and upload, then select the supported pose and Roll Over in VRChat. Release head lock before use.

The poses included in this version do not contain roll-over motions. Assign suitable animations for the poses you want to use.

## Supported avatar presets and fitting

Includes fitted presets for トネール, 狛乃, 士堂 and 真央.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Other avatars can also be used. Fit poses to body shape and avatar modifications using Animation adjustment. Avatar Setup also provides Prevent reverse knee bending and its detailed Minimum knee bend (degrees) setting.

Automatic limb adjustment (IK) is enabled by default. It is used by 43 of the 50 included poses; the other 7 use the existing per-pose adjustments.

## Installation

1. Download the files from the product page at the store where you purchased it.
2. Import the bundled カッコいいポーズツール.unitypackage into Unity to register the license and package repositories.
3. In VCC or ALCOM, add Cool Posing Tool and Modular Avatar to your Unity project. The shared Unisaki Posing System and NDMF are also installed as dependencies.
4. Right-click the target avatar in the Hierarchy and choose Unisaki Studio > Add Cool Posing.
5. Select the added カッコいいポーズ object inside the avatar and configure the desired features and poses in the Inspector.
6. Upload the avatar normally.

Requires Unity 2022.3, VRChat Avatars SDK 3.10.4 or later, Modular Avatar 1.x version 1.15.1 or later, and NDMF 1.x version 1.14.0 or later. Update the required packages together in VCC or ALCOM.

## Updating from an earlier version

Update this product and Unisaki Posing System together. Existing tool settings are carried over. Check enabled features and ExpressionParameters usage in the Inspector. If you use prebuilds, click Update prebuild before re-uploading.

Since v1.1.0, new installations use the regular カッコいいポーズ Prefab. Turn off unneeded Features for a pose-selection-only minimum of 8 bit. Configurations with many poses may require additional pose-selection bits.

Old 8bit Prefabs remain in Editor/Legacy to preserve existing avatar and preset references. There is no need to delete or replace existing Prefabs. The 8bit edition no longer appears in the Unity menu for new installations.

## Where to configure settings

| Tab | Available settings |
| --- | --- |
| Features | In-game menu features, convenience features, breathing settings, icon images and ExpressionParameters usage |
| Poses | Select poses, edit details, search, batch add, reorder, preview and adjust animations |
| Avatar Setup | Avatar-specific correction, knee correction, original/custom motion imports and preset changes |

Open settings expands detailed controls below that item. Configure breathing under Features > Convenience > Animate breathing.

Use original standing, crouching and prone poses automatically imports the avatar's existing poses. To assign your own motions, use the separate Open import settings control and choose a motion for each type, such as standing, Crouching and Prone.

Presets are at the bottom of Avatar Setup. Apply this preset replaces the current pose settings, so save existing adjustments before switching.

### Per-feature parameter usage

- Breathing motion uses 0 bit. Only Menu features > Breathing, used to stop/resume it in-game, costs 1 bit for synchronized ON/OFF.
- Photo Mode uses 0 bit locally. Convenience > Sync Photo Mode uses 16 bit. Keep your head visible in Photo Mode uses 0 bit.
- Foot Height and Floor Height each use 8 bit. Move Floor Height away from the center to move the whole body vertically; return near 50% to end correction.
- Roll Over alone uses 10 bit. It shares 1 bit with Reduce pose distortion from head rotation, so enabling both still totals 10 bit.
- Mirror and Disable Gestures each use 1 bit.

The Inspector total covers the posing tools on the avatar. It excludes clothing and other gimmicks. Shared settings are counted once even when multiple posing tools are used.

### Previewing and editing poses

Use Preview on a pose under Poses to display it in the Scene. For finer changes, open Animation adjustment, adjust while previewing and save.

Quick previews do not run MA or NDMF build processing. Check clothing and floor-position correction assembled during the build in the built avatar before uploading as well.

Search pose names with the magnifying-glass tab on the left. Choose a destination under Details > Order or use the up/down buttons to reorder poses. Add multiple animations by dragging them to the add area or using Load selected clips from Project.

Update pose thumbnails generates images after a confirmation dialog. Generate pose icons makes in-game poses easier to recognize but adds image-generation time to builds. Select Reduce icon size to lower storage usage. Pose icons are not generated for Android.

## Basic in-game controls

- Select poses in each category through the Expressions menu. In VR, head height switches standing, crouching, sitting and lying postures.
- While lying, face orientation switches back/front lying. With both selected, jumping also switches them; disable this under Features > Convenience > Switch lying posture by jumping. Adjust category-switching heights using the thresholds in Settings.
- On desktop, use C and Z to change posture. If Z does not reach a lying pose, raise the lying-height threshold in Settings.
- Disable Gestures uses the hand shapes assigned to the pose instead of controller finger gestures.
- Foot Height adjusts the feet side while preserving head position. Floor Height moves the whole body, including the head, vertically. They appear in that order in Settings.
- Moving forward with Photo Mode > Distance turns the avatar toward you. Use Direction to turn it and enable Lock Feet when ready. Exit Photo Mode restores distance/rotation and releases foot lock.
- Breathing is available when breathing animation is enabled. Set intensity in Unity and switch it ON/OFF in-game.

## Prebuilds and warnings

Update prebuild reuses generated data to speed up avatar builds. Without a prebuild, the necessary data is generated during a normal build.

After settings changes, Check settings at the top of the Inspector and Hierarchy markers notify you that an update is needed. Warning display settings are inside Check settings. Hiding a warning does not fix configuration issues or refresh generated data.

## Usage notes

- Pose locking during full-body tracking is unsupported.
- Body shape, clothing or avatar modifications may require additional adjustments.
- Special Base layers or other pose-changing gimmicks may not integrate as intended. If locks do not work correctly, also check Avatar Setup > Integrate tracking locks with other tools.
- Photo Mode movement/rotation and Floor Height correct tool poses and default/custom motions used when no tool pose is selected. Check the final viewpoint and behavior after motion replacement in the VRChat client.
- Disable VRChat idle sway targets the default idle animation; it does not stop movement from every other cause.

## Documentation and support

Open the manual, support or changelog through Help / Changelog at the top of the Inspector. For detailed shared-feature explanations, also see Packages > Unisaki Posing System > README in Unity's Project window.

- [Official manual](https://docs.unisakistudio.jp/coolposing/manual/)
- [Support](https://help.unisakistudio.jp/)

For issue reports, include this product and Unisaki Posing System versions; Unity, VRChat SDK, Modular Avatar and NDMF versions; avatar used; reproduction steps; and Console error details.

## Terms of use

This product includes the VN3 terms ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf, which apply commonly to data sold or distributed by Unisaki Studio. Read them before use.

The source code and resources in this repository are not open source. Legitimate purchasers are licensed to use them within the bundled terms of use.
