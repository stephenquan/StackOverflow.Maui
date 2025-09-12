namespace SO79696605;

/// <summary>
/// 
/// </summary>
public partial class MainPage : ContentPage
{
	int count = 0;

	/// <summary>
	/// 
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}

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
