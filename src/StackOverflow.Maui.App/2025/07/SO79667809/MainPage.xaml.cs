// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using System.Globalization;
using SQuan.Helpers.Maui.Mvvm;

namespace StackOverflow.Maui.App.SO79667809;

/// <summary>
/// Demonstrates a numeric entry control.
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Gets or sets a numeric value as a string.
	/// </summary>
	[ObservableProperty] public partial string LVK { get; set; } = string.Empty;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainPage"/> class.
	/// </summary>
	public MainPage()
	{
		CultureInfo.CurrentCulture = new CultureInfo("de-DE");
		BindingContext = this;
		InitializeComponent();
	}

}
