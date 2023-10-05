﻿namespace StackOverflow.Maui.Mvvm.Drawable;

internal static class ServiceHelper
{
    public static TService GetService<TService>()
        => Current.GetService<TService>();
    private static IServiceProvider Current =>
#if WINDOWS
			MauiWinUIApplication.Current.Services;
#elif ANDROID
            MauiApplication.Current.Services;
#elif IOS || MACCATALYST
            MauiUIApplicationDelegate.Current.Services;
#else
            null;
#endif
}