using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevices
{
    class GSM
    {
        private string manufacturer;
        private string model;
        private string owner;
        private decimal? price;
        private Battery battery;
        private Display display;

        public GSM(string manufacturer, string model)
        {
            if (manufacturer == null || manufacturer == string.Empty)
            {
                throw new ArgumentException("Invalid manufacturer.");
            }
            else
            {
                this.Manufacturer = manufacturer;
            }

            if (model == null || model == string.Empty)
            {
                throw new ArgumentException("Invalid model.");
            }
            else
            {
                this.Model = model;
            }
            
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
            get { return this.Price; }
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
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
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
    }
}