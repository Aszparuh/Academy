using System;
using System.Collections.Generic;
using System.Linq;

namespace GoldFever
{
    public class GoldFever
    {
        public static void BecomeABillionaire(List<int> arr)
        {
            int i = 0, buy = 0, sell = 0, min = 0, profit = 0;

            for (i = 0; i < arr.Count; i++)
            {
                if (arr[i] < arr[min])
                    min = i;
                else if (arr[i] - arr[min] > profit)
                {
                    buy = min;
                    sell = i;
                    profit = arr[i] - arr[min];
                }

            }

            Console.WriteLine("We will buy at : " + arr[buy] + " sell at " + arr[sell] +
                    " and become billionaires worth " + profit);

        }

        public static void Main()
        {

            // stock prices on consecutive days
            //int[] price = { 1, 2, 1, 2 };
            // int n = price.Length;
            var n = int.Parse(Console.ReadLine());
            var price = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            BecomeABillionaire(price);
        }
    }
}

