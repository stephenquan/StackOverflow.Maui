// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

namespace StackOverflow.Maui.App.SO79726492;

/// <summary>
/// 
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// 
	/// </summary>
	public MainPage()
	{
		BindingContext = new JSONEditorViewModel();

		InitializeComponent();
	}
}
