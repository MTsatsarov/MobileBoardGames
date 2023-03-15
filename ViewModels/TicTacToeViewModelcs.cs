using BoardGames.Models;
using BoardGames.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace BoardGames.ViewModels
{
	public partial class TicTacToeViewModelcs : BaseViewModel
	{
		private readonly ITicTacToeService ticTacToeService;

		[ObservableProperty]
		ObservableCollection<TicTacToeBoard> list;

		[ObservableProperty]
		private bool isRefreshing;

		[ObservableProperty]
		private int playerScore;

		[ObservableProperty]
		private int botScore;

		private readonly string playerSign = "X";
		private readonly string botSign = "O";

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

			this.SetProperties(index,"cross.png",this.playerSign);

			var isPlayerWinner = this.ticTacToeService.CheckForWinner(this.List, "X");

			if (isPlayerWinner)
			{
				this.PlayerScore += 1;
				await ShowAlert("WINNER!!!","Player has won");
				this.IsBusy = false;

				return;
			}

			var botIndex =  this.ticTacToeService.FindBestMove(this.List);
			var botMove = this.List.FirstOrDefault(x => x.Index == botIndex);

			this.SetProperties(botIndex, "circle.png", this.botSign);

			var isBotWinner = this.ticTacToeService.CheckForWinner(this.List, "O");
			if(isBotWinner)
			{
				this.BotScore += 1;
				await ShowAlert("WINNER!!!","Bot has won");
				this.IsBusy = false;

				return;
			}

			this.IsBusy = false;
		}

		private async Task ShowAlert( string title,string message)
		{
			await Shell.Current.DisplayAlert(title, message,"OK");
			this.ResetBoard();
		}

		private void SetProperties(int index, string imagePath, string text)
		{
			this.List[index].Text = text;
			this.List[index].ImagePath = imagePath;
		}
	}
}

