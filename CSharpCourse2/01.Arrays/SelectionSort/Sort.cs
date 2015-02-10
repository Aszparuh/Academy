namespace SelectionSort
{
    using System;

    /*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
      Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest 
      from the rest, move it at the second position, etc.*/

    class Sort
    {
        static void Main()
        {
            Console.Write("Enter the number of elements in the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] inputArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter the value of the element on position {0}: ", i);
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] > inputArray[j])
                    {
                        int temp = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
            }
        }
    }
}
