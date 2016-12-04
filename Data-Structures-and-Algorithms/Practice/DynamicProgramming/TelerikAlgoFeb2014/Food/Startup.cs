using System;

namespace Food
{
    public class Item
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public int Value { get; set; }
    }

    public class Startup
    {
        public static void Main()
        {
            int maxFood = int.Parse(Console.ReadLine());
            int numberOfFoods = int.Parse(Console.ReadLine());
            var items = new Item[numberOfFoods];

            for (int i = 0; i < numberOfFoods; i++)
            {
                var currentSplitedText = Console.ReadLine().Split(' ');
                var itemName = currentSplitedText[0];
                var itemWeight = int.Parse(currentSplitedText[1]);
                var itemValue = int.Parse(currentSplitedText[2]);
                var item = new Item() { Name = itemName, Weight = itemWeight, Value = itemValue };
                items[i] = item;
            }

            int[,] knapsackField = new int[maxFood + 1, numberOfFoods + 1];
            int[,] backtrack = new int[maxFood + 1, numberOfFoods + 1];


        }
    }
}
