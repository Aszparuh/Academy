namespace AllocateArray
{
    using System;

    class Start
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var array = GetInput(n);

            foreach (var number in array)
            {
                Console.WriteLine(number * 5);
            }
        }

        static int[] GetInput(int n)
        {
            int[] resultArr = new int[n];

            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = i; 
            }

            return resultArr;
        }
    }
}
