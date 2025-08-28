namespace SO79745777;

/// <summary>
/// 
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// 
	/// </summary>
	public MainPage(MainViewModel vm)
	{
		BindingContext = vm;
		vm.SendMessageEvent += (s, e) => DisplayAlert("Message", e.Message, "OK");
		InitializeComponent();
	}
}

