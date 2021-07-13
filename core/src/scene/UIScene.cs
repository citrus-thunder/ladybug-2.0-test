using System;

using Microsoft.Xna.Framework;

using Ladybug;
using Ladybug.Beta.UI;

public class UIScene : Scene
{
	private UI _ui;

	public UIScene()
	{
		_ui = BuildUI();
		OnUpdate(Update);
	}

	private UI BuildUI()
	{
		var ui = new UI(this);

		var inline = new Control()
			.OnAttach((Control parent) => { Console.WriteLine("Inline component attached"); })
			.OnUpdate(() => { Console.WriteLine("Inline control updated!"); });

		ui.AddControl<TestControl>()
			.AddControl(inline);

		return ui;
	}

	private void Update(GameTime gameTime)
	{
		_ui.Update();
	}
}