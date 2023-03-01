using BoardGames.Pages;

namespace BoardGames;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
		Routing.RegisterRoute(nameof(GamesList), typeof(GamesList));
		Routing.RegisterRoute(nameof(TicTacToePage), typeof(TicTacToePage));
	}
}
