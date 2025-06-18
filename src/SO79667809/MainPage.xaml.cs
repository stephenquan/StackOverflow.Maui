
using SQuan.Helpers.Maui.Mvvm;

namespace SO79667809;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public partial class MainPage : ContentPage
{
	[ObservableProperty] public partial string LVK { get; set; } = string.Empty;

	public MainPage()
	{
		BindingContext = this;
		InitializeComponent();
	}

}
