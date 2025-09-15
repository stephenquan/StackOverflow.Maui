using SQuan.Helpers.Maui.Mvvm;

namespace SO79720042;

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
