namespace SO79738507;

#pragma warning disable CS1591 // Suppressing warnings for missing XML comments on public types and members

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}