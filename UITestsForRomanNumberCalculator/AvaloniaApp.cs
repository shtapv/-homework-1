﻿using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Threading;
using Avalonia;
using Avalonia.ReactiveUI;
using RomanNumbersCalculator.Views;
using RomanNumbersCalculator;
using Avalonia.Headless;

namespace UITestsForRomanNumberCalculator
{
    internal class AvaloniaApp
    {
        public static void Stop()
        {
            var app = GetApp();
            if (app is IDisposable disposable)
            {
                Dispatcher.UIThread.Post(disposable.Dispose);
            }

            Dispatcher.UIThread.Post(() => app.Shutdown());
        }

        public static MainWindow GetMainWindow() => (MainWindow)GetApp().MainWindow;

        public static IClassicDesktopStyleApplicationLifetime GetApp() =>
            (IClassicDesktopStyleApplicationLifetime)Application.Current.ApplicationLifetime;

        public static AppBuilder BuildAvaloniaApp() =>
            AppBuilder
                .Configure<App>()
                .UsePlatformDetect()
                .UseReactiveUI()
                .UseHeadless();
    }
}
