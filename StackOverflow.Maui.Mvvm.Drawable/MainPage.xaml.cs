namespace StackOverflow.Maui.Mvvm.Drawable
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel VM)
        {
            InitializeComponent();
            BindingContext = VM;
            VM.ScoreChanged += (s, e) => graphicsView.Invalidate();
        }
    }
}