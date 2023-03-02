using CommunityToolkit.Mvvm.ComponentModel;

namespace BoardGames.Models
{
	public partial class TicTacToeBoard : ObservableObject
	{

		[ObservableProperty]
		private string _text;

		[ObservableProperty]
		private string imagePath;

		public TicTacToeBoard(int index)
		{
			this.Index = index;
		}

        public int Index { get; set; }


    }
}