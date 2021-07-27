# HospitalVR

Hospital model: https://assetstore.unity.com/packages/3d/environments/hospital-medical-office-modular-165327

Outline shader: https://roystan.net/articles/outline-shader.html

## Switch to VR mode:
- In OculusSampleFrameworkUtil.cs, uncomment [InitializeOnLoadAttribute].
- In First Person Player game object inspector, uncheck "Player Movement" script and check "OVR Player Controller" script.
- Inside First Person Player game object, uncheck Camera and check OVRCameraRig, InputManager, and UIHelpers.

## Switch to editor mode:
- In OculusSampleFrameworkUtil.cs, comment out [InitializeOnLoadAttribute].
- In First Person Player game object inspector, uncheck "OVR Player Controller" script and check "Player Movement" script.
- Inside First Person Player game object, uncheck OVRCameraRig, InputManager, and UIHelpers and check Camera.

## Turn outline shader on / off:
Go to assets → OutlineShader → OutlinePostProfile and check/uncheck Post Process Outline

