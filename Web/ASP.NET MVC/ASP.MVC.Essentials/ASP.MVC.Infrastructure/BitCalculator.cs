namespace ASP.MVC.Infrastructure
{
    using System;

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
                    throw new System.Exception("Something went wrong ConvertToBit");
                    break;
            }
        }

        public string Calculate(int type, int kiloValue, string quantity)
        {
            BigDecimal result;
            BigDecimal quantityAsNumber = BigDecimal.Parse(quantity);

            switch (type)
            {
                //case Bit-b
                case 0:
                    result = quantityAsNumber;
                    break;
                //case Byte-B
                case 1:
                    result = quantityAsNumber / 8;
                    break;
                //case Kilobit-Kb
                case 2:
                    result = quantityAsNumber / kiloValue;
                    break;
                //case Kilobyte-KB
                case 3:
                    result = (quantityAsNumber / kiloValue) / 8;
                    break;
                //case Megabit-Mb
                case 4:
                    result = quantityAsNumber / kiloValue * kiloValue;
                    break;
                //case Megabyte-MB
                case 5:
                    result = (quantityAsNumber / kiloValue * kiloValue) / 8;
                    break;
                //case Gigabit-Gb
                case 6:
                    result = quantityAsNumber / kiloValue * kiloValue * kiloValue;
                    break;
                //case Gigabyte-GB
                case 7:
                    result = (quantityAsNumber / kiloValue * kiloValue * kiloValue) / 8;
                    break;
                //case Terabit-Tb
                case 8:
                    result = quantityAsNumber / kiloValue * kiloValue * kiloValue * kiloValue;
                    break;
                //case Terabyte-TB
                case 9:
                    result = (quantityAsNumber / kiloValue * kiloValue * kiloValue * kiloValue) / 8;
                    break;
                //case Petabit-Pb
                case 10:
                    result = quantityAsNumber / kiloValue * kiloValue * kiloValue * kiloValue * kiloValue;
                    break;
                //case Petabyte-PB
                case 11:
                    result = (quantityAsNumber / kiloValue * kiloValue * kiloValue * kiloValue * kiloValue) / 8;
                    break;
                //case Exabit-Eb
                case 12:
                    result = quantityAsNumber / kiloValue * kiloValue * kiloValue * kiloValue * kiloValue * kiloValue;
                    break;
                //case Exabyte-EB
                case 13:
                    result = (quantityAsNumber / kiloValue * kiloValue * kiloValue * kiloValue * kiloValue * kiloValue) / 8;
                    break;
                //case Zettabit-Zb
                case 14:
                    result = quantityAsNumber / kiloValue * kiloValue * kiloValue * kiloValue * kiloValue * kiloValue * kiloValue;
                    break;
                //case Zettabyte-ZB
                case 15:
                    result = (quantityAsNumber / kiloValue * kiloValue * kiloValue * kiloValue * kiloValue * kiloValue * kiloValue) / 8;
                    break;
                //case Yottabit-Yb
                case 16:
                    result = quantityAsNumber / kiloValue * kiloValue * kiloValue * kiloValue * kiloValue * kiloValue * kiloValue * kiloValue;
                    break;
                //case Yottabyte-YB
                case 17:
                    result = (quantityAsNumber / kiloValue * kiloValue * kiloValue * kiloValue * kiloValue * kiloValue * kiloValue * kiloValue) / 8;
                    break;
                default:
                    throw new System.Exception();
                    break;
            }

            return result.ToString();
        }

        private double Power(double a, int b)
        {
            if (b < 0)
            {
                throw new ApplicationException("B must be a positive integer or zero");
            }
            if (b == 0) return 1;
            if (a == 0) return 0;
            if (b % 2 == 0)
            {
                return Power(a * a, b / 2);
            }
            else if (b % 2 == 1)
            {
                return a * Power(a * a, b / 2);
            }
            return 0;
        }
    }
}
