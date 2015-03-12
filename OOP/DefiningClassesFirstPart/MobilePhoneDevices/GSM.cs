using System;
using System.Collections.Generic;
using System.Text;


namespace MobilePhoneDevices
{
    public class GSM
    {
        public static readonly GSM iPhone4s = new GSM("Apple", "4s", string.Empty, (decimal)489.50, 
            new Battery("Non-removable 1432 mAh battery (5.3 Wh)", 200, 14, BatteryType.LiPo), 
            new Display((float)3.5, 16000000));
        private string manufacturer;
        private string model;
        private string owner;
        private decimal? price;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        public GSM(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model; 
        }

        public GSM(string manufacturer, string model, string owner, decimal price)
            : this(manufacturer, model)
        {
            this.Owner = owner;
            this.Price = price;
        }

        public GSM(string manufacturer, string model, string owner, decimal price, Battery anyBattery)
            : this(manufacturer, model, owner, price)
        {
            this.Battery = anyBattery;
        }

        public GSM(string manufacturer, string model, string owner, decimal price, Battery anyBattery, Display anyDisplay)
            : this(manufacturer, model, owner, price, anyBattery)
        {
            this.Display = anyDisplay;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("Invalid model name.");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("Invalid manufacturer.");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                if (this.owner == null || this.owner == string.Empty)
                {
                    return "Unknown";
                }
                else
                {
                    return this.owner;
                }
            }
            set { this.owner = value; }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price.");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public Battery Battery
        {
            get 
            {
                return this.battery;
            }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }
            

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Model: {0}", this.Model));
            sb.Append(Environment.NewLine);
            sb.Append(string.Format("Manufacturer: {0}", this.Manufacturer));
            sb.Append(Environment.NewLine);
            if (this.Owner != null)
            {
                sb.Append(string.Format("Owner: {0}", this.Owner));
            }
            else
            {
                sb.Append(string.Format("Owner: {0}", "Unknown"));
            }

            sb.Append(Environment.NewLine);
            if (this.price != null)
            {
                sb.Append(string.Format("Price: {0}", this.Price));
            }
            else
            {
                sb.Append(string.Format("Price: {0}", "N/a"));
            }

            sb.Append(Environment.NewLine);
            if (this.Battery != null)
            {
                sb.Append(string.Format("Battery Model: {0}", this.Battery.Model));
                sb.Append(Environment.NewLine);
                sb.Append(string.Format("Battery Type: {0}", this.Battery.Type));
            }
            else
            {
                sb.Append(string.Format("Battery: {0}", "Information N/a"));
            }

            sb.Append(Environment.NewLine);
            if (this.Display != null)
            {
                sb.Append(string.Format("Display Size: {0}", this.Display.Size));
                sb.Append(Environment.NewLine);
                sb.Append(string.Format("Display Colours: {0}", this.Display.NumberOfColours));
            }
            else
            {
                sb.Append(string.Format("Display: {0}", "Information N/a"));
            }

            return sb.ToString();
        }

        public void AddCallInHistory(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCallFromHistory(int index)
        {
            if (index > -1 && index < this.callHistory.Count)
            {
                this.callHistory.RemoveAt(index);
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid call history index");
            }
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public void PrintCallHistory()
        {
            if (this.callHistory.Count == 0)
            {
                Console.WriteLine("Call history is empty");
            }
            else
            {
                foreach (Call call in this.callHistory)
                {
                    Console.WriteLine(call);
                }
            }
        }

        public decimal CalculateCallTotalPrice(decimal pricePerMinute)
        {
            int totalDuration = 0;
            foreach (Call call in this.callHistory)
            {
                totalDuration = totalDuration + call.Duration;
            }

            return totalDuration / 60 * pricePerMinute;
        }
    }
}