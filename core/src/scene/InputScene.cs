using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

using Ladybug;
using Ladybug.UserInput;

public class InputScene : Scene
{
	public InputScene()
	{
		Input.SetAction("test", Keys.Space);
	}

	private void HandleInput(InputActionEventArgs e)
	{
		if (e.InputState == InputState.Released)
		{
			Console.WriteLine("Input action test success!");
		}
	}
}