/*
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

		var inline = Control.Compose()
			.OnAttach((Control parent) => { Console.WriteLine("Inline component attached"); })
			.OnUpdate(() => { Console.WriteLine("Inline control updated!"); });

		ui.AddControl<TestControl>()
			.AddControl(inline)
			.AddControl(
				Control.Compose()
					.OnAttach((Control parent) => Console.WriteLine("Inline-composed control attached"))
				);

		return ui;
	}

	private void Update(GameTime gameTime)
	{
		_ui.Update();
	}
}
*/