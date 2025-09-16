using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace StackOverflow.Maui.App;

#pragma warning disable CS1591 // Suppress missing XML comment for publicly visible type or member

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		Routing.RegisterRoute($"{nameof(SO63922234)}_{nameof(SO63922234.MainPage)}", typeof(SO63922234.MainPage));

		AppViewModel.Current.RegisterSample(
			"63922234",
			DateTime.Parse("2020-09-16"),
			DateTime.Parse("2023-09-17"),
			$"{nameof(SO63922234)}_{nameof(SO63922234.MainPage)}",
			typeof(SO63922234.MainPage),
			"IMarkupExtension with bindable properties",
			"Demonstrates how to use a custom MarkupExtension to create a FontImageSource with bindable properties.");

		return builder.Build();
	}
}
