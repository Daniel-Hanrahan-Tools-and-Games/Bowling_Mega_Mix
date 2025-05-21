using Godot;
using Godot.Collections;
using System;

public partial class ScoreLayer : CanvasLayer
{
	public Label Score;
	public int intScore = 0;
	float dblRandomNumber = GD.Randf();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Score = GetNode<Label>("Score");
		
		Array<Node> Pins = GetTree().GetNodesInGroup("Pins");
		
		// neccessary loop to call functions for 10 pin, DuckPin, CandlePin, Holy Roman Nine Pin
		for(int i = 0; i < Pins.Count; i++){
			Collision n = (Collision)Pins[i];
			n.PinCollided += () => AddScore();
		}
		
		// neccessary loop to call functions for Texas Nine Pin
		for(int i = 0; i < Pins.Count; i++){
			Collision n = (Collision)Pins[i];
			n.PinCollidedTexasNinePin += () => AddScoreTexasNinePin();
		}
		
		// neccessary loop to call functions for 5 Pin Five Point Pin
		for(int i = 0; i < Pins.Count; i++){
			Collision n = (Collision)Pins[i];
			n.PinCollidedFivePinFivePin += () => AddScoreFivePinFivePin();
		}
		
		// neccessary loop to call functions for 5 Pin Three Point Pins
		for(int i = 0; i < Pins.Count; i++){
			Collision n = (Collision)Pins[i];
			n.PinCollidedFivePinThreePins += () => AddScoreFivePinThreePins();
		}
		
		// neccessary loop to call functions for 5 Pin Two Point Pins
		for(int i = 0; i < Pins.Count; i++){
			Collision n = (Collision)Pins[i];
			n.PinCollidedFivePinTwoPins += () => AddScoreFivePinTwoPins();
		}
	}
	// Score function for 10 Pin, CandlePin, DuckPin and Holy Roman Nine Pin
	public void AddScore(){
		// comprimise for not having strikes or spares
		// 20% chance of getting a strike/spare score
		// strike/spare score
		if (dblRandomNumber > 0.80f) {
			// adds to current score
			intScore = intScore + 3;
		}
		// regular score
		else {
			// adds to current score
			intScore = intScore + 1;
		}
		// writes score to scoreLabel
		Score.Text = "Score: " + intScore.ToString();
	}
	
	public void AddScoreTexasNinePin(){
		// comprimise for not having all pins down or ringers
		// 4% chance of getting a all pins down score
		if (dblRandomNumber > 0.96f) {
			// adds to current score
			intScore = intScore + 1;
		}
		// 1% chance  of getting a all pins down except red pin score
		else if (dblRandomNumber < 0.1f) {
			// adds to current score
			intScore = intScore + 2;
		}
		// writes score to scoreLabel
		Score.Text = "Score: " + intScore.ToString();
	}
	
	public void AddScoreFivePinFivePin(){
		// comprimise for not having strikes or spares
		// 20% chance of getting a strike/spare score
		// strike/spare score
		if (dblRandomNumber > 0.80f) {
			// adds to current score
			intScore = intScore + 7;
		}
		// regular score
		else {
			// adds to current score
			intScore = intScore + 5;
		}
		// writes score to scoreLabel
		Score.Text = "Score: " + intScore.ToString();
	}
	
	public void AddScoreFivePinThreePins(){
		// comprimise for not having strikes or spares
		// 20% chance of getting a strike/spare score
		// strike/spare score
		if (dblRandomNumber > 0.80f) {
			// adds to current score
			intScore = intScore + 5;
		}
		// regular score
		else {
			// adds to current score
			intScore = intScore + 3;
		}
		// writes score to scoreLabel
		Score.Text = "Score: " + intScore.ToString();
	}
	
	public void AddScoreFivePinTwoPins(){
		// comprimise for not having strikes or spares
		// 20% chance of getting a strike/spare score
		// strike/spare score
		if (dblRandomNumber > 0.80f) {
			// adds to current score
			intScore = intScore + 4;
		}
		// regular score
		else {
			// adds to current score
			intScore = intScore + 2;
		}
		// writes score to scoreLabel
		Score.Text = "Score: " + intScore.ToString();
	}
}
