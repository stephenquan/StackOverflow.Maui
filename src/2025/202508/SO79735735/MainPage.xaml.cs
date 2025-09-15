using System.Collections.ObjectModel;

namespace SO79735735;

/// <summary>
/// Sample application demonstrating the use of an ObservableCollection with a decimal property.
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Sample collection of items with decimal counts.
	/// </summary>
	public ObservableCollection<ItemModel> Items { get; } =
	[
		new ItemModel { Count = 2m },
		new ItemModel { Count = 2.5m },
		new ItemModel { Count = 2.1234567890m },
	];

	/// <summary>
	/// Initializes a new instance of the <see cref="MainPage"/> class.
	/// </summary>
	public MainPage()
	{
		BindingContext = this;
		InitializeComponent();
	}
}
