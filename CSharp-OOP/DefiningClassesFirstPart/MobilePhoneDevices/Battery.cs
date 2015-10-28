using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevices
{
    public class Battery
    {
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType type;

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, double? hoursIdle, double? hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.type = Type;
        }

        public Battery(string model, double? hoursIdle, double? hoursTalk, BatteryType type) 
            : this(model, hoursIdle, hoursTalk)
        {
            this.Type = type;
        }
      
        
        public string Model
        {
            get { return this.model; }
            set 
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("Invalid model.");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours Idle can not be negative.");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public double? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours Talk can not be negative.");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}