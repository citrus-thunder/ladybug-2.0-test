using System;

using Microsoft.Xna.Framework;

using Ladybug;
using Game = Ladybug.Game;

namespace lb2
{
	public class MainScene : Scene
	{
		private int _counter = 0;
		private int _counterMax = 100;

		public MainScene()
		{
			OnInitialize(() => 
			{
				Console.WriteLine("Main Scene Initialized!");
			});
			OnUpdate(Update);
		}

		private void Update(GameTime gameTime)
		{
			if (_counter >= _counterMax)
			{
				Console.WriteLine("We're here!");
				Game.Exit();
				return;
			}

			if (_counter == 0)
			{
				Console.WriteLine("Here we go!");
			}
			else if (_counter % 10 == 0)
			{
				Console.WriteLine("Step");
			}

			_counter++;
		}
	}
}