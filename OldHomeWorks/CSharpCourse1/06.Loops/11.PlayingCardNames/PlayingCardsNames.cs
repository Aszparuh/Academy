using System;

class PlayingCardsNames
{
    static void Main()
    {
        string color = null;
        string card = null;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                switch (j)
                {
                    case 0: card = "Ace"; break;
                    case 1: card = "Two"; break;
                    case 2: card = "Three"; break;
                    case 3: card = "Four"; break;
                    case 4: card = "Five"; break;
                    case 5: card = "Six"; break;
                    case 6: card = "Seven"; break;
                    case 7: card = "Eight"; break;
                    case 8: card = "Nine"; break;
                    case 9: card = "Ten"; break;
                    case 10: card = "Jack"; break;
                    case 11: card = "Queen"; break;
                    case 12: card = "King"; break;
                    default: Console.WriteLine("Error in cards");
                        break;
                }
                switch (i)
                {
                    case 0: color = "clubs"; break;
                    case 1: color = "diamonds"; break;
                    case 2: color = "hearts"; break;
                    case 3: color = "spades"; break;
                    default: Console.WriteLine("Error in color");
                        break;
                }
                Console.WriteLine(card + " of " + color);
            }
        }
    }
}

