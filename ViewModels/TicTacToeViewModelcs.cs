using BoardGames.Models;
using BoardGames.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace BoardGames.ViewModels
{
	public partial class TicTacToeViewModelcs : BaseViewModel, INotifyPropertyChanged
	{
		private readonly ITicTacToeService ticTacToeService;

		[ObservableProperty]
		ObservableCollection<TicTacToeBoard> list;

		[ObservableProperty]
		private bool isRefreshing;

		public TicTacToeViewModelcs(ITicTacToeService ticTacToeService)
		{
			this.List = new ObservableCollection<TicTacToeBoard>();
			for (int i = 0; i < 9; i++)
			{
				this.List.Add(new TicTacToeBoard()
				{
					Index = i,
					ImagePath = null,
					Text = null
				});
			}
			this.ResetBoard();
			this.ticTacToeService = ticTacToeService;
		}

		[RelayCommand]
		public void ResetBoard()
		{
			this.List = new ObservableCollection<TicTacToeBoard>()
			{
				new TicTacToeBoard(0),
				new TicTacToeBoard(1),
				new TicTacToeBoard(2),
				new TicTacToeBoard(3),
				new TicTacToeBoard(4),
				new TicTacToeBoard(5),
				new TicTacToeBoard(6),
				new TicTacToeBoard(7),
				new TicTacToeBoard(8),
			};
			OnPropertyChanged(nameof(this.List));
		}


		[RelayCommand]
		public async Task MakeMove(int index)
		{
			if (this.IsBusy) return;

			this.IsBusy = true;

			this.List[index].Text = "X";
			this.List[index].ImagePath = "cross.png";

			var botIndex =  this.ticTacToeService.FindBestMove(this.List);
			var botMove = this.List.FirstOrDefault(x => x.Index == botIndex);
			botMove.Text = "O";
			botMove.ImagePath = "circle.png";
			this.IsBusy = false;
		}
	}
}

