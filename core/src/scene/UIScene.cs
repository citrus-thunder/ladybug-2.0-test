using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Ladybug;
using Ladybug.UI;
using Ladybug.UserInput;

using Colors = Ladybug.Graphics.ColorExtensions;

public class UIScene : Scene
{
	private UI _ui;

	protected override void Initialize()
	{
		_ui = BuildUI();
	}

	private UI BuildUI()
	{
		var ui = new UI(this);
		ui.ResourceCatalog.LoadResource<Texture2D>(UIResources.DefaultBackground, "image/ui/ui-frame");
		ui.ResourceCatalog.LoadResource<SpriteFont>(UIResources.DefaultFont, "font/default");

		bool updateSuccessful = false;
		var inline = Control.Compose()
			.OnAttach((IControlContainer parent) => { Console.WriteLine("Inline component attached"); })
			.OnUpdate(() =>
			{
				if (!updateSuccessful)
				{
					Console.WriteLine("Inline control updated!");
					updateSuccessful = true;
				}
			});

		ui.AddControl<TestControl>()
			.AddControl(inline)
			.AddControl(
				Control.Compose()
					.OnAttach((IControlContainer parent) => Console.WriteLine("Inline-composed control attached"))
				)
			.AddControl<Button>("test-button", out Button testButton)
			.AddControl<TextBox>("test-textbox", out TextBox testTextBox)
			.AddControl<StackPanel>("stack-panel", out StackPanel stackPanel);

		stackPanel.AddControl<Button>("stackbutton1", out Button stackButton1)
			.AddControl<Button>("stackbutton2", out Button stackButton2)
			.AddControl<Button>("stackbutton3", out Button stackButton3);

		stackButton1.Text = "Button 1";
		stackButton1.SetBounds(100, 100, 32 * 4, 32 * 2);
		stackButton2.Text = "Button 2";
		stackButton2.SetBounds(100, 100, 32 * 4, 32 * 2);
		stackButton3.Text = "Button 3";
		stackButton3.SetBounds(100, 100, 32 * 4, 32 * 2);

		stackPanel.Margin = new Margin(10);
		stackPanel.Separation = 5;
		stackPanel.SetBounds(200, 200, 32 * 10, 32 * 8);
		stackPanel.BackgroundTexture = null;
		
		testTextBox.BackgroundTexture = ui.ResourceCatalog.GetResource<Texture2D>(UIResources.DefaultBackground);
		testTextBox.SetBounds(300, 100, 32 * 6, 32 * 2);
		testTextBox.TextOffset = new Vector2(20, 20);

		testButton.SetBounds(100, 100, 32 * 4, 32 * 2);

		Color defaultColor = Color.Black;
		Color hoverColor = default(Color);

		testButton.TextColor = defaultColor;
		testTextBox.TextColor = defaultColor;

		if (Colors.TryParseColor("#525252", out Color color))
		{
			hoverColor = color;
		}

		testButton.Text = "Press Me";

		testButton.CursorEntered += (object sender, EventArgs e) =>
		{
			testButton.TextColor = hoverColor;
			Console.WriteLine("Cursor Entered Test Button!");
		};

		testButton.CursorLeft += (object sender, EventArgs e) =>
		{
			testButton.TextColor = defaultColor;
			Console.WriteLine("Cursor Left Test Button!");
		};

		testButton.Clicked += (object sender, InputState state) =>
		{
			if (state == InputState.Released)
			{
				Console.WriteLine("Test Button Clicked!");
				testTextBox.Active = !testTextBox.Active;
				testTextBox.Visible = !testTextBox.Visible;
			}
		};

		return ui;
	}

	protected override void Update(GameTime gameTime)
	{
		_ui.Update();
	}

	protected override void Draw(GameTime gameTime)
	{
		SpriteBatch.Begin();
		_ui.Draw(SpriteBatch);
		SpriteBatch.End();
	}
}