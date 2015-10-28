using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevices
{
    public class Display
    {
        private float? size;
        private uint numberOfColours;

        public Display(byte size)
        {
            this.Size = size;
        }

        public Display(uint number)
        {
            this.NumberOfColours = number;
        }

        public Display(float? size, uint number)
        {
            this.Size = size;
            this.NumberOfColours = number;
        }

        //Properties
        /// <summary>
        /// Gets or sets the size of the display. 
        /// </summary>
        public float? Size
        {
            get { return this.size; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid size for the Display");
                }
                else
                {
                    this.size = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets the number of the colours. 
        /// </summary>
        public uint NumberOfColours
        {
            get { return this.numberOfColours; }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentException("Colours can not be less than two.");
                }
                else
                {
                    this.numberOfColours = value;
                }
            }
        }
    }
}