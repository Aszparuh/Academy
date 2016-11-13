using System.Collections.Generic;
using Minesweeper.Models;

namespace Minesweeper.Contracts
{
    public interface IRenderer
    {
        void PrintGreetingMessage();

        void PrintBoard(char[,] board);

        void PrintTopScores(IList<Player> scores);
    }
}
