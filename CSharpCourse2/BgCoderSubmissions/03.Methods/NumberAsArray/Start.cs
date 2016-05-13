namespace NumberAsArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            var separators = new char[] { ' ' };
            var inputSizes = Console.ReadLine().Split(separators).ToArray();
            int firstLength = int.Parse(inputSizes[0]);
            int secondLength = int.Parse(inputSizes[1]);            

            var firstArray = Console.ReadLine().Split(separators).Select(n => int.Parse(n)).ToArray();
            var secondArray = Console.ReadLine().Split(separators).Select(n => int.Parse(n)).ToArray();
            int[] longerArray;
            int[] shorterArray;

            if (firstArray.Length >= secondArray.Length)
            {
                longerArray = firstArray;
                shorterArray = secondArray;
            }
            else
            {
                longerArray = secondArray;
                shorterArray = firstArray;
            }

            var resultArray = new List<int>();

            int residue = 0;
            for (int i = 0; i < shorterArray.Length; i++)
            {
                
                int sum = shorterArray[i] + longerArray[i] + residue;
                if (sum > 9)
                {
                    residue = 1;
                    resultArray.Add(sum % 10);
                }
                else
                {
                    residue = 0;
                    resultArray.Add(sum);
                }                
            }

            for (int i = shorterArray.Length; i < longerArray.Length; i++)
            {
                resultArray.Add(longerArray[i] + residue);
                if (resultArray[i] > 9)
                {
                    residue = 1;
                    resultArray[i] %= 10;
                }
                else
                {
                    residue = 0;
                }
            }

            if (residue == 1)
            {
                resultArray.Add(1);
            }

            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
