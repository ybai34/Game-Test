using Godot;
using System;

public partial class InputTest : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(Input.IsActionJustPressed("ui_left"))
		{
			GD.Print("左が押された");
			Node root = this.GetTree().CurrentScene;

			Node test = root.FindChild("Test");

			test.QueueFree();
		}
	}
}
