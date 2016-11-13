namespace MinesApplication.Models
{
    public class Player
    {
        private string name;
        private int scoredPoints;

        public Player(string name, int points)
        {
            this.name = name;
            this.scoredPoints = points;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int ScoredPoints
        {
            get { return this.scoredPoints; }
            set { this.scoredPoints = value; }
        }
    }
}
