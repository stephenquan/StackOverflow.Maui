namespace SO79726492;

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
