namespace PrimeNumbers
{
    using System;
    using System.Collections;

    class Start
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                bool[] array = new bool[10000001];
                int maximal = (int)Math.Floor(Math.Sqrt(array.Length));

                for (int i = 2; i < maximal; i++)
                {
                    for (int j = i * i; j < array.Length; j += i)
                    {
                        array[j] = true;
                    }
                }


                for (int i = n; i >= 0; i--)
                {
                    if (array[i] == false)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}
