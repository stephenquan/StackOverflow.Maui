namespace SO79689989;

#pragma warning disable CS1591 // Missing XML comments for publicly visible type or member

public partial class MainPage : ContentPage
{
	public static readonly BindableProperty LetsTryProperty = BindableProperty.Create(nameof(LetsTry), typeof(List<object>), typeof(MainPage));
	//public List<List<string>> LetsTry
	public List<object> LetsTry
	{
		get { return (List<object>)GetValue(LetsTryProperty); }
		set { SetValue(LetsTryProperty, value); }
	}

	public MainPage()
	{
		this.LetsTry = new List<object>()
		{
			new List<string>() { "A", "B", "C" },
		};

		//var a = typeof(List<string>).Assembly;

		//var x = (LetsTry[0][0];

		BindingContext = this;

		InitializeComponent();
	}
}
