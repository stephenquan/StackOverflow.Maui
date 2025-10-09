// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using SQuan.Helpers.Maui.Mvvm;

namespace StackOverflow.Maui.App.SO79689989;

/// <summary>
/// Represents a collection of strings that provides list functionalities.
/// </summary>
public partial class ListOfStrings : List<string>
{
}

/// <summary>
/// Demonstrates binding to a List of List of string.
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Gets or sets a list of list of strings to demonstrate binding.
	/// </summary>
	[BindableProperty] public partial List<ListOfStrings> LetsTry { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="MainPage"/> class.
	/// </summary>
	public MainPage()
	{
		this.LetsTry = new List<ListOfStrings>()
		{
			new ListOfStrings() { "A", "B", "C" },
		};

		BindingContext = this;

		InitializeComponent();
	}
}
