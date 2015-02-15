namespace SubsetWithSumS
{
    using System;

    /*We are given an array of integers and a number S.
      Write a program to find if there exists a subset 
      of the elements of the array that has a sum S.*/

    class FindSum
    {
        static void Main()
        {
            long S = 14;
            //int N = int.Parse(Console.ReadLine());
            long[] input = new long[] { 2, 1, 2, 4, 3, 5, 2, 6 };
            long curSum = 0;
            bool notFound = false;

            //for (int i = 0; i < N; i++)
            //{
            //    input[i] = long.Parse(Console.ReadLine());
            //}

            for (int i = 1; i <= (int)Math.Pow(2, (double)input.Length) - 1; i++)
            {
                curSum = 0;
                string template = Convert.ToString(i, 2);
                string template1 = template.PadLeft(input.Length, '0');
                //Console.WriteLine(template1);
                for (int j = 0; j < template1.Length; j++)
                {
                    if (template1[j].ToString() == "1")
                    {
                        curSum += input[j];
                    }
                }

                if (curSum == S)
                {
                    Console.WriteLine("Yes");
                    break;
                }

                if (i == (int)Math.Pow(2, (double)input.Length) - 1)
                {
                    notFound = true;
                }
            }

            if (notFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}