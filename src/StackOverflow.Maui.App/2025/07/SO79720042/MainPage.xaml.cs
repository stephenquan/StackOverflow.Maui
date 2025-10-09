// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using SQuan.Helpers.Maui.Mvvm;

namespace StackOverflow.Maui.App.SO79720042;

/// <summary>
/// 
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// 
	/// </summary>
	[BindableProperty] public partial string GroupName { get; set; } = "Group 1";

	/// <summary>
	/// 
	/// </summary>
	[BindableProperty] public partial int Rating { get; set; } = 3;

	/// <summary>
	/// 
	/// </summary>
	public MainPage()
	{
		BindingContext = this;

		InitializeComponent();
	}
}
