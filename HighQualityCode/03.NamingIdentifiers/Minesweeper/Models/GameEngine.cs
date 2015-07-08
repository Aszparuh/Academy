using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Models
{
    using System;
    using System.Collections.Generic;

    internal class GameEngine
    {
        private const char HiddenField = '?';
        private const char SafeField = '-';
        private const char BombField = '*';
        private const int FieldRows = 5;
        private const int FieldCols = 10;
        private const int FieldsToBeCleared = 35;
        private const string GameIntro = "Lets play Minesweeper!\nTry to find all fields without mines.\n" +
                                         "'top' shows the scoreboard.\n'start' starts a new game.\n" +
                                         "'exit' terminates the game!";
        private const string CommandMessage = "Enter row and column separated by space or a command: ";
        private const string CommandError = "\nError Invalid comand\n";

        internal static void Start()
        {
            string command = string.Empty;
            char[,] playField = GenereatePlayField();
            char[,] bombPositions = AddBombsToPlayField();
            int scoreCounter = 0;
            int playerPickForRow = 0;
            int playerPickForCol = 0;
            bool isBomb = false;
            bool showGameIntro = true;
            bool gameIsOver = false;
            List<Player> bestPlayers = new List<Player>(6);

            do
            {
                if (showGameIntro)
                {
                    Console.WriteLine(GameIntro);
                    DisplayFieldInConsole(playField);
                    showGameIntro = false;
                }

                Console.Write(CommandMessage);
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out playerPickForRow) &&
                    int.TryParse(command[2].ToString(), out playerPickForCol) &&
                        playerPickForRow <= playField.GetLength(0) && playerPickForCol <= playField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintScores(bestPlayers);
                        break;
                    case "start":
                        playField = GenereatePlayField();
                        bombPositions = AddBombsToPlayField();
                        DisplayFieldInConsole(playField);
                        isBomb = false;
                        showGameIntro = false;
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye!");
                        break;
                    case "turn":
                        if (bombPositions[playerPickForRow, playerPickForCol] != BombField)
                        {
                            if (bombPositions[playerPickForRow, playerPickForCol] == SafeField)
                            {
                                FillTheNumberOfBombs(playField, bombPositions, playerPickForRow, playerPickForCol);
                                scoreCounter++;
                            }

                            if (FieldsToBeCleared == scoreCounter)
                            {
                                gameIsOver = true;
                            }
                            else
                            {
                                DisplayFieldInConsole(playField);
                            }
                        }
                        else
                        {
                            isBomb = true;
                        }

                        break;
                    default:
                        Console.WriteLine(CommandError);
                        break;
                }

                if (isBomb)
                {
                    DisplayFieldInConsole(bombPositions);
                    Console.WriteLine("\nBooooom! A heroic death with {0} points. Plase enter your nickname: ", scoreCounter);
                    string name = Console.ReadLine();
                    Player currentPlayer = new Player(name, scoreCounter);
                    if (bestPlayers.Count < 5)
                    {
                        bestPlayers.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < bestPlayers.Count; i++)
                        {
                            if (bestPlayers[i].Points < currentPlayer.Points)
                            {
                                bestPlayers.Insert(i, currentPlayer);
                                bestPlayers.RemoveAt(bestPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    bestPlayers.Sort((Player first, Player second) => second.Name.CompareTo(first.Name));
                    bestPlayers.Sort((Player first, Player second) => second.Points.CompareTo(first.Points));
                    PrintScores(bestPlayers);

                    playField = GenereatePlayField();
                    bombPositions = AddBombsToPlayField();
                    scoreCounter = 0;
                    isBomb = false;
                    showGameIntro = true;
                }

                if (gameIsOver)
                {
                    Console.WriteLine("\nGREAT! You managed to open all 35 cells without hitting a bomb.");
                    DisplayFieldInConsole(bombPositions);
                    Console.WriteLine("Plsease enter your nickname: ");
                    string name = Console.ReadLine();
                    Player currentPlayer = new Player(name, scoreCounter);
                    bestPlayers.Add(currentPlayer);
                    PrintScores(bestPlayers);
                    playField = GenereatePlayField();
                    bombPositions = AddBombsToPlayField();
                    scoreCounter = 0;
                    gameIsOver = false;
                    showGameIntro = true;
                }
            }

            while (command != "exit");
            Console.WriteLine("Fin");
            Console.Read();
        }

        private static void PrintScores(List<Player> players)
        {
            Console.WriteLine("\nPlayers:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There are no players in the scoreboard!\n");
            }
        }

        private static void FillTheNumberOfBombs(char[,] playField, char[,] bombPositions, int row, int col)
        {
            char numberOfBombs = GetNumberOfBombs(bombPositions, row, col);
            bombPositions[row, col] = numberOfBombs;
            playField[row, col] = numberOfBombs;
        }

        private static void DisplayFieldInConsole(char[,] board)
        {
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < FieldRows; row++)
            {
                Console.Write("{0} | ", row);
                for (int col = 0; col < FieldCols; col++)
                {
                    Console.Write(string.Format("{0} ", board[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] FieldGenrator(char symbol)
        {
            char[,] board = new char[FieldRows, FieldCols];

            for (int row = 0; row < FieldRows; row++)
            {
                for (int col = 0; col < FieldCols; col++)
                {
                    board[row, col] = symbol;
                }
            }

            return board;
        }

        private static char[,] GenereatePlayField()
        {
            return GameEngine.FieldGenrator(HiddenField);
        }

        private static char[,] AddBombsToPlayField()
        {
            Random random = new Random();

            char[,] playField = GameEngine.FieldGenrator(SafeField);

            List<int> randomNumbers = new List<int>();
            while (randomNumbers.Count < 15)
            {
                int randomNumberToAdd = random.Next(50);
                if (!randomNumbers.Contains(randomNumberToAdd))
                {
                    randomNumbers.Add(randomNumberToAdd);
                }
            }

            foreach (int number in randomNumbers)
            {
                int cols = number / FieldCols;
                int rows = number % FieldCols;
                if (rows == 0 && number != 0)
                {
                    cols--;
                    rows = FieldCols;
                }
                else
                {
                    rows++;
                }

                playField[cols, rows - 1] = BombField;
            }

            return playField;
        }

        private static void AddNumberOfBombsInPlayField(char[,] playField)
        {
            int FieldRows = playField.GetLength(0);
            int FieldCols = playField.GetLength(1);

            for (int row = 0; row < FieldRows; row++)
            {
                for (int col = 0; col < FieldCols; col++)
                {
                    if (playField[row, col] != BombField)
                    {
                        char numberOfBombs = GetNumberOfBombs(playField, row, col);
                        playField[row, col] = numberOfBombs;
                    }
                }
            }
        }

        private static char GetNumberOfBombs(char[,] fieldWithBombs, int currentRow, int currentCol)
        {
            int numberOfBombs = 0;
            int row = fieldWithBombs.GetLength(0);
            int col = fieldWithBombs.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (fieldWithBombs[currentRow - 1, currentCol] == BombField)
                {
                    numberOfBombs++;
                }
            }

            if (currentRow + 1 < row)
            {
                if (fieldWithBombs[currentRow + 1, currentCol] == BombField)
                {
                    numberOfBombs++;
                }
            }

            if (currentCol - 1 >= 0)
            {
                if (fieldWithBombs[currentRow, currentCol - 1] == BombField)
                {
                    numberOfBombs++;
                }
            }

            if (currentCol + 1 < col)
            {
                if (fieldWithBombs[currentRow, currentCol + 1] == BombField)
                {
                    numberOfBombs++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentCol - 1 >= 0))
            {
                if (fieldWithBombs[currentRow - 1, currentCol - 1] == BombField)
                {
                    numberOfBombs++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentCol + 1 < col))
            {
                if (fieldWithBombs[currentRow - 1, currentCol + 1] == BombField)
                {
                    numberOfBombs++;
                }
            }

            if ((currentRow + 1 < row) && (currentCol - 1 >= 0))
            {
                if (fieldWithBombs[currentRow + 1, currentCol - 1] == BombField)
                {
                    numberOfBombs++;
                }
            }

            if ((currentRow + 1 < row) && (currentCol + 1 < col))
            {
                if (fieldWithBombs[currentRow + 1, currentCol + 1] == BombField)
                {
                    numberOfBombs++;
                }
            }

            return char.Parse(numberOfBombs.ToString());
        }
    }
}