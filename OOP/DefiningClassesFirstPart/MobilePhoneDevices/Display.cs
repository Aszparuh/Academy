using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevices
{
    class Display
    {
        private byte size;
        private uint numberOfColours;

        public Display()
        {

        }

        public Display(byte size)
        {
            this.Size = size;
        }

        public Display(uint number)
        {
            this.NumberOfColours = number;
        }

        public Display(byte size, uint number)
        {
            this.Size = size;
            this.NumberOfColours = number;
        }

        //Properties
        /// <summary>
        /// Gets or sets the size of the display. 
        /// </summary>
        public byte Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        /// <summary>
        /// Gets or sets the number of the colours. 
        /// </summary>
        public uint NumberOfColours
        {
            get { return this.numberOfColours; }
            set { this.numberOfColours = value; }
        }
    }
}