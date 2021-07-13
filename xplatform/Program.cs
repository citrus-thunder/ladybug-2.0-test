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
				game.GraphicsDeviceManager.PreferredBackBufferWidth = 800;
				game.GraphicsDeviceManager.PreferredBackBufferHeight = 480;
				game.GraphicsDeviceManager.ApplyChanges();
				
				game.LoadScene<ECSScene>();
				game.Run();
			}
		}
	}
}
