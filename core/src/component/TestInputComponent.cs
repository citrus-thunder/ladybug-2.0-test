using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Ladybug;
using Ladybug.Input;
using Ladybug.ECS;
using Ladybug.ECS.Components;

public class TestInputComponentSystem : ComponentSystem<TestInputComponent> { }

public class TestInputComponent : Component
{
	private InputComponent _input;

	public TestInputComponent()
	{
		OnInitialize(Initialize);
		OnUpdate(Update);
	}

	private void Initialize()
	{
		Console.WriteLine("Test Input Component Initialized!");
		_input = Entity.GetComponent<InputComponent>();
	}

	private void Update(GameTime gameTime)
	{
		if (_input.KeyboardMonitor.CheckButton(Keys.Space, InputState.Pressed))
		{
			Console.WriteLine("Bump!");
		}
	}
}