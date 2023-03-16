using BoardGames.Models;
using BoardGames.Pages;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BoardGames.ViewModels
{
	public partial class GamesListViewModel : BaseViewModel
	{
		public ObservableCollection<GamesCollectionModel> Games { get; } = new ObservableCollection<GamesCollectionModel>()
		{
			new GamesCollectionModel()
			{
				Name = "Tic Tac Toe",
				Location= nameof(TicTacToePage),
				ImagePath ="tictactoegamepng.png"
			},
			new GamesCollectionModel()
			{
				Name = "Chess",
				Location= nameof(ChessPage),
				ImagePath ="chess.svg"
			},
		};


		[RelayCommand]
		public async Task GoToGamePage(GamesCollectionModel model)
		{
			await Shell.Current.GoToAsync(model.Location);
		}
	}
}
