namespace SO79738507;

/// <summary>
/// Demonstrates a simple page that displays a line graph using a custom graphics view.
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Gets the view model associated with this page, which provides data and commands for the user interface.
	/// </summary>
	public MainViewModel VM { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="MainPage"/> class with the specified view model.
	/// </summary>
	/// <param name="vm"></param>
	public MainPage(MainViewModel vm)
	{
		this.VM = vm;
		BindingContext = this;
		InitializeComponent();
	}

	void OnRefreshClicked(object? sender, EventArgs e)
	{
		VM.Refresh();
		myGraphicsView.Invalidate();
	}
}
