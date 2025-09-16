namespace StackOverflow.Maui.App;

#pragma warning disable CS1591 // Suppress missing XML comment for publicly visible type or member

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		BindingContext = AppViewModel.Current;
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

	async void OnNavigate(object? sender, EventArgs e)
	{
		Button btn = (Button)sender!;
		AppViewModel.Current.SelectedSample = (Sample)btn.BindingContext!;
		await Shell.Current.GoToAsync($"{nameof(SO63922234)}_{nameof(SO63922234.MainPage)}");
	}
}
