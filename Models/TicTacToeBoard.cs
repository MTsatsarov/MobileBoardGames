using CommunityToolkit.Mvvm.ComponentModel;

namespace BoardGames.Models
{
	public partial class TicTacToeBoard : ObservableObject
	{

		[ObservableProperty]
		private string _text;

		[ObservableProperty]
		private string imagePath;

		[ObservableProperty]
		private int index;

		public TicTacToeBoard()
        {
            
        }
        public TicTacToeBoard(int index)
		{
			this.Index = index;
			this.ImagePath = null;
		}
    }
}