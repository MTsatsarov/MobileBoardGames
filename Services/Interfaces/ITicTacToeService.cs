using BoardGames.Models;
using System.Collections.ObjectModel;

namespace BoardGames.Services.Interfaces
{
    public interface ITicTacToeService
    {
       public int FindBestMove(ObservableCollection<TicTacToeBoard> boards);
    }
}
