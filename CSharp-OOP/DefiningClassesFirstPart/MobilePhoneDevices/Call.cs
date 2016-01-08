using System;

namespace MobilePhoneDevices
{
    public class Call
    {
        private string dialedNumber;
        private DateTime callStart;
        private DateTime callEnd;
        private int durationSeconds;

        public Call(string dialedNumber, DateTime start, DateTime end)
        {
            int reslut = DateTime.Compare(start, end);
            if (reslut >= 0)
            {
                throw new ArgumentException("The date of the start of the call shuold be earlier than the end");
            }

            this.DialedNumber = dialedNumber;
            this.CallStart = start;
            this.CallEnd = end;
            this.Duration = (int)(end - start).TotalSeconds;
        }

        public string DialedNumber
        {
            get { return this.dialedNumber; }
            set { this.dialedNumber = value; }
        }

        public DateTime CallStart
        {
            get { return this.callStart; }
            set { this.callStart = value;}
        }

        public DateTime CallEnd
        {
            get { return this.callEnd; }
            set { this.callEnd = value; }
        }

        public int Duration
        {
            get { return this.durationSeconds; }
            set { this.durationSeconds = value; }
        }
    }
}