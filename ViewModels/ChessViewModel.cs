using BoardGames.Models.Chess;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BoardGames.ViewModels
{
	public partial class ChessViewModel : BaseViewModel
	{
		[ObservableProperty]
		ObservableCollection<Square> board;

		[RelayCommand]
		public void NotWorking(Square square)
		{
			var figure = square.Figure;
			if (figure != null)
			{
				var a = figure.AvailableMoves(this.Board, square.Row, square.Col);
			}
		}

		[RelayCommand]
		public void tatatat(Square square)
		{
			return;
		}
		public ChessViewModel()
		{
			this.board = new ObservableCollection<Square>();

			for (int row = 0; row < 8; row++)
			{
				for (int col = 0; col < 8; col++)
				{
					this.board.Add(new Square(row, col));
				}
			}
		}

		

	}
}
