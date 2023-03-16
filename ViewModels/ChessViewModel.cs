using BoardGames.Models.Chess;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace BoardGames.ViewModels
{
	public partial class ChessViewModel : ObservableObject
	{
		[ObservableProperty]
		ObservableCollection<Square> board;

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
