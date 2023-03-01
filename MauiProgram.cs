using BoardGames.Pages;
using BoardGames.ViewModels;
using Microsoft.Extensions.Logging;

namespace BoardGames;

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

		//ViewModels
		builder.Services.AddSingleton<MainPageViewModel>();
		builder.Services.AddSingleton<GamesListViewModel>();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<GamesList>();
		builder.Services.AddSingleton<RegisterPage>();
		builder.Services.AddSingleton<TicTacToePage>();
#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
