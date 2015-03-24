namespace Timer
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public delegate void TimerEvent();

    class Timer
    {
        private readonly TimerEvent someEvent;
        private int intervalSec;

        public Timer(int interval)
        {
            this.IntervalSec = interval;
        }

        public int IntervalSec
        {
            get { return this.intervalSec; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Interval must be possitive number");
                }
                this.intervalSec = value;
            }
        }

        public void EventStart()
        {
            while (true)
            {
                someEvent();
                Thread.Sleep(this.intervalSec * 1000); //1 milisecond = 0.001 seconds
            }
        }
    }
}