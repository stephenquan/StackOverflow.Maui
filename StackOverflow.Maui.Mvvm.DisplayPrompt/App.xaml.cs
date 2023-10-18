namespace StackOverflow.Maui.Mvvm.DisplayPrompt
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