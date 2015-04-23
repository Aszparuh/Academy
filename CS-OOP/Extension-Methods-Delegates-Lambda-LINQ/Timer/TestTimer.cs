namespace Timer
{
    using System;

    class TestTimer
    {
        static void Main()
        {
            var tm = new Timer(8);
            tm.EventStart(); 
           
        }

        public static void EventTriger()
        {
            Console.WriteLine("Something happened");
        }
    }
}