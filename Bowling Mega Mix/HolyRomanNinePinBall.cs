using Godot;
using System;
using System.Threading;

public partial class HolyRomanNinePinBall : RigidBody3D
{
	
	// mouse values
	//float dblMousePosition = 0;
	//float dblMousePositionBuffer = 0;
	
	// The amount of frames and frame turns there are and the players placemet on those turns and frames
	// Amount of frame turns there are
	int intFrameTurns = 1;
	// The frame turn the player is on
	int intFrameTurnsOn = 0;
	// Amount of frames there are
	int intFrames = 24;
	// The frame the player is on
	int intFrameOn = 1;
	
	// Lock to frevent player moving ball left and right after ball is launched
	float dblMoveLock = 0;
	
	private Vector3 originalPosition;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// what happens when player presses a key
		// Prevents movement of ball when launched
		if (dblMoveLock != 1){
			if (Input.IsActionPressed("MoveLeft")){
			// ball movement to left
			GlobalPosition += new Vector3(-0.10F,0,0);
		}
		}
		// what happens when player presses d key
		// Prevents movement of ball when launched
		if (dblMoveLock != 1){
			if (Input.IsActionPressed("MoveRight")){
			// ball movement to right
			GlobalPosition += new Vector3(0.10F,0,0);
		}
		}
		
		// what happens when player presses space key or left mouse button
		if (Input.IsActionPressed("Launch")){
			// launch ball
			originalPosition = this.Position;
			this.ApplyCentralImpulse(new Vector3(0, 0, -1F));
			// locks ball movement after launching
			dblMoveLock = 1;
			// sets position for player frame turn
			intFrameTurnsOn = intFrameTurnsOn + 1;
		}
		
		// respawn code
		float distanceTravelled = this.Position.DistanceTo(this.originalPosition);
		if (distanceTravelled > 9){
			// resets turn lock
			dblMoveLock = 0;
			// turn check
			if (intFrameTurns != intFrameTurnsOn){
				// respawns ball
				GlobalPosition = new Vector3 (0.012F, 0.139F, 0.666F);
			}
			if (intFrameTurns == intFrameTurnsOn){
				// respawns pins and ball
				GetTree().ReloadCurrentScene();
				// resets frame turn for next frame
				intFrameTurnsOn = 0;
				
				intFrameOn = intFrameOn + 1;
				
				if (intFrameOn > intFrames) {
					GetTree().ChangeSceneToFile("res://MainMenu.tscn");
				}
			}
		}
	}
	
	// commented out due to engine bug
	// controlling ball position with mouse function
	//public override void _Input(InputEvent @event)
	//{
		//if (@event is InputEventMouseMotion eventMouseMotion)
		//{
			//dblMousePositionBuffer = eventMouseMotion.Position.X;
			//if (eventMouseMotion.Position.X > dblMousePosition) {
				//dblMousePosition = dblMousePositionBuffer;
				//GlobalPosition = new Vector3(dblMousePosition/5000,0,0);
			//}
			//else if (eventMouseMotion.Position.X < dblMousePosition) {
				//dblMousePosition = dblMousePositionBuffer;
				//GlobalPosition = new Vector3(dblMousePosition/5000,0,0);
			//}
		//}	
	//}
}
