using Microsoft.Extensions.Logging;
using Mopups.Hosting;
using Mopups.Services;
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
            .UseUraniumUIMaterial()
            .ConfigureMopups()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Brands-Regular-400.otf", "FABrands");
                fonts.AddFont("Free-Regular-400.otf", "FARegular");
                fonts.AddFont("Free-Solid-900.otf", "FASolid");
            });

        builder.Services
            .AddSingleton(MopupService.Instance)
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
