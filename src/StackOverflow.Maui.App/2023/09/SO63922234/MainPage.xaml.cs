// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using SQuan.Helpers.Maui.Mvvm;

namespace StackOverflow.Maui.App.SO63922234;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public partial class MainPage : BasePage
{
	[ObservableProperty, NotifyPropertyChangedFor(nameof(IconName))] public partial int IconNameCode { get; set; } = 65;
	public string IconName => ((char)IconNameCode).ToString();
	[ObservableProperty] public partial double IconSize { get; set; } = 30.0;

	public MainPage()
	{
		BindingContext = this;
		InitializeComponent();
	}
}
