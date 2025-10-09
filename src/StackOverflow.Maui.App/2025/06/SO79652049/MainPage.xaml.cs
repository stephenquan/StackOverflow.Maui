// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

namespace StackOverflow.Maui.App.SO79652049;

/// <summary>
/// Sample .NET MAUI application demonstrating the use of a sorted collection with a selected item.
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>The application's ViewModel, which contains the data and logic for the UI.</summary>
	public ViewModel VM { get; } = new ViewModel();

	/// <summary>Initializes a new instance of the <see cref="MainPage"/> class.</summary>
	public MainPage()
	{
		BindingContext = VM;
		InitializeComponent();
	}
}
