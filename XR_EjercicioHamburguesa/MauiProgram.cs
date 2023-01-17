using XR_EjercicioHamburguesa.Data;

namespace XR_EjercicioHamburguesa;

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
			});

        string dbPath = XRFileAccessHelper.GetLocalFilePath("people.db3");
        builder.Services.AddSingleton<XRBurgerDatabase>(s => ActivatorUtilities.CreateInstance<XRBurgerDatabase>(s, dbPath));


        return builder.Build();
	}
}
