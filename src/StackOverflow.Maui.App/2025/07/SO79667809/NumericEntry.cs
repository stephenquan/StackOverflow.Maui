// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using Microsoft.Maui.Platform;

namespace StackOverflow.Maui.App.SO79667809;

/// <summary>
/// Implements an Entry control that only accepts numeric input.
/// </summary>
public partial class NumericEntry : Entry
{
	/// <summary>
	/// Initializes a new instance of the <see cref="NumericEntry"/> class.
	/// </summary>
	public NumericEntry()
	{
		this.Keyboard = Keyboard.Numeric;
	}

	/// <summary>
	/// Implements the numeric entry hack.
	/// </summary>
	public static void ImplementNumericEntryHack()
	{
		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NumericEntryHack", (handler, entry) =>
		{
			if (entry is NumericEntry)
			{
#if ANDROID
				handler.PlatformView.ViewAttachedToWindow += (object? sender, Android.Views.View.ViewAttachedToWindowEventArgs e) =>
				{
					handler.PlatformView.KeyListener = Android.Text.Method.DigitsKeyListener.GetInstance("0123456789-,.");
					handler.PlatformView.ImeOptions = entry.ReturnType.ToPlatform();
				};
#endif
			}
		});
	}
}
