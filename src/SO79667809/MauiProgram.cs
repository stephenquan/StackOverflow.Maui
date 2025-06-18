using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Platform;


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace SO79667809;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.UseMauiCommunityToolkitMarkup()

			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NumericEntryHack", (handler, entry) =>
		{
			if (entry.Keyboard == Keyboard.Numeric)
			{
#if ANDROID
				handler.PlatformView.ViewAttachedToWindow += (object? sender, Android.Views.View.ViewAttachedToWindowEventArgs e) =>
				{
					handler.PlatformView.KeyListener = Android.Text.Method.DigitsKeyListener.GetInstance("0123456789-,.");
					handler.PlatformView.ImeOptions = entry.ReturnType.ToPlatform();
				};
#endif
			}
		});

		return builder.Build();
	}
}
