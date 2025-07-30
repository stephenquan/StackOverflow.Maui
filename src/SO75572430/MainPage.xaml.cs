namespace SO75572430;

/// <summary>
/// 
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// 
	/// </summary>
	public string FirstActionRowText { get; } = "FirstActionRowText";

	/// <summary>
	/// 
	/// </summary>
	public MainPage()
	{
		BindingContext = this;

		InitializeComponent();
	}
}
