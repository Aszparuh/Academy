namespace FindSumInArray
{
    using System;

    /*Write a program that finds in given array of integers
      a sequence of given sum S (if present). Example: 
     {4, 3, 1, 4, 2, 5, 8}, S=11   {4, 2, 5}*/

    class FindSum
    {
        static void Main()
        {
            //Console.Write("Enter the sum S: ");
            //int givenSum = int.Parse(Console.ReadLine());
            //Console.Write("Enter the length of the array: ");
            //int length = int.Parse(Console.ReadLine());
            //int[] array = new int[length];
            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write("Enter elment on position {0}: ", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //test
            int givenSum = 11;
            int[] array = new int[] { 4, 3, 1, 4, 2, 5, 8 };  

            //test

            int sum = array[0];
            int startIndex = 0;
            int endIndex = 0;
            bool existenceOfSum = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                sum = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {

                    if (sum == givenSum)
                    {
                        existenceOfSum = false;
                        endIndex = j - 1;
                        startIndex = i;
                        Console.WriteLine();
                        Console.Write("The elements whose sum is {0} are: ", givenSum);
                        Console.Write("{");
                        for (int k = startIndex; k <= endIndex; k++)
                        {
                            if (k < endIndex)
                            {
                                Console.Write(array[k] + ", ");
                            }
                            else if (k == endIndex)
                            {
                                Console.Write(array[k]);
                            }
                        }

                        Console.Write("}");

                    }

                    sum += array[j];
                }

            }

            if (existenceOfSum)
            {
                Console.WriteLine("Your sum was not found.");
            }
       
        }
    }
}