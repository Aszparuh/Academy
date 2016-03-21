namespace ASP.MVC.Infrastructure
{
    using Deveel.Math;

    public class BitCalculator
    {
        public BigDecimal ConvertToBit(string value, int type, int kiloValue)
        {
            BigDecimal kilo = kiloValue;
            BigDecimal valueAsNumber = BigDecimal.Parse(value);

            switch (type)
            {
                //case Bit-b
                case 0:
                    return valueAsNumber;
                //case Byte-B
                case 1:
                    return valueAsNumber / 8;
                //case Kilobit-Kb
                case 2:
                    return valueAsNumber / kilo;
                //case Kilobyte-KB
                case 3:
                    return (valueAsNumber / kilo) / 8;
                //case Megabit-Mb
                case 4:
                    return valueAsNumber / kilo * kilo;
                //case Megabyte-MB
                case 5:
                    return (valueAsNumber / kilo * kilo) / 8;
                //case Gigabit-Gb
                case 6:
                    return valueAsNumber / kilo * kilo * kilo;
                //case Gigabyte-GB
                case 7:
                    return (valueAsNumber / kilo * kilo * kilo) / 8;
                //case Terabit-Tb
                case 8:
                    return valueAsNumber / kilo * kilo * kilo * kilo;
                //case Terabyte-TB
                case 9:
                    return (valueAsNumber / kilo * kilo * kilo * kilo) / 8;
                //case Petabit-Pb
                case 10:
                    return valueAsNumber / kilo * kilo * kilo * kilo * kilo;
                //case Petabyte-PB
                case 11:
                    return (valueAsNumber / kilo * kilo * kilo * kilo * kilo) / 8;
                //case Exabit-Eb
                case 12:
                    return valueAsNumber / kilo * kilo * kilo * kilo * kilo * kilo;
                //case Exabyte-EB
                case 13:
                    return (valueAsNumber / kilo * kilo * kilo * kilo * kilo * kilo) / 8;
                //case Zettabit-Zb
                case 14: 
                    return valueAsNumber / kilo * kilo * kilo * kilo * kilo * kilo * kilo;
                //case Zettabyte-ZB
                case 15:
                    return (valueAsNumber / kilo * kilo * kilo * kilo * kilo * kilo * kilo) / 8;
                //case Yottabit-Yb
                case 16:
                    return valueAsNumber / kilo * kilo * kilo * kilo * kilo * kilo * kilo * kilo;
                //case Yottabyte-YB
                case 17:
                    return (valueAsNumber / kilo * kilo * kilo * kilo * kilo * kilo * kilo * kilo) / 8;
                default:
                    throw new System.Exception();
                    break;
            }
        }
    }
}
