using System;

using Ladybug;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Ladybug.ECS;
using Ladybug.ECS.Components;

public class TestComponentSystem : ComponentSystem<TestComponent> { }

public class TestComponent : Component
{
	private int _counter = 0;
	private int _counterMax = 10;

	protected override void Initialize()
	{
		Console.WriteLine("Test Component Initialized!");
	}

	protected override void Update(GameTime gameTime)
	{
		if (_counter >= _counterMax)
		{
			Game.Exit();
		}

		Console.WriteLine($"Update Step {_counter}");
		_counter++;
	}

	protected override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
	{
		Console.WriteLine($"Draw Step {_counter}");
	}
}