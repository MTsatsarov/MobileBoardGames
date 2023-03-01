using BoardGames.Models;
using System.Collections.ObjectModel;

namespace BoardGames.ViewModels
{
	public class TicTacToeViewModelcs : BaseViewModel
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
	}
}

