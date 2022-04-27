# godot-character-controller-c-
a godot character controller in c# with camera follow, and rotation based on direction facing

example node setup

level(spatial)
    player(scene)
    floor(rigidBody)
    
    
  player scene
  
  player(spatial)
      controller(kinematicBody)(player.cs)
      collisionShape
      MeshInstance
      cam_follow(spatial)
    cam(InterpolatedCamera)
    
    
   cam_follow is the point at which the interpolated camera will follow. set it above and behind the player and rotate it downwards
   
   in cam, set enabled to on and the target to cam_follow, adjust the speed to your liking
