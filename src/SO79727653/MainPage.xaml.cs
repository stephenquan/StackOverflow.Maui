using System.Globalization;
using CommunityToolkit.Maui.Extensions;

namespace SO79727653;

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

	/// <summary>
	/// 
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	async void OnCounterClicked(object? sender, EventArgs e)
	{
		count++;

		List<CultureInfo> cultures =
		[
			new CultureInfo("en-US"),
			new CultureInfo("fr-FR"),
			new CultureInfo("de-DE"),
		];

		await Task.Delay(1);

		var popup = new PickerControlView<CultureInfo>
		{
			ItemsSource = new List<CultureInfo>()
			{
				new CultureInfo("en-US"),
				new CultureInfo("fr-FR"),
				new CultureInfo("de-DE"),
			},
			ItemTemplate = new DataTemplate(() =>
			{
				Label label = new Label();
				label.HeightRequest = 40;
				label.SetBinding(Label.TextProperty, "DisplayName");
				return label;
			}),
		};

		var result = await this.ShowPopupAsync<CultureInfo>(popup);

		if (result.WasDismissedByTappingOutsideOfPopup)
		{
			CounterBtn.Text = $"Clicked {count} times, popup dismissed by tapping outside";
		}
		else if (result.Result is CultureInfo c)
		{
			CounterBtn.Text = $"Clicked {count} times, selected culture: {c.DisplayName}";
		}
		else
		{
			CounterBtn.Text = $"Clicked {count} times, no selected culture";
		}

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
