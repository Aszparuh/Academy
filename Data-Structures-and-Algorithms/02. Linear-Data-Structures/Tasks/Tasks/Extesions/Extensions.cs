namespace Tasks.Extesions
{
    using System;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static List<int> GetLongestSubsequence(this List<int> list)
        {
            var length = list.Count;
            if (length == 0)
            {
                return new List<int>();
            }

            int subsequenceCounter = 1;
            int subsequencePosition = 0;
            int maxSubsequence = 0;
            int maxSubsequencePosition = 0;

            for (int i = 0; i < length - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    subsequenceCounter++;
                    subsequencePosition = i;
                    if (subsequenceCounter > maxSubsequence)
                    {
                        maxSubsequence = subsequenceCounter;
                        maxSubsequencePosition = subsequencePosition;
                    }
                }
                else
                {
                    subsequencePosition = 0;
                }
            }

            return list.GetRange(maxSubsequencePosition, maxSubsequence);
        }
    }
}