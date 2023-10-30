// https://stackoverflow.com/questions/77376714/collectionview-binding-does-not-work-correctly

namespace StackOverflow.Maui.Mvvm.CultureInfoFlag;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel VM)
    {
        InitializeComponent();
        BindingContext = VM;
    }
}