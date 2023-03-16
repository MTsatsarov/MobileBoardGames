using BoardGames.Pages;
using BoardGames.Services;
using BoardGames.Services.Interfaces;
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

		//Services
		builder.Services.AddTransient<ITicTacToeService, TicTacToeService>();

		//ViewModels
		builder.Services.AddSingleton<MainPageViewModel>();
		builder.Services.AddSingleton<GamesListViewModel>();
		builder.Services.AddTransient<TicTacToeViewModelcs>();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<GamesList>();
		builder.Services.AddSingleton<RegisterPage>();
		builder.Services.AddSingleton<ChessPage>();
		builder.Services.AddTransient<TicTacToePage>();
#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
