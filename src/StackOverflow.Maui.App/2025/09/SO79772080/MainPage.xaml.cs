// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

namespace StackOverflow.Maui.App.SO79772080;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public partial class MainPage : BasePage
{
	public MainPage()
	{
		BindingContext = this;
		InitializeComponent();
	}

	void OnZoomInClicked(object sender, EventArgs e)
	{
		_imgMap.Scale *= 1.1;
	}

	void OnZoomOutClicked(object sender, EventArgs e)
	{
		_imgMap.Scale /= 1.1;
	}
}
