namespace SumIntegers
{
    using System;

    /*You are given a sequence of positive integer values written into a string, separated by spaces.
      Write a function that reads these values from given string and calculates their sum.
      Example:

       input	           output
       "43 68 9 23 318"	   461*/

    class Sum
    {
        static int[] StringToIntArray(string sequence)
        {
            string[] arraySequence = sequence.Split(' ');
            int[] resultIntArray = new int[arraySequence.Length];
            for (int i = 0; i < resultIntArray.Length; i++)
            {
                resultIntArray[i] = int.Parse(arraySequence[i]);
            }

            return resultIntArray;
        }

        static int SumElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        static void Main()
        {
            string sequence = "43 68 9 23 318";
            int sum = SumElements(StringToIntArray(sequence));
            Console.WriteLine(sum);
        }
    }
}