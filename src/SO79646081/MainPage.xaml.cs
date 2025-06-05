namespace SO79646081;

/// <summary>Represents the main page of the application.</summary>
public partial class MainPage : ContentPage
{
	/// <summary>Initializes a new instance of the <see cref="MainPage"/> class.</summary>
	public MainPage()
	{
		BindingContext = new Models.RelatorioCamposPersonalizadosViewModel();
		InitializeComponent();
	}
}
