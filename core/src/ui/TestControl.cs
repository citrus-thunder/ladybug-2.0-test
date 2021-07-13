using System;

using Ladybug.Beta.UI;

public class TestControl : Control
{
	public TestControl()
	{
		OnAttach((Control parent) => {Console.WriteLine("Test control attached!");});
	}
}