// Area2d.cs
using Godot;

public partial class Apple : Area2D
{
	[Export] public int Value = 1;
	[Export] public AudioStreamPlayer2D PickupSfx; // optional

	public override void _Ready()
	{
		BodyEntered += OnBodyEntered;   // body_entered signal
	}

	private async void OnBodyEntered(Node body)
	{
		if (!body.IsInGroup("player"))
			return;

		if (body is Player p)
			p.AddApple(Value);

		if (PickupSfx != null)
		{
			PickupSfx.Play();
			Hide();
			SetDeferred("monitoring", false);
			await ToSignal(PickupSfx, "finished");
		}

		QueueFree();
	}
}
