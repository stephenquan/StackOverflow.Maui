using Foundation;

namespace StackOverflow.Maui.App;

#pragma warning disable CS1591 // Suppress missing XML comment for publicly visible type or member

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
