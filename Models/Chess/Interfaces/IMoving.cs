
using System.Collections.ObjectModel;

namespace BoardGames.Models.Chess.Interfaces
{
	public interface IMoving
	{
		Dictionary<int, List<int>> AvailableMoves(ObservableCollection<Square> board,
			int currentRow,
			int currentCol);
	}
}
