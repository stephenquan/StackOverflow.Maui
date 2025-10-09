// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

namespace StackOverflow.Maui.App;

#pragma warning disable CS1591 // Suppress missing XML comment for publicly visible type or member

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		BindingContext = AppViewModel.Current;
		InitializeComponent();
	}

	async void OnNavigate(object? sender, EventArgs e)
	{
		Button btn = (Button)sender!;
		if (btn.BindingContext is Sample sample)
		{
			AppViewModel.Current.SelectedSample = sample;
			await Shell.Current.GoToAsync(sample.Route);
		}
		else
		{
			AppViewModel.Current.SelectedSample = null;
		}
	}
}
