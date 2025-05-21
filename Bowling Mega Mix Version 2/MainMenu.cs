using Godot;
using System;

public partial class MainMenu : Control
{
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void TenPin()
{
	GetTree().ChangeSceneToFile("res://10PinLane.tscn");
}


public void DuckPin()
{
	GetTree().ChangeSceneToFile("res://DuckPinLane.tscn");
}


public void CandlePin()
{
	GetTree().ChangeSceneToFile("res://CandlePinLane.tscn");
}


public void FivePin()
{
	GetTree().ChangeSceneToFile("res://5PinLane.tscn");
}


public void TexasNinePin()
{
	GetTree().ChangeSceneToFile("res://Texas9PinLane.tscn");
}


public void HolyRomanNinePin()
{
	GetTree().ChangeSceneToFile("res://HolyRoman9PinLane.tscn");
}

public void Mod()
{
	GetTree().ChangeSceneToFile("res://Bowling Mega Mix Mod/ModScene.tscn");
}

public void Exit()
{
	GetTree().Quit();
}
}
