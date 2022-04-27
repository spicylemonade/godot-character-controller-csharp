# godot-character-controller-c-
a godot character controller in c# with camera follow, and rotation based on direction facing

example node setup

level(spatial)<br/>
    player(scene)<br/>
    floor(rigidBody)<br/>
    
  ![alt text](https://github.com/spicylemonade/godot-character-controller-c-/blob/main/unknown.png)

  player scene
  
  player(spatial)<br/>
      controller(kinematicBody)(player.cs)<br/>
      collisionShape<br/>
      MeshInstance<br/>
      cam_follow(spatial)<br/>
    cam(InterpolatedCamera)<br/>
    
   ![alt text](https://github.com/spicylemonade/godot-character-controller-c-/blob/main/DeepinScreenshot_select-area_20220427011739.png)

   cam_follow is the point at which the interpolated camera will follow. set it above and behind the player and rotate it downwards
   
   in cam, set enabled to on and the target to cam_follow, adjust the speed to your liking





https://user-images.githubusercontent.com/84095175/165445931-0827bfa0-8acc-4180-9b1a-e92e67cbff93.mp4

