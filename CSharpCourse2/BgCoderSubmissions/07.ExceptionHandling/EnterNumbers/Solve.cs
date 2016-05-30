namespace EnterNumbers
{
    using System;

    class Solve
    {
        static void Main()
        {
            int[] numbers = new int[12];
            numbers[0] = 1;
            numbers[numbers.Length - 1] = 100;
            for (int i = 1; i < 11; i++)
            {
                numbers[i] = ReadNumber(numbers[i - 1], numbers[numbers.Length - 1]);
            }

            Console.WriteLine(string.Join(" < ", numbers));
        }

        static int ReadNumber(int start, int end)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return number;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        } 
    }
}
