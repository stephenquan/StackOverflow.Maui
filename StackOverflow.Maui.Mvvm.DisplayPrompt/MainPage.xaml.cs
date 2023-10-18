namespace StackOverflow.Maui.Mvvm.DisplayPrompt;

public partial class MainPage : ContentPage
{
    public MainPage(BalanceViewModel VM)
    {
        InitializeComponent();
        BindingContext = VM;
    }
}