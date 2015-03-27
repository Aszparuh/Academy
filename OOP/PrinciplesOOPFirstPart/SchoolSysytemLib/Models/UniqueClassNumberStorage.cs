namespace SchoolSysytemLib.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class UniqueClassNumberStorage
    {
        private static List<string> numberStorage = new List<string>();

        public static string CreateNewUnique()
        {
            int nextNumber = 0;
            DateTime today = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            sb.Append(today.Year.ToString());
            sb.Append(nextNumber);
            while (CheckIfExist(sb.ToString()))
            {
                nextNumber++;
                sb.Clear();
                sb.Append(today.Year.ToString());
                sb.Append(nextNumber);
            }

            return sb.ToString();
        }



        private static bool CheckIfExist(string nextNumber)
        {
            if (numberStorage.Contains(nextNumber))
            {
                return false;
            }
            else
            {
                numberStorage.Add(nextNumber);
                return true;
            }
        }

    }
}