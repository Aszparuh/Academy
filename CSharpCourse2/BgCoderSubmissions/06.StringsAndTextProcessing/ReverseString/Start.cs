namespace ReverseString
{
    using System;

    class Start
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            for (int i = 0; i < inputArray.Length / 2; i++)
            {
                char temp = inputArray[i];
                inputArray[i] = input[inputArray.Length - i - 1];
                inputArray[inputArray.Length - i - 1] = temp;
            }

            Console.WriteLine(new string(inputArray));
        }
    }
}
