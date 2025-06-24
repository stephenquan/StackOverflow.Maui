using SQuan.Helpers.Maui.Mvvm;

namespace SO63922234;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public partial class MainPage : ContentPage
{
	[ObservableProperty] public partial double IconSize { get; set; } = 30.0;

	public MainPage()
	{
		BindingContext = this;
		InitializeComponent();
	}
}
