// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

namespace StackOverflow.Maui.App.SO79745777;

/// <summary>
/// The application's main page.
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MainPage"/> class with the specified view model.
	/// </summary>
	/// <remarks>
	/// This demonstrates how to connect the MessageView to the MainViewModel and handle the SendMessageEvent to display an alert.
	/// </remarks>
	public MainPage(MainViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}
