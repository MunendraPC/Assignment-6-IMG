using Godot;
using System;

public partial class Player : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;
	private int _apples = 0;
	private AnimatedSprite2D _anim;

	public override void _Ready()
	{
		// Make sure your AnimatedSprite2D is a direct child (or change the path).
		_anim = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}
		public void AddApple(int amount)
		{
			_apples += amount;
			GD.Print($"+{amount} apple! Total: {_apples}");
			// TODO: update UI, score, etc.
		}
	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Gravity
		if (!IsOnFloor())
			velocity += GetGravity() * (float)delta;

		// Jump
		if (Input.IsActionJustPressed("ui_accept") && IsOnFloor())
		{
			velocity.Y = JumpVelocity;
			_anim?.Play("Jump"); // optional: play jump as soon as you leave the ground
		}

		// Horizontal movement
		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		if (direction != Vector2.Zero)
			velocity.X = direction.X * Speed;
		else
			velocity.X = Mathf.MoveToward(velocity.X, 0, Speed);

		Velocity = velocity;
		MoveAndSlide();

		// Flip sprite when moving left/right
		if (velocity.X != 0)
			_anim.FlipH = velocity.X < 0;

		// --- Animation state ---
		if (!IsOnFloor())
		{
			_anim.Play("Jump");                  // in air
		}
		else if (Mathf.Abs(velocity.X) > 1f)
		{
			_anim.Play("Running");               // moving on the ground
		}
		else
		{
			// If you have an Idle animation, use it; otherwise you can stop on frame 0
			_anim.Play("Idle");                  // <- change/remove if you don't have Idle
			// If no Idle animation, do this instead:
			// _anim.Stop();
			// _anim.Frame = 0;
		}
	}
}
