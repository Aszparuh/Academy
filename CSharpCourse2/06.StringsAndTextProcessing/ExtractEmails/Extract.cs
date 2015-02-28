namespace ExtractEmails
{
    using System;
    using System.Collections.Generic;

    /*Write a program for extracting all email addresses from given text.
     All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.*/

    class Extract
    {
        static bool CheckMail(string mail)
        {
            string[] mailElements = mail.Split('@');
            if (mailElements[0].Length < 2 || mailElements[1].Length < 5)
            {
                return false;
            }
            string[] domainElements = mailElements[1].Split('.');
            if (domainElements.Length < 2)
            {
                return false;
            }

            for (int i = 0; i < domainElements.Length; i++)
            {
                if (domainElements[i].Length < 2)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            int startPos = 0;
            int endPos = 0;
            int posOfAt = text.IndexOf('@');
            List<string> validMails = new List<string>();

            while (posOfAt > -1)
            {
                startPos = text.Substring(0, posOfAt).LastIndexOf(' ');
                endPos = text.IndexOf(' ', posOfAt);

                if (endPos == -1)
                {
                    endPos = text.Length;
                }

                string mail = text.Substring(startPos + 1, endPos - startPos - 1);
               
                if (char.IsPunctuation(mail[mail.Length - 1]))
                {
                    mail = mail.Remove(mail.Length - 1);
                }

                if (CheckMail(mail))
                {
                    validMails.Add(mail);
                }

                posOfAt = text.IndexOf('@', endPos);
            }

            if (validMails.Count == 0)
            {
                Console.WriteLine("There is not a valid e-mail in the text.");
            }
            else
            {
                Console.WriteLine("All the valid e-mails are:");
                foreach (var email in validMails)
                {
                    Console.WriteLine(email);
                }
            }
        }
    }
}