namespace StackOverflow.Maui.Mvvm.RadioButton;

public partial class MainPage : ContentPage
{
    public Audit Audit { get; } = new Audit();

    public MainPage()
    {
        BindingContext = this;
        InitializeComponent();
    }
}