namespace StackOverflow.Maui.App.SO79491466;

/// <summary>
/// Demonstrates workarounds to using DynamicResource with Behaviors
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MainPage"/> class.
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}

	void OnChangeButton(object sender, EventArgs e)
	{
		Button btn = (Button)sender;
		Color color = (Color)btn.CommandParameter;
		if (Application.Current is not null)
		{
			Application.Current.Resources["PrimaryColor"] = color;
			Application.Current.Resources["SecondaryColor"] = color;
			Application.Current.Resources["TertiaryColor"] = color;
		}

	}
}
