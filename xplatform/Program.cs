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
				game.LoadScene<ECSScene>();
				game.Run();
			}
		}
	}
}
