// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using Plugin.Maui.KeyListener;

namespace StackOverflow.Maui.App.SO79689008;

/// <summary>
/// Custom Entry control that demonstrates handling keyboard input.
/// </summary>
public partial class MyEntry : Entry
{
	KeyboardBehavior keyboardBehavior = new();

	/// <summary>
	/// Initializes a new instance of the <see cref="MyEntry"/> class.
	/// </summary>
	public MyEntry()
	{
		keyboardBehavior.KeyDown += OnKeyDown;
		keyboardBehavior.KeyUp += OnKeyUp;
		this.Behaviors.Add(keyboardBehavior);
	}

	void OnKeyUp(object? sender, KeyPressedEventArgs e)
	{
		switch (e.KeyChar)
		{
			case '\r':
				System.Diagnostics.Trace.WriteLine($"OnKeyUp: (handled): {e.Modifiers} {e.Keys} {e.KeyChar}");
				e.Handled = true;
				break;
			default:
				System.Diagnostics.Trace.WriteLine($"OnKeyUp: (pass-thru): {e.Modifiers} {e.Keys} {e.KeyChar}");
				break;
		}
	}

	void OnKeyDown(object? sender, KeyPressedEventArgs e)
	{
		switch (e.KeyChar)
		{
			case '\r':
				System.Diagnostics.Trace.WriteLine($"OnKeyReturn: (handled): {e.Modifiers} {e.Keys} {e.KeyChar}");
				e.Handled = true;
				break;
			default:
				System.Diagnostics.Trace.WriteLine($"OnKeyDown: (pass-thru): {e.Modifiers} {e.Keys} {e.KeyChar}");
				break;
		}
	}
}
