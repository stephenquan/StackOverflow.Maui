using System.Globalization;
using CommunityToolkit.Maui.Extensions;

namespace SO79727653;

/// <summary>
/// Demonstrates a simple Maui app with a button that opens a picker control view.
/// </summary>
public partial class MainPage : ContentPage
{
	int count = 0;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainPage"/> class.
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}

	/// <summary>
	/// Button click handler that also demonstrates a language picker using the picker control view.
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

		CommunityToolkit.Maui.Core.IPopupResult<CultureInfo> result = await this.ShowPopupAsync<CultureInfo>(popup);

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
