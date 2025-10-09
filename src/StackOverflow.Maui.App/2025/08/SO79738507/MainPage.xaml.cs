// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

namespace StackOverflow.Maui.App.SO79738507;

/// <summary>
/// Demonstrates a simple page that displays a line graph using a custom graphics view.
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MainPage"/> class with the specified view model.
	/// </summary>
	public MainPage()
	{
		BindingContext = new MainViewModel();
		InitializeComponent();
	}
}
