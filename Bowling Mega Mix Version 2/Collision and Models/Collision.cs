using Godot;
using System;

public partial class Collision : Area3D
{
	// 10,duck,candle,german 9 pin handler
	[Signal]
	public delegate void PinCollidedEventHandler();
	
	// texas 9 pin handeler
	[Signal]
	public delegate void PinCollidedTexasNinePinEventHandler();
	
	// 5 pin 5 point pin handeler
	[Signal]
	public delegate void PinCollidedFivePinFivePinEventHandler();
	
	// 5 pin 3 point pins handeler
	[Signal]
	public delegate void PinCollidedFivePinThreePinsEventHandler();
	
	// 5 pin 2 point pins handeler
	[Signal]
	public delegate void PinCollidedFivePinTwoPinsEventHandler();
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	// 10,candle,duck,german 9 pin collision
	public void CollisionDuckPinCandlePinTenPin(Node3D Ball){
		EmitSignal("PinCollided");
		QueueFree();
	}
	// texas 9 pin collision
	public void CollisionTexasNinePin(Node3D Ball){
		EmitSignal("PinCollidedTexasNinePin");
		QueueFree();
	}
	// 5 pin 5 point pin collision
	public void CollisionFivePinFivePin(Node3D Ball){
		EmitSignal("PinCollidedFivePinFivePin");
		QueueFree();
	}
	// 5 pin 3 point pins collision
	public void CollisionFivePinThreePins(Node3D Ball){
		EmitSignal("PinCollidedFivePinThreePins");
		QueueFree();
	}
	// 5 pin 2 point pins collision
	public void CollisionFivePinTwoPins(Node3D Ball){
		EmitSignal("PinCollidedFivePinTwoPins");
		QueueFree();
	}
}
