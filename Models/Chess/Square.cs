namespace BoardGames.Models.Chess
{
	public class Square
	{
		public Square(int row, int col)
		{
			this.Row = row; 
			this.Col = col;
		}

		public int Row { get; set; }

		public int Col { get; set; }
	}
}
