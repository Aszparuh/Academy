namespace ASP.MVC.Infrastructure
{
    using System;

    using Deveel.Math;

    public class BitCalculator
    {
        public string ConvertToBits(string value, int type, int kiloValue)
        {
            BigDecimal kilo;
            BigDecimal valueAsNumber = new BigDecimal(int.Parse(value));
            BigDecimal result;
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
                    result = valueAsNumber.Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Byte-B
                case 1:
                    result = valueAsNumber.Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Kilobit-Kb
                case 2:
                    result = valueAsNumber.Divide(kilo).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Kilobyte-KB
                case 3:
                    result = (valueAsNumber.Divide(kilo)).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Megabit-Mb
                case 4:
                    result = valueAsNumber.Divide(Power(kilo, 2)).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Megabyte-MB
                case 5:
                    result = (valueAsNumber.Divide(Power(kilo, 2))).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Gigabit-Gb
                case 6:
                    result = valueAsNumber.Divide(Power(kilo, 3)).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Gigabyte-GB
                case 7:
                    result = (valueAsNumber.Divide(Power(kilo, 3))).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Terabit-Tb
                case 8:
                    result = valueAsNumber.Divide(Power(kilo, 4)).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Terabyte-TB
                case 9:
                    result = (valueAsNumber.Divide(Power(kilo, 4))).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Petabit-Pb
                case 10:
                    result = valueAsNumber.Divide(Power(kilo, 5)).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Petabyte-PB
                case 11:
                    result = (valueAsNumber.Divide(Power(kilo, 5))).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Exabit-Eb
                case 12:
                    result = valueAsNumber.Divide(Power(kilo, 6)).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Exabyte-EB
                case 13:
                    result = (valueAsNumber.Divide(Power(kilo, 6))).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Zettabit-Zb
                case 14:
                    result = valueAsNumber.Divide(Power(kilo, 7)).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Zettabyte-ZB
                case 15:
                    result = (valueAsNumber.Divide(Power(kilo, 7))).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Yottabit-Yb
                case 16:
                    result = valueAsNumber.Divide(Power(kilo, 8)).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Yottabyte-YB
                case 17:
                    result = (valueAsNumber.Divide(Power(kilo, 8))).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                default:
                    throw new System.Exception("Something went wrong ConvertToBit");
                    break;
            }

            return result.ToString();
        }

        public string Calculate(int type, int kiloValue, string quantity)
        {
            BigDecimal result;
            BigDecimal quantityAsNumber = BigDecimal.Parse(quantity);
            BigDecimal kilo;
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
                    result = quantityAsNumber.Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Byte-B
                case 1:
                    result = quantityAsNumber.Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Kilobit-Kb
                case 2:
                    result = quantityAsNumber.Divide(kilo).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Kilobyte-KB
                case 3:
                    result = (quantityAsNumber.Divide(kilo)).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Megabit-Mb
                case 4:
                    result = quantityAsNumber.Divide(Power(kilo, 2)).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Megabyte-MB
                case 5:
                    result = (quantityAsNumber.Divide(Power(kilo, 2))).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Gigabit-Gb
                case 6:
                    result = quantityAsNumber.Divide(Power(kilo, 3)).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Gigabyte-GB
                case 7:
                    result = (quantityAsNumber.Divide(Power(kilo, 3))).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Terabit-Tb
                case 8:
                    result = quantityAsNumber.Divide(Power(kilo, 4)).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Terabyte-TB
                case 9:
                    result = (quantityAsNumber.Divide(Power(kilo, 4))).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Petabit-Pb
                case 10:
                    result = quantityAsNumber.Divide(Power(kilo, 5)).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Petabyte-PB
                case 11:
                    result = (quantityAsNumber.Divide(Power(kilo, 5))).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Exabit-Eb
                case 12:
                    result = quantityAsNumber.Divide(Power(kilo, 6)).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Exabyte-EB
                case 13:
                    result = (quantityAsNumber.Divide(Power(kilo, 6))).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Zettabit-Zb
                case 14:
                    result = quantityAsNumber.Divide(Power(kilo, 7)).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Zettabyte-ZB
                case 15:
                    result = (quantityAsNumber.Divide(Power(kilo, 7))).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Yottabit-Yb
                case 16:
                    result = quantityAsNumber.Divide(Power(kilo, 8)).Round(new MathContext(4, RoundingMode.HalfUp));
                    break;
                //case Yottabyte-YB
                case 17:
                    result = (quantityAsNumber.Divide(Power(kilo, 8))).Divide(8).Round(new MathContext(4, RoundingMode.HalfUp));
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
