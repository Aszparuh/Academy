using System;

/*Write a program that generates and prints all possible cards from a 
 * standard deck of 52 cards (without the jokers). The cards should be 
 * printed using the classical notation (like 5 of spades, A of hearts,
 * 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
 * Use 2 nested for-loops and a switch-case statement.*/

class PrintAllCards
{
    static void Main()
    {
        string color = null;
        string card = null;

        for (int j = 0; j < 13; j++)
        {
            for (int i = 0; i < 4; i++)
            {
                switch (j)
                {
                    case 0: card = "Two"; break;
                    case 1: card = "Three"; break;
                    case 2: card = "Four"; break;
                    case 3: card = "Five"; break;
                    case 4: card = "Six"; break;
                    case 5: card = "Seven"; break;
                    case 6: card = "Eight"; break;
                    case 7: card = "Nine"; break;
                    case 8: card = "Ten"; break;
                    case 9: card = "Jack"; break;
                    case 10: card = "Queen"; break;
                    case 11: card = "King"; break;
                    case 12: card = "Ace"; break;
                    default: Console.WriteLine("Error in cards");
                        break;
                }
                switch (i)
                {
                    case 0: color = "spades"; break;
                    case 1: color = "clubs"; break;
                    case 2: color = "hearts"; break;
                    case 3: color = "diamonds"; break;
                    default: Console.WriteLine("Error in color");
                        break;
                }
                Console.Write(card + " of " + color + ", ");
            }
            Console.WriteLine();
        }
    }
}