namespace ASP.MVC.Infrastructure
{
    using System;

    using Deveel.Math;

    public class BitCalculator
    {
        public string ConvertToBits(int type, int kiloValue, string quantity)
        {
            BigDecimal kilo;
            BigDecimal result;
            BigDecimal valueAsNumber = BigDecimal.Parse(quantity);
            if (kiloValue == 0)
            {
                kilo = 1024;
            }
            else
            {
                kilo = 1000;
            }

            switch (type)
            {
                //case Bit-b
                case 0:
                    result = valueAsNumber;
                    break;
                //case Byte-B
                case 1:
                    result = valueAsNumber.Divide(8);
                    break;
                //case Kilobit-Kb
                case 2:
                    result = valueAsNumber.Divide(kilo);
                    break;
                //case Kilobyte-KB
                case 3:
                    result = (valueAsNumber.Divide(kilo)).Divide(8);
                    break;
                //case Megabit-Mb
                case 4:
                    result = valueAsNumber.Divide(Power(kilo, 2));
                    break;
                //case Megabyte-MB
                case 5:
                    result = (valueAsNumber.Divide(Power(kilo, 2))).Divide(8);
                    break;
                //case Gigabit-Gb
                case 6:
                    result = valueAsNumber.Divide(Power(kilo, 3));
                    break;
                //case Gigabyte-GB
                case 7:
                    result = (valueAsNumber.Divide(Power(kilo, 3))).Divide(8);
                    break;
                //case Terabit-Tb
                case 8:
                    result = valueAsNumber.Divide(Power(kilo, 4));
                    break;
                //case Terabyte-TB
                case 9:
                    result = (valueAsNumber.Divide(Power(kilo, 4))).Divide(8);
                    break;
                //case Petabit-Pb
                case 10:
                    result = valueAsNumber.Divide(Power(kilo, 5));
                    break;
                //case Petabyte-PB
                case 11:
                    result = (valueAsNumber.Divide(Power(kilo, 5))).Divide(8);
                    break;
                //case Exabit-Eb
                case 12:
                    result = valueAsNumber.Divide(Power(kilo, 6));
                    break;
                //case Exabyte-EB
                case 13:
                    result = (valueAsNumber.Divide(Power(kilo, 6))).Divide(8);
                    break;
                //case Zettabit-Zb
                case 14:
                    result = valueAsNumber.Divide(Power(kilo, 7));
                    break;
                //case Zettabyte-ZB
                case 15:
                    result = (valueAsNumber.Divide(Power(kilo, 7))).Divide(8);
                    break;
                //case Yottabit-Yb
                case 16:
                    result = valueAsNumber.Divide(Power(kilo, 8));
                    break;
                //case Yottabyte-YB
                case 17:
                    result = (valueAsNumber.Divide(Power(kilo, 8))).Divide(8);
                    break;
                default:
                    throw new System.Exception("Something went wrong ConvertToBit");
                    break;
            }

            return result.ToString();
        }

        public string ConvertFromBits(int type, int kiloValue, string quantity)
        {
            BigDecimal result;
            BigDecimal kilo;
            BigDecimal quantityAsNumber = BigDecimal.Parse(quantity);
            if (kiloValue == 0)
            {
                kilo = 1024;
            }
            else
            {
                kilo = 1000;
            }
            
            switch (type)
            {
                //case Bit-b
                case 0:
                    result = quantityAsNumber;
                    break;
                //case Byte-B
                case 1:
                    result = quantityAsNumber.Multiply(8);
                    break;
                //case Kilobit-Kb
                case 2:
                    result = quantityAsNumber.Multiply(kilo);
                    break;
                //case Kilobyte-KB
                case 3:
                    result = (quantityAsNumber.Multiply(kilo)).Multiply(8);
                    break;
                //case Megabit-Mb
                case 4:
                    result = quantityAsNumber.Multiply(Power(kilo, 2));
                    break;
                //case Megabyte-MB
                case 5:
                    result = (quantityAsNumber.Multiply(Power(kilo, 2))).Multiply(8);
                    break;
                //case Gigabit-Gb
                case 6:
                    result = quantityAsNumber.Multiply(Power(kilo, 3));
                    break;
                //case Gigabyte-GB
                case 7:
                    result = (quantityAsNumber.Multiply(Power(kilo, 3))).Multiply(8);
                    break;
                //case Terabit-Tb
                case 8:
                    result = quantityAsNumber.Multiply(Power(kilo, 4));
                    break;
                //case Terabyte-TB
                case 9:
                    result = (quantityAsNumber.Multiply(Power(kilo, 4))).Multiply(8);
                    break;
                //case Petabit-Pb
                case 10:
                    result = quantityAsNumber.Multiply(Power(kilo, 5));
                    break;
                //case Petabyte-PB
                case 11:
                    result = (quantityAsNumber.Multiply(Power(kilo, 5))).Multiply(8);
                    break;
                //case Exabit-Eb
                case 12:
                    result = quantityAsNumber.Multiply(Power(kilo, 6));
                    break;
                //case Exabyte-EB
                case 13:
                    result = (quantityAsNumber.Multiply(Power(kilo, 6))).Multiply(8);
                    break;
                //case Zettabit-Zb
                case 14:
                    result = quantityAsNumber.Multiply(Power(kilo, 7));
                    break;
                //case Zettabyte-ZB
                case 15:
                    result = (quantityAsNumber.Multiply(Power(kilo, 7))).Multiply(8);
                    break;
                //case Yottabit-Yb
                case 16:
                    result = quantityAsNumber.Multiply(Power(kilo, 8));
                    break;
                //case Yottabyte-YB
                case 17:
                    result = (quantityAsNumber.Multiply(Power(kilo, 8))).Multiply(8);
                    break;
                default:
                    throw new System.Exception();
                    break;
            }

            return result.ToString();
        }

        private BigDecimal Power(BigDecimal a, int b)
        {
            if (b < 0)
            {
                throw new ApplicationException("B must be a positive integer or zero");
            }
            if (b == 0) return 1;
            if (a == 0) return 0;
            if (b % 2 == 0)
            {
                return Power(a.Multiply(a), b / 2);
            }
            else if (b % 2 == 1)
            {
                return a.Multiply(Power(a.Multiply(a), b / 2));
            }
            return 0;
        }
    }
}
