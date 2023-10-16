namespace StackOverflow.Maui.Mvvm.AddItem;

public partial class MainPage : ContentPage
{
    MainViewModel VM;
    public MainPage(MainViewModel VM)
    {
        this.VM = VM;
        InitializeComponent();
        BindingContext = VM;
        VM.ScrollRequested += VM_ScrollRequested;
    }

    ~MainPage()
    {
        VM.ScrollRequested -= VM_ScrollRequested;
    }

    private void VM_ScrollRequested(object sender, int index)
    {
        collectionView.ScrollTo(index);
    }
}