namespace RefactorForLoop
{
    public class ForLoop
    {
        public static bool FindValue(int[] collection, int valueToFind)
        {
            int length = collection.Length;

            for (int i = 0; i < length; i++)
            {
                if (collection[i] == valueToFind)
                {
                    return true;
                }
            }

            return false;
        }

        public static void Main()
        {
            int[] testArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int expectedValue = 6;

            System.Console.WriteLine(FindValue(testArray, expectedValue));
        }
    }
}