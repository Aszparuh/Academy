using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevices
{
    class GSMTest
    {
        static void Main()
        {
            var mobileDevices = new GSM[3];
            mobileDevices[0] = new GSM("HTC", "One M9", string.Empty, 900,
                new Battery("Non-removable 2840 mAh battery", 391, 21, BatteryType.LiPo),
                 new Display((float)5.0, 16000000));

            mobileDevices[1] = new GSM("Nokia", "Lumia 735", string.Empty, 800,
                new Battery(" 2200 mAh battery (BV-T5A)", 600, 22, BatteryType.LiIon),
                 new Display((float)4.7, 16000000));

            mobileDevices[2] = GSM.iPhone4s;


            foreach (var phone in mobileDevices)
            {
                Console.WriteLine(phone.ToString());
                Console.WriteLine();
            }    
        }  
    }
}