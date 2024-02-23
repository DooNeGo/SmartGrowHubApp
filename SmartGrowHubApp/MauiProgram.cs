using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
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
            .AddSingleton<ControllerPage>()
            .AddSingleton<ControllerPageModel>()
            .AddSingleton<SettingsPage>()
            .AddSingleton<SettingsPageModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
