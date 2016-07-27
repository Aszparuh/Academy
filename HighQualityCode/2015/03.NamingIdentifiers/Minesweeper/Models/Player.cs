namespace Minesweeper.Models
{
    public class Player
    {
        public Player() { }

        public Player(string name, int то4ки)
        {
            this.Name = name;
            this.Points = то4ки;
        }

        public string Name { get; set; }

        public int Points { get; set; }
    }
}