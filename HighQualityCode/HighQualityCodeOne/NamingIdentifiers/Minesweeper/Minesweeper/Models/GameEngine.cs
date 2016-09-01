using System;
using System.Collections.Generic;

namespace MinesApplication.Models
{
    public class GameEngine
    {
        private const string GreetingText = "Let's play \"Minesweeper\". \n'top' shows Top Scores, \n'restart' starts new game, 'exit' to exit the game";
        private const string InputRowAndColumnMessage = "Enter row and column: ";
        private const string EndMessage = "Bye!";
        private const string InvalidCommandMessage = "Invalid command";
        private const string SteppedOnMineMessage = "Heroic death";
        private const string EnterNicknameMessage = "Enter nickname";
        private const string ExitMessage = "Made in Bulgaria";
        private const string FinishTheWholeGameMessage = "You win";
        private const string TopScoreHeading = "Points";
        private const string EmptyTopSoresMessage = "There are no scores";
        private const string ColumnsNumbers = "   0 1 2 3 4 5 6 7 8 9";
        private const string Separator = "   ---------------------";
        private const char MineSymbol = '*';
        private const char NoMineSymbol = '-';
        private const char HiddenSymbol = '?';
        private const int MaxTopScoresCount = 5;
        private const int NumberOfRows = 5;
        private const int NumberOfColumns = 10;

        public void Start()
        {
            string command = string.Empty;
            char[,] board = this.CreatePlayingBoard(NumberOfRows, NumberOfColumns);
            char[,] boardWithMines = this.PlaceMines(NumberOfRows, NumberOfColumns);
            int counter = 0;
            bool isExploded = false;
            List<Player> topScores = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool isFirstTurn = true;
            int maxNumberOfTurns = 35;
            bool isGameEnded = false;

            do
            {
                if (isFirstTurn)
                {
                    Console.WriteLine(GreetingText);
                    this.PrintBoard(board);
                    isFirstTurn = false;
                }

                Console.Write(InputRowAndColumnMessage);
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= board.GetLength(0) && column <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        this.PrintTopScores(topScores);
                        break;
                    case "restart":
                        board = this.CreatePlayingBoard(NumberOfRows, NumberOfColumns);
                        boardWithMines = this.PlaceMines(NumberOfRows, NumberOfColumns);
                        this.PrintBoard(board);
                        isExploded = false;
                        isFirstTurn = false;
                        break;
                    case "exit":
                        Console.WriteLine(EndMessage);
                        break;
                    case "turn":
                        if (boardWithMines[row, column] != MineSymbol)
                        {
                            if (boardWithMines[row, column] == NoMineSymbol)
                            {
                                this.NextTurn(board, boardWithMines, row, column);
                                counter++;
                            }

                            if (counter == maxNumberOfTurns)
                            {
                                isGameEnded = true;
                            }
                            else
                            {
                                this.PrintBoard(board);
                            }
                        }
                        else
                        {
                            isExploded = true;
                        }

                        break;
                    default:
                        Console.WriteLine(InvalidCommandMessage);
                        break;
                }

                if (isExploded)
                {
                    this.PrintBoard(boardWithMines);
                    Console.Write(SteppedOnMineMessage, counter);
                    Console.WriteLine(EnterNicknameMessage);

                    string nickname = Console.ReadLine();
                    Player newTopScoresEntry = new Player(nickname, counter);

                    if (topScores.Count < MaxTopScoresCount)
                    {
                        topScores.Add(newTopScoresEntry);
                    }
                    else
                    {
                        for (int i = 0; i < topScores.Count; i++)
                        {
                            if (topScores[i].ScoredPoints < newTopScoresEntry.ScoredPoints)
                            {
                                topScores.Insert(i, newTopScoresEntry);
                                topScores.RemoveAt(topScores.Count - 1);
                                break;
                            }
                        }
                    }

                    topScores.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    topScores.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.ScoredPoints.CompareTo(firstPlayer.ScoredPoints));
                    this.PrintTopScores(topScores);

                    board = this.CreatePlayingBoard(NumberOfRows, NumberOfColumns);
                    boardWithMines = this.PlaceMines(NumberOfRows, NumberOfColumns);
                    counter = 0;
                    isExploded = false;
                    isFirstTurn = true;
                }

                if (isGameEnded)
                {
                    Console.WriteLine(FinishTheWholeGameMessage);
                    this.PrintBoard(boardWithMines);
                    Console.WriteLine(EnterNicknameMessage);
                    string nickname = Console.ReadLine();
                    Player newTopScoresEntry = new Player(nickname, counter);
                    topScores.Add(newTopScoresEntry);
                    this.PrintTopScores(topScores);
                    board = this.CreatePlayingBoard(NumberOfRows, NumberOfColumns);
                    boardWithMines = this.PlaceMines(NumberOfRows, NumberOfColumns);
                    counter = 0;
                    isGameEnded = false;
                    isFirstTurn = true;
                }
            }
            while (command != "exit");
            Console.WriteLine(ExitMessage);
            Console.Read();
        }

        private void PrintTopScores(List<Player> scores)
        {
            Console.WriteLine(TopScoreHeading);
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2}", i + 1, scores[i].Name, scores[i].ScoredPoints);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(EmptyTopSoresMessage);
            }
        }

        private void NextTurn(char[,] board, char[,] mines, int row, int column)
        {
            char numberOfNeighbouringMines = this.CalculateNeighbouringMines(mines, row, column);
            mines[row, column] = numberOfNeighbouringMines;
            board[row, column] = numberOfNeighbouringMines;
        }

        private void PrintBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine(ColumnsNumbers);
            Console.WriteLine(Separator);
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine(Separator);
            Console.WriteLine();
        }

        private char[,] CreatePlayingBoard(int boardRows, int boardColumns)
        {
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = HiddenSymbol;
                }
            }

            return board;
        }

        private char[,] PlaceMines(int boardRows, int boardColumns)
        {
            char[,] playingBoard = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    playingBoard[i, j] = NoMineSymbol;
                }
            }

            List<int> randomNumbers = new List<int>();
            while (randomNumbers.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!randomNumbers.Contains(randomNumber))
                {
                    randomNumbers.Add(randomNumber);
                }
            }

            foreach (int number in randomNumbers)
            {
                int row = number % boardColumns;
                int column = number / boardColumns;
                if (row == 0 && number != 0)
                {
                    column--;
                    row = boardColumns;
                }
                else
                {
                    row++;
                }

                playingBoard[column, row - 1] = MineSymbol;
            }

            return playingBoard;
        }

        private void AddNumberOfNegibouringMines(char[,] board)
        {
            int row = board.GetLength(1);
            int columns = board.GetLength(0);

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (board[i, j] != MineSymbol)
                    {
                        char numberOfNeighbouringMines = this.CalculateNeighbouringMines(board, i, j);
                        board[i, j] = numberOfNeighbouringMines;
                    }
                }
            }
        }

        private char CalculateNeighbouringMines(char[,] board, int row, int column)
        {
            int pointsCounter = 0;
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, column] == MineSymbol)
                {
                    pointsCounter++;
                }
            }

            if (row + 1 < rows)
            {
                if (board[row + 1, column] == MineSymbol)
                {
                    pointsCounter++;
                }
            }

            if (column - 1 >= 0)
            {
                if (board[row, column - 1] == MineSymbol)
                {
                    pointsCounter++;
                }
            }

            if (column + 1 < columns)
            {
                if (board[row, column + 1] == MineSymbol)
                {
                    pointsCounter++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (board[row - 1, column - 1] == MineSymbol)
                {
                    pointsCounter++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (board[row - 1, column + 1] == MineSymbol)
                {
                    pointsCounter++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (board[row + 1, column - 1] == MineSymbol)
                {
                    pointsCounter++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (board[row + 1, column + 1] == MineSymbol)
                {
                    pointsCounter++;
                }
            }

            return char.Parse(pointsCounter.ToString());
        }
    }
}
