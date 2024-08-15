using Godot;
using System;
using System.Threading;

public partial class MySprite : Sprite2D
{
	float timer = 5;

    public override void _EnterTree()
    {
        base._EnterTree();
		GD.Print("Entered Tree");
    }


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
		GD.Print("Ready");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		timer -= (float)delta;
		//GD.Print("Process");
		if (timer <= 0)
		{
			timer = 100;
			this.QueueFree();
		}
	}

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
    }

    public override void _ExitTree()
    {
        base._ExitTree();
		GD.Print("Exited Tree");
    }

}
