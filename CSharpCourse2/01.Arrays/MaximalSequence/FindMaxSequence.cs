namespace MaximalSequence
{
    using System;

    /*Write a program that finds the maximal sequence of equal elements in an array.*/

    class FindMaxSequence
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
                Console.Write("Enter integer on position {0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
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
            //Find the elements of the sequence/sequences and print them

            counter = 1;
            if (maxSequence == 1)
            {
                Console.WriteLine("There is no sequence of equal elements");
            }
            else
            {
                Console.WriteLine("Printing the maximal sequence or sequences of equal elements.");
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] == array[j + 1])
                    {
                        counter++;
                        if (counter == maxSequence)
                        {
                            sequenceElement = array[j];
                            int[] printArray = new int[maxSequence];
                            for (int i = 0; i < maxSequence; i++)
                            {
                                printArray[i] = sequenceElement;
                            }

                            Console.Write("{");
                            Console.Write(string.Join(",", printArray));
                            Console.WriteLine("}");
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
}
