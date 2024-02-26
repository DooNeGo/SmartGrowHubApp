using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using Microcharts.Maui;
using Microsoft.Extensions.Logging;
using SmartGrowHubApp.Pages;
using SmartGrowHubApp.ViewModels;
using UraniumUI;

namespace SmartGrowHubApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseUraniumUI()
            .UseMicrocharts()
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitCore()
            .UseUraniumUIMaterial()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("GoogleSans-Regular.ttf", "GoogleRegular");
                fonts.AddFont("Free-Regular-400.otf", "FARegular");
                fonts.AddFont("Free-Solid-900.otf", "FASolid");
            });

        builder.Services
            .AddSingletonWithShellRoute<ControllerPage, ControllerPageModel>(nameof(ControllerPageModel))
            .AddSingletonWithShellRoute<SettingsPage, SettingsPageModel>(nameof(SettingsPageModel))
            .AddTransientWithShellRoute<SettingPage, SettingPageModel>(nameof(SettingPageModel))
            .AddTransientWithShellRoute<SensorReadingPage, SensorReadingPageModel>(nameof(SensorReadingPageModel));

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
