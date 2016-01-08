using System;
using System.Collections.Generic;
using MobilePhoneDevices;

namespace TestCallHistory
{
    class test
    {
        static void Main()
        {
            var testDevice = new GSM("China", "Chineseium 01");
            var history = new List<Call>();
            var start = DateTime.Now;
            var end = DateTime.Now;

            for (int i = 0; i < 8; i++)
            {
                end = end.AddMinutes(5);
                start = start.AddMinutes(3);
                history.Add(new Call("08845382948", start, end));
            }

            //test duration
            //foreach (var item in history)
            //{
            //    Console.WriteLine(item.Duration);
            //}

            for (int i = 0; i < history.Count; i++)
            {
                testDevice.AddCallInHistory(history[i]);
            }

            //Display call information
            var callHistoryTestDev = testDevice.CallHistory;
            Console.WriteLine("Call History");
            foreach (var call in testDevice.CallHistory)
            {
                Console.WriteLine("Dialed number: {0}, Duration: {1} seconds.", call.DialedNumber, call.Duration);
            }
            Console.WriteLine();

            //Calculate Price
            var price = testDevice.CalculateCallTotalPrice((decimal)0.37);
            Console.WriteLine("The total price is {0}", price);

            //Find and delete Longest call
            double longestDuration = 0;
            int indexLongestCall = 0;
            for (int i = 0; i < testDevice.CallHistory.Count; i++)
            {
                if (testDevice.CallHistory[i].Duration >= longestDuration)
                {
                    longestDuration = testDevice.CallHistory[i].Duration;
                    indexLongestCall = i;
                }
            }
        
            testDevice.DeleteCallFromHistory(indexLongestCall);
            price = testDevice.CalculateCallTotalPrice((decimal)0.37);
            Console.WriteLine("Longest call deleted price is {0}", price);

        }
    }
}