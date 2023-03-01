using BoardGames.ViewModels;

namespace BoardGames.Pages;

public partial class GamesList : ContentPage
{
	public GamesList(GamesListViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}