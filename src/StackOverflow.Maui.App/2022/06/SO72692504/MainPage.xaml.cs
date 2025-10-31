// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

namespace StackOverflow.Maui.App.SO72692504;

/// <summary>
/// Sample demonstrating SQLite with MVVM in .NET MAUI.
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MainPage"/> class.
	/// </summary>
	public MainPage()
	{
		BindingContext = new MainViewModel();
		InitializeComponent();
	}
}
