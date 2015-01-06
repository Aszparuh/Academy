using System;
/*Write a program that finds the maximal increasing
sequence in an array. Example:
{3, 2, 3, 4, 2, 2, 4}   {2, 3, 4}.*/

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter the length of the Array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        int counter = 1;
        int maxSequence = 1;
        int sequenceElement = 0;

        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter integer: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1] - 1)
            {
                counter++;
                if (maxSequence < counter)
                {
                    maxSequence = counter;
                }
            }
            else
            {
                counter = 1;
            }
        }
        //Printing
        counter = 1;
        if (maxSequence == 1)
        {
            Console.WriteLine("There isn't a maximal increasing sequence.");
        }
        else
        {
            Console.WriteLine("Printing the maximal increasing sequences or sequence.");
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1] - 1)
                {
                    counter++;
                    if (counter == maxSequence)
                    {
                        sequenceElement = array[i + 1];
                        int[] printingArray = new int[maxSequence];
                        for (int j = printingArray.Length - 1; j >= 0; j--)
                        {
                            printingArray[j] = sequenceElement;
                            sequenceElement--;
                        }
                        Console.Write("{");
                        Console.Write(string.Join(",", printingArray));
                        Console.Write("}");
                        Console.WriteLine();
                    }
                }
                else
                {
                    counter = 1;
                }
            }
        }
    }
}

