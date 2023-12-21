using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;

namespace Common
{
    public class BigDecimal : IComparable, IEquatable<BigDecimal>
    {
        private readonly int decimalCountPrecision;

        private BigInteger MainPart;
        private BigInteger DecimalPart;
        private int DecimalLeftZeros;

        public BigDecimal(BigInteger mainPart, BigInteger decimalPart, int decimalLeftZeros, int decimalCountPrecision)
        {
            this.MainPart = mainPart;
            this.DecimalPart = decimalPart;
            this.DecimalLeftZeros = decimalLeftZeros;
            this.decimalCountPrecision = decimalCountPrecision;
        }

        public string Value
        {
            get
            {
                StringBuilder sb = new StringBuilder(MainPart.ToString());
                sb.Append(",");
                for (int i = 0; i < this.DecimalLeftZeros; i++)
                {
                    sb.Append("0");
                }
                sb.Append(DecimalPart.ToString());
                return sb.ToString();
            }
        }

        public bool Equals(BigDecimal? other)
        {
            return this.CompareTo(other) == 0;
        }

        public int CompareTo(object? obj)
        {
            if (obj is not BigDecimal)
            {
                throw new Exception("Comparisions are supported only between BigDecimals");
            }

            var secondBigDecimal = obj as BigDecimal;

            AssertBigDecimalsHaveSamePrecision(this, secondBigDecimal);

            if (this.MainPart == secondBigDecimal.MainPart)
            {
                var comparePart1 = this.UpScaleDecimalPart();
                var comparePart2 = secondBigDecimal.UpScaleDecimalPart();

                if (comparePart1 == comparePart2)
                {
                    return 0;
                }
                else if (comparePart1 > comparePart2)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (this.MainPart > secondBigDecimal.MainPart)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        public static bool operator ==(BigDecimal mainNumber, BigDecimal secondNumber)
        {
            int res = mainNumber.CompareTo(secondNumber);
            if (res == 0)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(BigDecimal mainNumber, BigDecimal secondNumber)
        {
            int res = mainNumber.CompareTo(secondNumber);
            if (res == 0)
            {
                return false;
            }

            return true;
        }

        public static bool operator <(BigDecimal mainNumber, BigDecimal secondNumber)
        {
            int res = mainNumber.CompareTo(secondNumber);
            if (res < 0)
            {
                return true;
            }

            return false;
        }

        public static bool operator >(BigDecimal mainNumber, BigDecimal secondNumber)
        {
            int res = mainNumber.CompareTo(secondNumber);
            if (res > 0)
            {
                return true;
            }

            return false;
        }

        public static BigDecimal operator +(BigDecimal mainNumber, BigDecimal secondNumber)
        {
            AssertBigDecimalsHaveSamePrecision(mainNumber, secondNumber);

            BigInteger newMainPart = mainNumber.MainPart + secondNumber.MainPart;
            BigInteger newDecimalPart = 0;
            int leftZeros = 0;

            BigInteger decimalPart1 = mainNumber.DecimalPart;
            BigInteger decimalPart2 = secondNumber.DecimalPart;

            if (decimalPart1 == 0)
            {
                newDecimalPart = secondNumber.DecimalPart;
                leftZeros = secondNumber.DecimalLeftZeros;
            }
            else if (decimalPart2 == 0)
            {
                newDecimalPart = mainNumber.DecimalPart;
                leftZeros = mainNumber.DecimalLeftZeros;
            }
            else if (decimalPart1.ToString().Length == decimalPart2.ToString().Length &&
                mainNumber.DecimalLeftZeros == secondNumber.DecimalLeftZeros)
            {
                // Just sum them
                var sum = decimalPart1 + decimalPart2;
                leftZeros = mainNumber.DecimalLeftZeros;
                if (sum.ToString().Length > decimalPart1.ToString().Length)
                {
                    // add 1 to main or leftZeros
                    if (leftZeros > 0)
                    {
                        newDecimalPart = sum;
                        leftZeros--;
                    }
                    else
                    {
                        newMainPart++;
                        string sumAsString = sum.ToString();

                        BigInteger toRemove = 1;
                        for (int i = 1; i < sumAsString.Length; i++)
                        {
                            toRemove *= 10;
                        }

                        newDecimalPart = sum - toRemove;
                    }
                }
                else
                {
                    newDecimalPart = sum;
                    leftZeros = mainNumber.DecimalLeftZeros;
                }
            }
            else
            {
                decimalPart1 = mainNumber.UpScaleDecimalPart();
                decimalPart2 = secondNumber.UpScaleDecimalPart();

                int decimalPart1Length = decimalPart1.ToString().Length;
                int decimalPart2Length = decimalPart2.ToString().Length;

                int biggerDecimalPart = decimalPart1Length > decimalPart2Length ?
                    decimalPart1Length : decimalPart2Length;

                var sum = decimalPart1 + decimalPart2;

                leftZeros = mainNumber.DecimalLeftZeros < secondNumber.DecimalLeftZeros ?
                    mainNumber.DecimalLeftZeros : secondNumber.DecimalLeftZeros;

                //int biggerLeftZeros = mainNumber.DecimalLeftZeros > secondNumber.DecimalLeftZeros ?
                //    mainNumber.DecimalLeftZeros : secondNumber.DecimalLeftZeros;

                var sumAsString = sum.ToString();
                if (sumAsString.Length > biggerDecimalPart)
                {
                    if (leftZeros > 0)
                    {
                        leftZeros--;
                        newDecimalPart = sum;
                    }
                    else
                    {
                        newMainPart++;

                        BigInteger toRemove = 1;
                        for (int i = 1; i < sumAsString.Length; i++)
                        {
                            toRemove *= 10;
                        }

                        if (sum.ToString()[1] == '0')
                        {
                            leftZeros++;
                        }
                        newDecimalPart = sum - toRemove;
                    }
                }
                else
                {
                    newDecimalPart = sum;
                }
            }


            return new BigDecimal(newMainPart, newDecimalPart, leftZeros, mainNumber.decimalCountPrecision);

        }
        public static BigDecimal operator -(BigDecimal mainNumber, BigDecimal secondNumber)
        {
            if (secondNumber > mainNumber)
            {
                throw new NotSupportedException("Not supported substraction with bigger second value. Because value will be less then 0");
            }

            BigInteger newMainPart = mainNumber.MainPart - secondNumber.MainPart;
            BigInteger newDecimalPart = 0;
            int leftZeros = 0;

            BigInteger decimalPart1 = mainNumber.UpScaleDecimalPart();
            BigInteger decimalPart2 = secondNumber.UpScaleDecimalPart();

            if (decimalPart2 > decimalPart1)
            {
                newMainPart--;

                var fixDecimal = new BigDecimal(0, 1, 0, mainNumber.decimalCountPrecision);
                var toAdd = fixDecimal.UpScaleDecimalPart() * 10;
                decimalPart1 += toAdd;

                newDecimalPart = decimalPart1 - decimalPart2;
                int difference = mainNumber.decimalCountPrecision - newDecimalPart.ToString().Length;
                leftZeros = difference;
            }
            else
            {
                newDecimalPart = decimalPart1 - decimalPart2;

                int difference = mainNumber.decimalCountPrecision - newDecimalPart.ToString().Length;
                leftZeros = difference;
            }

            return new BigDecimal(newMainPart, newDecimalPart, leftZeros, mainNumber.decimalCountPrecision);

        }
        public static BigDecimal operator *(BigDecimal mainNumber, BigDecimal secondNumber)
        {
            BigInteger newMainPart = 0;
            BigInteger newDecimalPart = 0;
            int leftZeros = 0;

            //int decimalPart = 0;
            StringBuilder fullNumber1 = new StringBuilder(mainNumber.MainPart.ToString());
            StringBuilder fullNumber2 = new StringBuilder(secondNumber.MainPart.ToString());

            int totalZeros = 0;
            int totalZeros1 = 0;
            int totalZeros2 = 0;

            if (mainNumber.DecimalPart != 0)
            {
                totalZeros1 = mainNumber.DecimalLeftZeros + mainNumber.DecimalPart.ToString().Length;
                totalZeros += totalZeros1;
            }
            if (secondNumber.DecimalPart != 0)
            {
                totalZeros2 = secondNumber.DecimalLeftZeros + secondNumber.DecimalPart.ToString().Length;
                totalZeros += totalZeros2;
            }

            if (mainNumber.DecimalPart > 0)
            {
                BigInteger decimalPart1 = mainNumber.UpScaleDecimalPart(totalZeros - mainNumber.DecimalLeftZeros);
                if (mainNumber.DecimalLeftZeros > 0)
                {
                    int count = mainNumber.DecimalLeftZeros;
                    for (int i = 0; i < count; i++)
                    {
                        fullNumber1.Append("0");
                    }
                }
                fullNumber1.Append(decimalPart1.ToString());
            }

            if (secondNumber.DecimalPart > 0)
            {
                BigInteger decimalPart2 = secondNumber.UpScaleDecimalPart(totalZeros - secondNumber.DecimalLeftZeros);
                if (secondNumber.DecimalLeftZeros > 0)
                {
                    int count = secondNumber.DecimalLeftZeros;
                    for (int i = 0; i < count; i++)
                    {
                        fullNumber2.Append("0");
                    }
                }
                fullNumber2.Append(decimalPart2.ToString());
            }

            BigInteger parsedNumber1 = BigInteger.Parse(fullNumber1.ToString());
            BigInteger parsedNumber2 = BigInteger.Parse(fullNumber2.ToString());

            BigInteger fullNumber = parsedNumber1 * parsedNumber2;

            string fullNumberAsString = fullNumber.ToString();
            if (totalZeros1 != 0 && totalZeros2 != 0)
            {
                totalZeros *= 2;
            }
            int mainPartCount = fullNumberAsString.Length - totalZeros;
            string newMainPartAsString = fullNumberAsString.Substring(0, mainPartCount);

            string fullDecimalPart = fullNumberAsString.Substring(mainPartCount, totalZeros);
            int startingZeroCount = 0;
            for (int i = 0; i < fullDecimalPart.Length; i++)
            {
                if (fullDecimalPart[i] == '0')
                {
                    startingZeroCount++;
                }
                else
                {
                    break;
                }
            }

            string fullDecimalPartAsString = fullDecimalPart.ToString();
            if (fullDecimalPartAsString == string.Empty)
            {
                fullDecimalPartAsString = "0";
            }

            newMainPart = BigInteger.Parse(newMainPartAsString);
            newDecimalPart = BigInteger.Parse(fullDecimalPartAsString);

            string newDecimalPartAsString = newDecimalPart.ToString();
            if (newDecimalPartAsString.Length > mainNumber.decimalCountPrecision)
            {
                newDecimalPart = BigInteger.Parse(newDecimalPartAsString.Substring(0, mainNumber.decimalCountPrecision - startingZeroCount));
            }

            leftZeros = startingZeroCount;

            var result = new BigDecimal(newMainPart, newDecimalPart, leftZeros, mainNumber.decimalCountPrecision);
            return result;
        }

        public static BigDecimal operator /(BigDecimal mainNumber, BigDecimal secondNumber)
        {
            throw new NotImplementedException();
        }

        private static void AssertBigDecimalsHaveSamePrecision(BigDecimal bigDecimal1, BigDecimal bigDecimal2)
        {
            if (bigDecimal1.decimalCountPrecision != bigDecimal2.decimalCountPrecision)
            {
                throw new Exception("Not supported difference in Decimal Precision");
            }
        }

        private BigInteger UpScaleDecimalPart(int digitsNeeded = 0)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.DecimalPart.ToString());
            int upscaleCount = this.decimalCountPrecision - this.DecimalLeftZeros - stringBuilder.Length;

            if (digitsNeeded != 0)
            {
                upscaleCount = digitsNeeded - stringBuilder.Length;
                if (upscaleCount < 0)
                {
                    throw new Exception();
                }
            }

            for (int i = 0; i < upscaleCount; i++)
            {
                stringBuilder.Append("0");
            }

            return BigInteger.Parse(stringBuilder.ToString());
        }
    }
}
