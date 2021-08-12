using System;

using Ladybug.UI;

public class TestControl : Control
{
	protected override void Attach(Control parentControl)
	{
		Console.WriteLine("Test control attached!");
	}
}