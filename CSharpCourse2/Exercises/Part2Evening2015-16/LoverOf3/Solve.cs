namespace LoverOf3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solve
    {
        static void Main()
        {
            string dimensions = Console.ReadLine();
            var splitedDimensions = dimensions.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var rows = int.Parse(splitedDimensions[0]);
            var cols = int.Parse(splitedDimensions[1]);
            bool[,] isVisited = new bool[rows, cols];

            int n = int.Parse(Console.ReadLine());
            int currentRow = rows - 1;
            int currentCol = 0;

            for (int i = 0; i < n; i++)
            {

            }

        }

        static int GetDirection(string dirName)
        {
            switch (dirName)
            {
                case "UR":
                case "RU":
                    return 0;
                case "DR":
                case "RD":
                    return 1;
                case "DL":
                case "LD":
                    return 2;
                case "UL":
                case "LU":
                    return 3;
            }

            return -1;
        }
    }
}
