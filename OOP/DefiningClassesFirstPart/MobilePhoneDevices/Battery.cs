using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevices
{
    class Battery
    {
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType type;

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public double? HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }
    }
}