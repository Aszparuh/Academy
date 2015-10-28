namespace ExtendStringBuilder.Extensions
{
    using System;
    using System.Text;

    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int startIndex, int length)
        {
            if (startIndex >= sb.Length || startIndex + length > sb.Length || startIndex < 0)
            {
                throw new IndexOutOfRangeException("Invalid index or length");
            }
            if (length <= 0)
            {
                throw new IndexOutOfRangeException("Length should be possitive number");
            }

            var sbAsString = sb.ToString();
            string result = sbAsString.Substring(startIndex, length);
            return new StringBuilder(result);
        }
    }
}