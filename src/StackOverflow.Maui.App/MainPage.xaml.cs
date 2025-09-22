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
		AppViewModel.Current.SelectedSample = (Sample)btn.BindingContext!;
		await Shell.Current.GoToAsync($"{nameof(SO63922234)}_{nameof(SO63922234.MainPage)}");
	}
}
