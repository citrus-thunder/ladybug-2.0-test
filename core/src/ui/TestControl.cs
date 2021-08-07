using System;

using Ladybug.Beta.UI;

public class TestControl : Control
{
	protected override void Attach(Control parentControl)
	{
		Console.WriteLine("Test control attached!");
	}
}