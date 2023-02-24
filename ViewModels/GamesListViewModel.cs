using System.Collections.ObjectModel;

namespace BoardGames.ViewModels
{
	public partial class GamesListViewModel : BaseViewModel
	{
		public ObservableCollection<string> _games = new ObservableCollection<string>()
		{
			"Tic Tac Toe",
			"Chess",
		};
	}
}
