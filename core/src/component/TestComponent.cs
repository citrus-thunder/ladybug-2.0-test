using System;

using Ladybug;
using Ladybug.Entities;

using Microsoft.Xna.Framework;

public class TestComponent : Component
{
	private int _counter = 0;
	private int _counterMax = 10;
	public TestComponent()
	{
		OnInitialize(()=>{Console.WriteLine("Test Component Initialized!");});
		OnUpdateStep("Update", Update);
	}

	private void Update(GameTime gameTime)
	{
		if (_counter >= _counterMax)
		{
			Game.Exit();
		}

		Console.WriteLine($"Update Step {_counter}");
		_counter++;
	}
}