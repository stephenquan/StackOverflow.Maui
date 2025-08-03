namespace SO79717893;

/// <summary>
/// 
/// </summary>
public partial class MainPage : BaseAdvPage
{
	int count = 0;

	/// <summary>
	/// 
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	void OnCounterClicked(object? sender, EventArgs e)
	{
		count++;

		if (count == 1)
		{
			CounterBtn.Text = $"Clicked {count} time";
		}
		else
		{
			CounterBtn.Text = $"Clicked {count} times";
		}

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
