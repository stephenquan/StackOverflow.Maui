// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

namespace StackOverflow.Maui.App.SO79706434;

/// <summary>
/// Demonstrates a floating central button.
/// </summary>
public partial class MainPage : ContentPage
{
	int count = 0;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainPage"/> class.
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}

	void OnCounterClicked(object? sender, EventArgs e)
	{
		count++;

		if (count == 1)
		{
			CounterBtn.Text = $"Clicked {count} time";
		}
		else
		{
			CounterBtn.Text = $"Clicked {count} times";
		}

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
