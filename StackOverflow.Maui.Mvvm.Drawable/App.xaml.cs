namespace StackOverflow.Maui.Mvvm.Drawable
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}