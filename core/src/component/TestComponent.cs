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

	public TestComponent()
	{
		OnInitialize(Initialize);
		OnUpdate(Update);
	}

	private void Initialize()
	{
		Console.WriteLine("Test Component Initialized!");
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

	private void Draw(GameTime gameTime, SpriteBatch spriteBatch)
	{
		Console.WriteLine($"Draw Step {_counter}");
	}
}