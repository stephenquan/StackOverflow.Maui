using Plugin.Maui.KeyListener;

namespace SO79689008;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public partial class MyEntry : Entry
{
	KeyboardBehavior keyboardBehavior = new();

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
