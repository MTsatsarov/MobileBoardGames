namespace BoardGames.Models.Chess
{
	public class Square
	{
		public Square(int row, int col)
		{
			this.Row = row; 
			this.Col = col;
			if(row % 2 == 0)
			{
				if(col % 2 != 0)
				{
					IsWhite = true;
				}
			}
			else
			{
				if (col % 2 == 0)
				{
					IsWhite = true;
				}
			}
			this.InitialFigureSet(row,col);
		}

        public IFigure Figure { get; set; }

        public int Row { get; set; }

		public int Col { get; set; }

        public string ImagePath { get; set; }

		public bool IsWhite { get;private set; }

		private void InitialFigureSet(int row, int col)
		{
			if(row == 0)
			{
				//switch (col)
				//{
				//	case 0
				//	this.Figure = new :
				//}
			}
			if(row == 1)
			{
				this.Figure = new Pawn(Enums.Color.Black, "chess_black_pawn.png", "Pawn");
				this.ImagePath = "chess_black_pawn.png";
			}
		}
	}
}
