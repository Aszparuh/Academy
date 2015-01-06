using System;

class MaxSequence
{
    static void Main()
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 3, 2, 2, 1, 5, 5};
        int maxSequence = 1;
        int counter = 1;
        int mostRepeatedElement = 0;
        bool presenceOfOtherSequences = false;
        int numberOfSameMaximalSequences = 0;


        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                counter++;
                if (counter > maxSequence)
                {
                    maxSequence = counter;
                    mostRepeatedElement = array[i];
                }
                else if (counter == maxSequence)
                {
                    presenceOfOtherSequences = true;
                    numberOfSameMaximalSequences++;
                }
            }
            else
            {
                counter = 1;
            }
        }
        if (numberOfSameMaximalSequences == 0)
        {
            Console.WriteLine("There are no equal elements int the array.");
        }
        else if (presenceOfOtherSequences)
        {
            Console.WriteLine("There are {0} maximal sequences of equal elements.", numberOfSameMaximalSequences);
            Console.WriteLine("The sequences are: ");
            int printCounter = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                
                if (array[i] == array[i + 1])
                {
                    printCounter++;
                }
                else
                {
                    printCounter = 1;
                }
                if (printCounter == maxSequence)
                {
                    mostRepeatedElement = array[i];
                    int[] arraysToPrint = new int[maxSequence];
                    for (int j = 0; j < arraysToPrint.Length; j++)
                    {
                        arraysToPrint[j] = mostRepeatedElement;
                    }
                    Console.WriteLine();
                    Console.Write("{");
                    Console.Write(string.Join(" ,", arraysToPrint));
                    Console.Write("}");
                    Console.WriteLine();
                }
            }

        }
        else
        {
            Console.WriteLine("The maximal sequence of equal elements is: ");

            int[] arrayToPrint = new int[maxSequence];
            for (int j = 0; j < maxSequence; j++)
            {
                arrayToPrint[j] = mostRepeatedElement;
            }
            Console.Write("{");
            Console.Write(string.Join(" ,", arrayToPrint));
            Console.Write("}");
            Console.WriteLine();
        }
    }
}

