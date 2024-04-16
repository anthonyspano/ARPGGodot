using Godot;
using System;

public class PlayerController : KinematicBody2D
{
	// Declare member variables here. Examples:
	private float xspeed = 100;
	private float yspeed = 75;
	

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	public override void _Input(InputEvent @event)
	{
		if(@event.IsActionPressed("move-right"))
		{
			GD.Print("moving!");

		}
	}
//	public void _PhysicsProcess(double delta)
//	{
//		if(Input.IsActionPressed("move_right"))
//		{
//			position.X += speed * (float)delta;
//		}
//	}
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
	Vector2 velocity = new Vector2();
	if(Input.IsActionPressed("move-right"))
		velocity.x += xspeed;			
	if(Input.IsActionPressed("move-left"))
		velocity.x -= xspeed;
	if(Input.IsActionPressed("move-up"))
		velocity.y -= yspeed;		
	if(Input.IsActionPressed("move-down"))
		velocity.y += yspeed;
		
//	velocity.x *= delta;
//	velocity.y *= delta;
	MoveAndSlide(velocity, Vector2.Up);
  }
}
