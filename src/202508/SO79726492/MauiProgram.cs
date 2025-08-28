using Microsoft.Extensions.Logging;

namespace SO79726492;

#pragma warning disable CS1591 // Suppress XML documentation warnings for brevity

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//#if DEBUG
		builder.Logging.AddDebug();
		//#endif

		return builder.Build();
	}
}
