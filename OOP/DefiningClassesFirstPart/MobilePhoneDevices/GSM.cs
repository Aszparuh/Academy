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
            this.owner = null;
            this.price = null;
            this.battery = null;
            this.display = null;
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
    }
}