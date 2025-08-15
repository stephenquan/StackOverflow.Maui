namespace SO79735735;

#pragma warning disable CS1591 // Suppress Missing XML comment for publicly visible type or member

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