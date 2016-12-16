using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "2147483648";
            var b = int.Parse(a);
            Console.WriteLine(b);
        }
    }
}
