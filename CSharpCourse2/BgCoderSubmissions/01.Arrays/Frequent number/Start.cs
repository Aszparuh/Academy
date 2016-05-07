namespace Frequent_number
{
    using System;

    class Start
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = GetInput(n);

            int counter = 0;
            int elementOccurance = 1;
            int mostFrequentElement = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                        if (counter > elementOccurance)
                        {
                            elementOccurance = counter;
                            mostFrequentElement = array[i];
                        }
                    }
                }

                counter = 0;
            }

            Console.WriteLine(mostFrequentElement + " " + "({0} times)", elementOccurance);
        }

        static int[] GetInput(int n)
        {
            int[] resultArr = new int[n];

            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = int.Parse(Console.ReadLine());
            }

            return resultArr;
        }
    }
}
