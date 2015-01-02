using System;

/*Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...*/

class FirstTen
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)        //By using a for loop, you can run a statement or a 
        {                                   //block of statements repeatedly until a specified expression evaluates to false. 
            if (i % 2 == 0)                 //This kind of loop is useful for iterating over arrays and for other applications
            {                               //in which you know in advance how many times you want the loop to iterate.*/
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write(-i + ", ");
            }
        }

        Console.WriteLine();
    }
}