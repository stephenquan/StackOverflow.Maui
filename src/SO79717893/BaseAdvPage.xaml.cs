namespace SO79717893;

/// <summary>
/// A base class for pages that include advertisements.
/// </summary>
public partial class BaseAdvPage : ContentPage
{
	/// <summary>
	/// Bindable property for <see cref="Advertisement"/>.
	/// </summary>
	public static readonly BindableProperty AdvertisementProperty =
		BindableProperty.Create(nameof(Advertisement), typeof(string), typeof(BaseAdvPage), "Insert Advertisement here");

	/// <summary>
	/// Gets or sets the advertisement text.
	/// </summary>
	public string Advertisement
	{
		get => (string)GetValue(AdvertisementProperty);
		set => SetValue(AdvertisementProperty, value);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="BaseAdvPage"/> class.
	/// </summary>
	public BaseAdvPage()
	{
		InitializeComponent();
	}
}
