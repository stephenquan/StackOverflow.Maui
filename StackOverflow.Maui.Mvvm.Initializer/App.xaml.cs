namespace StackOverflow.Maui.Mvvm.Initializer
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