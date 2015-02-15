namespace SubsetKWithSumS
{
    using System;

    /*Write a program that reads three integer numbers N, K and S and an array of N 
      elements from the console.
      Find in the array a subset of K elements that have sum S or indicate about its absence.*/

    class FindSum
    {
        static void Main()
        {
            long S = 14;
            //int N = int.Parse(Console.ReadLine());
            long[] input = new long[] { 2, 1, 2, 4, 3, 5, 2, 6 };
            long curSum = 0;
            int numberOfElementsK = 3;
            bool notFound = false;
            int counter = 0;

            //for (int i = 0; i < N; i++)
            //{
            //    input[i] = long.Parse(Console.ReadLine());
            //}

            for (int i = 1; i <= (int)Math.Pow(2, (double)input.Length) - 1; i++)
            {
                counter = 0;
                curSum = 0;
                string template = Convert.ToString(i, 2);
                string template1 = template.PadLeft(input.Length, '0');
                //Console.WriteLine(template1);
                for (int j = 0; j < template1.Length; j++)
                {
                    if (template1[j].ToString() == "1")
                    {
                        curSum += input[j];
                        counter++;
                    }
                }

                if (curSum == S && counter == numberOfElementsK)
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