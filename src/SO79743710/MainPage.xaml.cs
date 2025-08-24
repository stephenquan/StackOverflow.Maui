namespace SO79743710;

/// <summary>
/// Represents the main page of the application, providing the user interface and interaction logic.
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Gets a GPS view model for the page.
	/// </summary>
	public GPSViewModel VM { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="MainPage"/> class.
	/// </summary>
	public MainPage()
	{
		BindingContext = this.VM = new GPSViewModel() { CurrentDevice = new SerialDevice() };
		InitializeComponent();
	}
}
