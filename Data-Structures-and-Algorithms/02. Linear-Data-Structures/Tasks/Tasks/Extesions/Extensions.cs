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

            int value = list[0];
            bool subsequenceExists = false;

            int currentSequenceStartIndex = 0;
            int currentSequenceLength = 1;

            int maxSequenceStartIndex = 0;
            int maxSequenceLength = 1;

            for (int i = 1; i < length; i++)
            {
                if (list[i] == value)
                {
                    subsequenceExists = true;
                    currentSequenceLength++;
                    continue;
                }

                if (currentSequenceLength > maxSequenceLength)
                {
                    maxSequenceLength = currentSequenceLength;
                    maxSequenceStartIndex = currentSequenceStartIndex;
                }

                currentSequenceStartIndex = i;
                currentSequenceLength = 1;
                value = list[i];
            }

            if (currentSequenceLength > maxSequenceLength)
            {
                maxSequenceLength = currentSequenceLength;
                maxSequenceStartIndex = currentSequenceStartIndex;
            }

            if (subsequenceExists)
            {
                var result = list.GetRange(maxSequenceStartIndex, maxSequenceLength);
                return result;
            }
            else
            {
                return new List<int>();
            }
        }
    }
}