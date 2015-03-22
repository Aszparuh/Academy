namespace ExtendStringBuilder.Extensions
{
    using System;
    using System.Text;

    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int startIndex, int length)
        {
            if (startIndex >= sb.Length || startIndex + length > sb.Length)
            {
                throw new IndexOutOfRangeException("Invalid index or length");
            }

            var sbAsString = sb.ToString();
            string result = sbAsString.Substring(startIndex, length);
            return new StringBuilder(result);
        }
    }
}