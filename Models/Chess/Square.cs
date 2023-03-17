namespace BoardGames.Models.Chess
{
	public class Square
	{
		public Square(int row, int col)
		{
			this.Row = row;
			this.Col = col;
			if (row % 2 == 0)
			{
				if (col % 2 != 0)
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
			this.InitialFigureSet(row, col);
		}

		public Figure Figure { get; set; }

		public int Row { get; set; }

		public int Col { get; set; }

		public string ImagePath { get; set; }

		public bool IsWhite { get; private set; }

		private void InitialFigureSet(int row, int col)
		{
			if (row == 0)
			{
				switch (col)
				{
					case 0:
					case 7:
						this.Figure = new Rook(Enums.Color.Black, "chess_rook_black.png", "Rook");
						break;
					case 1:
					case 6:
						this.Figure = new Knight(Enums.Color.Black, "chess_black_knight.png", "Knight");
						break;
					case 2:
					case 5:
						this.Figure = new Bishop(Enums.Color.Black, "chess_bishop_black.png", "Bishop");
						break;
					case 3:
						this.Figure = new Queen(Enums.Color.Black, "chess_queen_black.png", "Queen");
						break;
					case 4:
						this.Figure = new King(Enums.Color.Black, "chess_king_black.png", "King");
						break;
					default:
						break;
				}
			}
			if (row == 1 || row == 6)
			{
				Enums.Color color = Enums.Color.Black;
				string imagePath = "chess_black_pawn.png";
				if (row == 6)
				{
					color = Enums.Color.White;
					imagePath = "chess_white_pawn.png";
				}
				this.Figure = new Pawn(color, imagePath, "Pawn");
			}
			if (row == 7)
			{
				switch (col)
				{
					case 0:
					case 7:
						this.Figure = new Rook(Enums.Color.Black, "chess_rook_white.png", "Rook");
						break;
					case 1:
					case 6:
						this.Figure = new Knight(Enums.Color.Black, "chess_white_knight.png", "Knight");
						break;
					case 2:
					case 5:
						this.Figure = new Bishop(Enums.Color.Black, "chess_bishop_white.png", "Bishop");
						break;
					case 3:
						this.Figure = new Queen(Enums.Color.Black, "chess_queen_white.png", "Queen");
						break;
					case 4:
						this.Figure = new King(Enums.Color.Black, "chess_king_white.png", "King");
						break;
					default:
						break;


				}
			}
		}
	}
}
