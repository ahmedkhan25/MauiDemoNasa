using MauiDemoNasa.Services;
using MauiDemoNasa.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace MauiDemoNasa
{
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
                });

            var services = builder.Services;
            services.AddSingleton<IAPIService, APIService>();
            services.AddSingleton<MainPage>();
            services.AddSingleton<MainPageWithCal>();
            services.AddSingleton<MainPageViewModel>();

            return builder.Build();
        }
    }
}