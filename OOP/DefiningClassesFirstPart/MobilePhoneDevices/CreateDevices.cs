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
            var gm = new GSM("asdad", "sdasdasd");
            Console.WriteLine(gm.ToString());
        }
    }
}