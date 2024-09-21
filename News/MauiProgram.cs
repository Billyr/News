﻿using Microsoft.Extensions.Logging;

namespace News
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("FontAwesomeSolid.otf", "FontAwesome");
                })
                .RegisterAppTypes();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }


        public static MauiAppBuilder RegisterAppTypes(this MauiAppBuilder mauiAppBuilder) 
        { 
            // Add ViewModels to services
            mauiAppBuilder.Services.AddTransient<ViewModels.HeadlinesViewModel>();

            // Add Views to services
            mauiAppBuilder.Services.AddTransient<Views.HeadlinesView>();
            mauiAppBuilder.Services.AddTransient<Views.ArticleItem>();
            mauiAppBuilder.Services.AddTransient<Views.AboutView>();

            return mauiAppBuilder;
        }


    }
}
