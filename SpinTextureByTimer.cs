using Godot;
using System;

public partial class SpinTextureByTimer : Sprite2D
{
	// Called when the node enters the scene tree for the first time.

	double timer = 0;




	public override void _Ready()
	{
		this.Hframes = 2;
		this.Vframes = 2;
		this.Frame = 0;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		timer += delta;
		if(timer > 1)
		{
			timer = 0;
			int index = this.Frame + 1;
			if(index > 3)
			{
				index = 0;
			}
			this.Frame = index;
		}
	}
}
