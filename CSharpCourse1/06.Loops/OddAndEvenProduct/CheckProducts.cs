using System;

/*You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

class CheckProducts
{
    static void Main()
    {
        Console.Write("Paste input: ");
        string input = Console.ReadLine();
        string[] inputToStrArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] nums = new int[inputToStrArr.Length];

        for (int i = 0; i < inputToStrArr.Length; i++)
        {
            nums[i] = int.Parse(inputToStrArr[i]);
        }

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 != 0)
            {
                evenProduct *= nums[i];
            }
            else
            {
                oddProduct *= nums[i];
            }
        }
        
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Product = {0}", evenProduct);
        }
        
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Even_Product = {0}", evenProduct);
            Console.WriteLine("Odd_Product = {0}", oddProduct);
        }
    }
}