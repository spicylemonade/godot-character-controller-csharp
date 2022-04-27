using Godot;
using System;

public class player : KinematicBody
{
	// Declare member variables here. Examples:
	// private string b = "text";
	[Export] public float velocity = 0.5f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}
  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
	if (Input.IsActionPressed("Up")){
		//AddCentralForce(new Vector3(-velocity,0,-velocity)*GetTransform().basis.z);
		this.Translation += new Vector3(-velocity,0,-velocity)*Transform.basis.z;
	}	
	if (Input.IsActionPressed("Down")){
		//AddCentralForce(new Vector3(-velocity,0,velocity)*GetTransform().basis.z);
		this.Translation += new Vector3(-velocity,0,velocity)*Transform.basis.z;
	}
	 if (Input.IsActionPressed("Left")){
		//AddCentralForce(new Vector3(-velocity,0,0));
		this.Rotation += new Vector3(0,0.05f,0);
	}
	 if (Input.IsActionPressed("Right")){
		//AddCentralForce(new Vector3(velocity,0,0));
		this.Rotation += new Vector3(0,-0.05f,0);
	}
	//AddCentralForce(new Vector3(0,0,-up_velocity));
	  
  }
	//basis is used to push the player in a direction relative to its rotation
  //left right to rotate
}

