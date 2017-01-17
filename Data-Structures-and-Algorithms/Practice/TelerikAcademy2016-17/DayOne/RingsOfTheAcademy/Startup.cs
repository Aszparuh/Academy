using System;
using System.Collections.Generic;

namespace RingsOfTheAcademy
{
    public class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                var next = int.Parse(Console.ReadLine());
                if (dic.ContainsKey(next))
                {
                    dic[next]++;
                }
                else
                {
                    dic.Add(next, 1);
                }
            }

            var result = 1;
            foreach (var item in dic)
            {
                result *= Factorial(item.Value);
            }

            Console.WriteLine(result);
        }

        public static int Factorial(int num)
        {
            var res = 1;
            while (num > 0)
            {
                res *= num;
                num--; 
            }

            return res;
        }
    }
}
