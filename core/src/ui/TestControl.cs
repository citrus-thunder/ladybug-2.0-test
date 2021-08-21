using System;

using Ladybug.UI;

public class TestControl : Control
{
	protected override void Attach(IControlContainer parentControl)
	{
		Console.WriteLine("Test control attached!");
	}
}