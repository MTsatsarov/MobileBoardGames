using BoardGames.Models;

namespace BoardGames.Services.Interfaces
{
    public interface ITicTacToeService
    {
       public int FindBestMove(IEnumerable<TicTacToeBoard> boards);
    }
}
