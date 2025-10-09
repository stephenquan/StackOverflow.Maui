// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using SQuan.Helpers.Maui.Mvvm;

namespace StackOverflow.Maui.App.SO75572430;

/// <summary>
/// A page that demonstrates how to concatenate formatted text with bindable properties in .NET MAUI.
/// </summary>
public partial class MainPage : BasePage
{
	/// <summary>
	/// Gets or sets the text for the first action row.
	/// </summary>
	[ObservableProperty]
	[NotifyPropertyChangedFor(nameof(FormattedFirstActionRowText))]
	public partial string FirstActionRowText { get; set; } = "FirstActionRowText";

	/// <summary>
	/// Gets a formatted string that combines static and dynamic text for the first action row.
	/// </summary>
	public FormattedString FormattedFirstActionRowText
		=> new FormattedString
		{
			Spans =
			{
				new Span { Text = "Recommendation: ", FontFamily = "Arial Bold", FontSize = 16, },
				new Span { Text = FirstActionRowText, FontFamily = "Arial", FontSize = 16, },
			}
		};

	/// <summary>
	/// Initializes a new instance of the <see cref="MainPage"/> class.
	/// </summary>
	public MainPage()
	{
		BindingContext = this;

		InitializeComponent();
	}
}
