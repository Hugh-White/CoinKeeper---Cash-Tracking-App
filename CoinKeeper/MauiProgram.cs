using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using CoinKeeper.Repositories;
using CoinKeeper.MVVM.Models;
using CommunityToolkit.Maui;


namespace CoinKeeper
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Regular.ttf", "Regular");
                    fonts.AddFont("Montserrat-Bold.ttf", "Bold");
                });
#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<BaseRepository<Transaction>>();

            return builder.Build();
        }
    }
}
