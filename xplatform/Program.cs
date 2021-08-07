using System;

using Ladybug;

using lb2;

namespace xplatform
{
	public static class Program
	{
		[STAThread]
		static void Main()
		{
			using (var game = new Game())
			{
				var inline = Scene.Compose(game)
					.OnInitialize(() => Console.WriteLine("Inline Scene Initialized!"));
				
				game.GraphicsDeviceManager.PreferredBackBufferWidth = 800;
				game.GraphicsDeviceManager.PreferredBackBufferHeight = 480;
				game.GraphicsDeviceManager.ApplyChanges();
				
				game.LoadScene(inline);
				game.LoadScene<UIScene>();
				game.Run();
			}
		}
	}
}
