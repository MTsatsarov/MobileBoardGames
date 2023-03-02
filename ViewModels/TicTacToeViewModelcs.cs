using BoardGames.Models;
using BoardGames.Services.Interfaces;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;

namespace BoardGames.ViewModels
{
	public partial class TicTacToeViewModelcs : BaseViewModel
	{
		private readonly ITicTacToeService ticTacToeService;

		public ObservableCollection<TicTacToeBoard> List { get; set; } = new ObservableCollection<TicTacToeBoard>();

		public TicTacToeViewModelcs(ITicTacToeService ticTacToeService)
		{
			this.ResetBoard();
			this.ticTacToeService = ticTacToeService;
		}

		private void ResetBoard()
		{
			this.List.Clear();
			for (int i = 0; i < 9; i++)
			{
				List.Add(new TicTacToeBoard(i));
			}
		}

		[RelayCommand]
		public async Task MakeMove(TicTacToeBoard board)
		{
			if (this.IsBusy) return;

			this.IsBusy = true;

			board.Text = "X";
			board.ImagePath = "cross.png";

			var index =  this.ticTacToeService.FindBestMove(this.List);
			var botMove = this.List.FirstOrDefault(x => x.Index == index);
			botMove.Text = "O";
			botMove.ImagePath = "circle.png";
			this.IsBusy = false;
		}
	}
}

