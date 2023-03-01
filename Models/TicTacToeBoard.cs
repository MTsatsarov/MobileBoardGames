using CommunityToolkit.Mvvm.ComponentModel;

namespace BoardGames.Models
{
	public partial class TicTacToeBoard : ObservableObject
	{
		[ObservableProperty]
		private int index;

		[ObservableProperty]
		private string text;
		public TicTacToeBoard(int index)
		{
			this.index = index;
		}

	}
}