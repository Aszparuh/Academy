namespace RageQuit
{
    //100/100 SoftUni Judge
    using System;
    using System.Linq;
    using System.Text;

    class EntryPoint
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            StringBuilder numberSb = new StringBuilder();

            int number = 0;
            for (int i = 0; i < inputLine.Length; i++)
            {
                if (!char.IsNumber(inputLine[i]))
                {
                    sb.Append(inputLine[i]);
                }
                else
                {
                    numberSb.Append(inputLine[i]);
                    if (i + 1 < inputLine.Length && !char.IsNumber(inputLine[i + 1]))
                    {
                        number = int.Parse(numberSb.ToString());
                        for (int j = 0; j < number; j++)
                        {
                            result.Append(sb.ToString().ToUpper());
                        }

                        numberSb.Clear();
                        sb.Clear();
                        number = 0;
                    }
                    else
                    {
                        continue;
                    }                   
                }
            }

            if (numberSb.Length > 0)
            {
                number = int.Parse(numberSb.ToString());
                for (int j = 0; j < number; j++)
                {
                    result.Append(sb.ToString().ToUpper());
                }
            }

            string unique = new string(inputLine.Distinct().ToArray());
            int uniqueSimbols = result.ToString().Distinct().Count();
            Console.WriteLine("Unique symbols used: {0}", uniqueSimbols);
            Console.WriteLine(result.ToString());
        }
    }
}
