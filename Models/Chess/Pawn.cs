

using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace BoardGames.Models.Chess
{
	public partial class Pawn : Figure
	{
		[ObservableProperty]
		private string imagePath;

		[ObservableProperty]
		private string name;

		[ObservableProperty]
		private Enums.Color color;

		public override bool HasMoved { get; set; }

		public Pawn(Enums.Color color, string imagePath, string name)
		{
			this.ImagePath = imagePath;
			this.Name = name;
			this.Color = color;
		}

		public override Dictionary<int, List<int>> AvailableMoves(
			ObservableCollection<Square> board, int currentRow, int currentCol)
		{
			var minRow = 0;
			var maxRow = 7;
			var minCol = 0;
			var maxCol = 7;

			var possibleMoves = new Dictionary<int, List<int>>();
			if (this.Color == Enums.Color.White)
			{
				maxRow = currentRow - 1;
				minRow = currentRow - 1;
				if (this.HasMoved)
				{
					minRow = maxRow - 2;
				}

				minCol = currentCol - 1;
				maxCol = currentCol + 1;

				for (int row = maxRow; row >= minRow; row--)
				{
					for (int col = minCol; col < maxCol; col++)
					{
						if (!this.CheckForValidField(row, col))
						{
							continue;
						}

						var square = board.Where(s => s.Row == row && s.Col == col).FirstOrDefault();
						if (col == currentCol)
						{
							if (square.Figure is null)
							{
								if (!possibleMoves.ContainsKey(row))
								{
									possibleMoves.Add(row, new List<int>());
								}
								possibleMoves[row].Add(col);
							}
						}
						else
						{
							//TODO Figure out how to get the figure from the square
							//if (square.Figure is not null)
							//{
							//	var figure = square.Figure as Figure;

							//	if (!possibleMoves.ContainsKey(row))
							//	{
							//		possibleMoves.Add(row, new List<int>());
							//	}
							//	possibleMoves[row].Add(col);
							//}
						}
					}
				}
			}
			else
			{
				minRow = currentRow;
				maxRow = minRow + 1;
				if (HasMoved)
				{
					maxRow = minRow + 2;
				}
			}

			return possibleMoves;
		}

		private bool CheckForValidField(int row, int col)
		{
			return row >= 0 && col >= 0 && col <= 7 && row <= 7;
		}


	}
}
