namespace StackOverflow.Maui.Mvvm.SelectMultiple
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