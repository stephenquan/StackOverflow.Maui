// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

namespace StackOverflow.Maui.App.SO79725472;

/// <summary>
/// 
/// </summary>
public partial class MainPage : ContentPage
{
	int count = 0;

	/// <summary>
	/// 
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
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

		var g = DeviceDisplay.Current.MainDisplayInfo.Density;

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
