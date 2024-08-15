using Godot;
using System;

public partial class ChangeSprite : Sprite2D
{


	//[Export]
	public Texture2D newTexture;
	// Called when the node enters the scene tree for the first time.

	public override void _Ready()
	{
		this.Texture = GD.Load<Texture2D>("res://icon.svg");
		this.Centered = false;
		this.Offset = new Vector2(0, 0);
		this.FlipH = false;
		this.FlipV = false;
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
