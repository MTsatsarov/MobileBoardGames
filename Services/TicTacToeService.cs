using BoardGames.Models;
using BoardGames.Services.Interfaces;
using System.Collections.ObjectModel;

namespace BoardGames.Services
{
	public class TicTacToeService : ITicTacToeService
	{
		public int FindBestMove(ObservableCollection<TicTacToeBoard> boards)
		{
			var board = new TicTacToeBoard[,] { { boards[0], boards[1], boards[2]},
												{ boards[3], boards[4], boards[5]},
												{ boards[6], boards[7], boards[8]},};

			var bestScore = int.MinValue;
			var moveRow = -1;
			var moveCol = -1;

			for (int row = 0; row < board.GetLength(0); row++)
			{
				for (int col = 0; col < board.GetLength(1); col++)
				{
					if (board[row, col].Text == null)
					{
						board[row, col].Text = "O";
						 var score = GetMiniMax(board, "X");

						board[row, col].Text = null;

						if (score > bestScore)
						{
							moveRow = row;
							moveCol = col;
							bestScore = score;
						}
					}
				}
			}

			return board[moveRow, moveCol].Index;
		}
		public int GetMiniMax(TicTacToeBoard[,] board, string forWho)
		{
			var score = CheckWhoWIns(board, forWho);
			if (score != 0)
			{
				return score;
			}

			if (forWho == "O")
			{
				var bestScore = int.MaxValue;
				for (var row = 0; row < 3; row++)
				{
					for (var col = 0; col < 3; col++)
					{
						if (board[row, col].Text == null)
						{
							board[row, col].Text = forWho;
							var currentScore = GetMiniMax(board, "X");
							board[row, col].Text = null;

							bestScore = Math.Min(bestScore, currentScore);
						}
					}
				}
				return bestScore;
			}
			else
			{
				var bestScore = int.MinValue;
				for (var i = 0; i < 3; i++)
				{
					for (var j = 0; j < 3; j++)
					{
						if (board[i, j].Text == null)
						{
							board[i, j].Text = forWho;
							var currentScore = GetMiniMax(board, "O");
							board[i, j].Text = null;

							bestScore = Math.Max(bestScore, currentScore);
						}
					}
				}
				return bestScore;
			}
		}

		private int CheckWhoWIns(TicTacToeBoard[,] board, string forWho)
		{
			for (int row = 0; row < board.GetLength(0); row++)
			{
				for (int col = 0; col < board.GetLength(1); col++)
				{
					if (string.IsNullOrEmpty(board[row, col].Text))
					{
						board[row, col].Text = "-";
					}
				}
			}
			if ((board[0, 0].Text == forWho && board[0, 1].Text == forWho && board[0, 2].Text == forWho)
			|| (board[1, 0].Text == forWho && board[1, 1].Text == forWho && board[1, 2].Text == forWho)
			|| (board[2, 0].Text == forWho && board[2, 1].Text == forWho && board[2, 2].Text == forWho)
			|| (board[0, 0].Text == forWho && board[1, 0].Text == forWho && board[2, 0].Text == forWho)
			|| (board[0, 1].Text == forWho && board[1, 1].Text == forWho && board[2, 1].Text == forWho)
			|| (board[0, 2].Text == forWho && board[1, 2].Text == forWho && board[2, 2].Text == forWho)
			|| (board[0, 0].Text == forWho && board[1, 1].Text == forWho && board[2, 2].Text == forWho)
			|| (board[0, 2].Text == forWho && board[1, 1].Text == forWho && board[2, 0].Text == forWho))
			{
				var score = 1;
				for (var i = 0; i < 3; i++)
				{
					for (var j = 0; j < 3; j++)
					{
						if (board[i, j].Text == "-")
						{
							score ++;
						}
					}
				}
				for (int row = 0; row < board.GetLength(0); row++)
				{
					for (int col = 0; col < board.GetLength(1); col++)
					{
						if (board[row, col].Text == "-")
						{
							board[row, col].Text = null;
						}
					}
				}
				return score;
			}
			for (int row = 0; row < board.GetLength(0); row++)
			{
				for (int col = 0; col < board.GetLength(1); col++)
				{
					if (board[row, col].Text == "-")
					{
						board[row, col].Text = null;
					}
				}
			}
			return 0;
		}

	}
}
