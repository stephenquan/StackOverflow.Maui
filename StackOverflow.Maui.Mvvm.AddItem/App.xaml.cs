namespace StackOverflow.Maui.Mvvm.AddItem
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