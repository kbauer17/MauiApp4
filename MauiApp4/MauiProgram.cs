namespace MauiApp4;

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
                fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
            });		
        
        // Add statements for adding CatFactRepository as a singleton
        string dbPath = FileAccessHelper.GetLocalFilePath("catfact.db3");
        builder.Services.AddSingleton<CatFactRepository>(s =>
            ActivatorUtilities.CreateInstance<CatFactRepository>(s, dbPath));


        return builder.Build();
    }
}
