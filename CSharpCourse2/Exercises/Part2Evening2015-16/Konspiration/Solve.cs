namespace Konspiration
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Solve
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var allText = new string[n];
            var list = new List<List<string>>();
            var currentList = new List<string>();


            for (int i = 0; i < n; i++)
            {
                allText[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                string currentLine = allText[i].Trim();
                int indexOfOpenBracket = currentLine.IndexOf('(');
                int IndexOfStatic = currentLine.IndexOf("static ");

                if (IndexOfStatic == 0)
                {
                    if (currentList.Count > 0)
                    {
                        list.Add(currentList);
                        currentList = new List<string>();
                    }
                                       
                    string methodName = GetMethodName(currentLine.Substring(0, indexOfOpenBracket));
                    currentList.Add(methodName);                    
                }

                if (indexOfOpenBracket > -1 && IndexOfStatic == -1)
                {
                    while (indexOfOpenBracket > -1)
                    {
                        int indexOfFirstCharBeforeBracket = indexOfOpenBracket - 1;
                        char charBeforeBracket = currentLine[indexOfFirstCharBeforeBracket];

                        if (char.IsLetterOrDigit(charBeforeBracket))
                        {
                            string methodName = GetInvokedMethodName(indexOfOpenBracket, currentLine.Substring(0, indexOfOpenBracket));
                            currentList.Add(methodName);
                        }

                        indexOfOpenBracket = currentLine.IndexOf('(', indexOfOpenBracket + 1);
                    }
                }
            }

            if (currentList.Count > 0)
            {
                list.Add(currentList);
            }

            Print(list);
            //Console.WriteLine();
        }

        static string GetMethodName(string currentLine)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = currentLine.Length - 1; i >= 0; i--)
            {
                if (char.IsLetterOrDigit(currentLine[i]))
                {
                    sb.Insert(0, currentLine[i]);
                }
                else
                {
                    break;
                }
            }

            return sb.ToString();
        }

        static string GetInvokedMethodName(int indexOfBracket, string currentLine)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = currentLine.Length - 1; i >= 0; i--)
            {
                if (char.IsLetterOrDigit(currentLine[i]))
                {
                    sb.Insert(0, currentLine[i]);
                }
                else
                {
                    break;
                }
            }

            return sb.ToString();
        }

        static void Print(List<List<string>> collection)
        {
            foreach (var list in collection)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(list[i]);
                        Console.Write(" ");
                        Console.Write("->");
                        Console.Write(" ");
                        if (list.Count == 1)
                        {
                            Console.Write("None");
                        }
                        else
                        {
                            Console.Write(list.Count - 1);
                            Console.Write(" ");
                            Console.Write("->");
                            Console.Write(" ");
                        }
                        
                    }
                    else if (i == list.Count - 1)
                    {
                        Console.Write(list[i]);
                    }
                    else
                    {
                        Console.Write(list[i] + "," + " ");
                    }

                }

                Console.WriteLine();
            }
        }
    }
}
