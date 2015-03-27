namespace SchoolSysytemLib.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class UniqueClassNumberStorage
    {
        private static List<string> studentNumberStorage = new List<string>();
        private static List<string> classNumberStorage = new List<string>();

        public static string CreateNewUniqueStud()
        {
            int nextNumber = 0;
            DateTime today = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            sb.Append(today.Year.ToString());
            sb.Append(nextNumber);
            while (!CheckIfExist(sb.ToString()))
            {
                nextNumber++;
                sb.Clear();
                sb.Append(today.Year.ToString());
                sb.Append(nextNumber);
            }

            return sb.ToString();
        }

        public static string CreateNewUniqueClass()
        {
            int nextNumber = 0;
            DateTime today = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            sb.Append(today.Year.ToString());
            sb.Append(today.Month);
            sb.Append(nextNumber);
            while (CheckIfExist(sb.ToString()))
            {
                nextNumber++;
                sb.Clear();
                sb.Append(today.Year.ToString());
                sb.Append(today.Month);
                sb.Append(nextNumber);
            }

            return sb.ToString();
        }

        private static bool CheckIfExist(string nextNumber)
        {
            if (studentNumberStorage.Contains(nextNumber))
            {
                return false;
            }
            else
            {
                studentNumberStorage.Add(nextNumber);
                return true;
            }
        }
    }
}