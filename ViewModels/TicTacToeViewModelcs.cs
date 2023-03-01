using BoardGames.Models;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BoardGames.ViewModels
{
	public partial class TicTacToeViewModelcs : BaseViewModel
	{
		public ObservableCollection<TicTacToeBoard> List { get; set; } = new ObservableCollection<TicTacToeBoard>();

		public TicTacToeViewModelcs()
		{
			this.ResetBoard();
		}

		private void ResetBoard()
		{
			for (int i = 0; i < 9; i++)
			{
				List.Add(new TicTacToeBoard(i));
			}
		}

		[RelayCommand]
		public async Task MakeMove(TicTacToeBoard board)
		{
			
			board.Text = "X";
		}
	}
}

