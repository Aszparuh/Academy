using MinesApplication.Models;

namespace MinesApplication
{
    public class Startup
    {
        public static void Main()
        {
            var game = new GameEngine();
            game.Start();
        }
    }
}