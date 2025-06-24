using SQuan.Helpers.Maui.Mvvm;

namespace SO74319669;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public partial class MainPage : ContentPage
{
	[ObservableProperty] public partial double RedValue { get; set; } = 0.0;
	[ObservableProperty] public partial double GreenValue { get; set; } = 0.0;
	[ObservableProperty] public partial double BlueValue { get; set; } = 0.0;
	public MainPage()
	{
		BindingContext = this;
		InitializeComponent();
	}
}
