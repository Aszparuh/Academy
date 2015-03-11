using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevices
{
    class CreateDevices
    {
        static void Main()
        {
            //test
            string mod = "";
            string man = "HTc";
            var gg = new GSM(mod, man);
            Console.WriteLine(gg.ToString());

        }   
    }
}