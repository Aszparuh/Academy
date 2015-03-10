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
            this.Manufacturer = manufacturer;
            this.Model = model;
        }

        public GSM(string manufacturer, string model, string owner, decimal price) : this(manufacturer, model)
        {
            this.Owner = owner;
            this.Price = price;
        }

        public GSM(string manufacturer, string model, string owner, decimal price, Battery anyBattery, Display anyDisplay) : this(manufacturer, model, owner, price)
        {
            this.Battery = anyBattery;
            this.Display = anyDisplay;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public decimal Price
        {
            get { return this.Price; }
            set { this.price = value; }
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
            sb.Append(string.Format("Model: {0,10}", this.Model));
            sb.Append(Environment.NewLine);
            sb.Append(string.Format("Manufacturer: {0,10}", this.Manufacturer));
            sb.Append(Environment.NewLine);
            if (this.Owner != null)
            {
                sb.Append(string.Format("Owner: {0,10}", this.Owner));
            }
            else
            {
                sb.Append(string.Format("Owner: {0,10}", "Unknown"));
            }

            sb.Append(Environment.NewLine);
            if (this.Price != null)
            {
                sb.Append(string.Format("Price: {0,10}", this.Price));
            }
            else
            {
                sb.Append(string.Format("Price: {0,10}", "N/a"));
            }

            sb.Append(Environment.NewLine);
            if (this.Battery != null)
            {
                sb.Append(string.Format("Battery Model: {0,10}", this.Battery.Model));
                sb.Append(Environment.NewLine);
                sb.Append(string.Format("Battery Type: {0,10}", this.Battery.Type));
            }
            else
            {
                sb.Append(string.Format("Battery: {0,10}", "Information N/a"));
            }

            if (this.Display != null)
            {
                sb.Append(string.Format("Display Size: {0,10}", this.Display.Size));
                sb.Append(Environment.NewLine);
                sb.Append(string.Format("Display Colours: {0,10}", this.Display.NumberOfColours));
            }
            else
            {
                sb.Append(string.Format("Display: {0,10}", "Information N/a"));
            }

            return sb.ToString();
        }
    }
}