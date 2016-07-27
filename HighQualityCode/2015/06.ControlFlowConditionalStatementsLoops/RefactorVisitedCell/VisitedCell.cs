namespace RefactorVisitedCell
{
    public class VisitedCell
    {
        public static void Main()
        {
            /*if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
            {
               VisitCell();
            }*/

            const int MinX = 0;
            const int MaxX = 100;
            const int MinY = 0;
            const int MaxY = 100;

            int x = 20;
            int y = 75;
            bool isCellNotVisited = true;
            bool isXInRange = IsInRange(x, MinX, MaxX);
            bool isYInRange = IsInRange(y, MinY, MaxY);

            if (isCellNotVisited && isXInRange && isYInRange)
            {
                System.Console.WriteLine("Cell Visited");
            }
        }

        public static bool IsInRange(int value, int min, int max)
        {
            if (min <= value && value <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}