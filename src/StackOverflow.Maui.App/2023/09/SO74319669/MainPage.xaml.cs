// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using SQuan.Helpers.Maui.Mvvm;

namespace StackOverflow.Maui.App.SO74319669;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public partial class MainPage : BasePage
{
	[ObservableProperty] public partial double RedValue { get; set; } = 0.5;
	[ObservableProperty] public partial double GreenValue { get; set; } = 0.0;
	[ObservableProperty] public partial double BlueValue { get; set; } = 0.0;
	[ObservableProperty] public partial double AlphaValue { get; set; } = 0.5;
	[ObservableProperty, NotifyPropertyChangedFor(nameof(IconName))] public partial int IconNameCode { get; set; } = 65;
	public string IconName => ((char)IconNameCode).ToString();
	[ObservableProperty] public partial double IconSize { get; set; } = 30.0;
	public MainPage()
	{
		BindingContext = this;
		InitializeComponent();
	}
}
