using System.Numerics;
using System.Runtime.CompilerServices;

namespace Common
{
    public class BigDecimal
    {
        private readonly int decimalCountPrecision;

        private BigInteger MainPart;
        private BigInteger DecimalPart;

        public BigDecimal(BigInteger mainPart, BigInteger decimalPart, int decimalCountPrecision)
        {
            this.MainPart = mainPart;
            this.DecimalPart = decimalPart;
            this.decimalCountPrecision = decimalCountPrecision;
        }

        public string Value
        {
            get
            {
                return MainPart.ToString() + "," + DecimalPart.ToString();
            }
        }

        public static BigDecimal operator /(BigDecimal mainNumber, BigDecimal secondNumber)
        {
            if (mainNumber.decimalCountPrecision != secondNumber.decimalCountPrecision)
            {
                throw new Exception("Algebra with numbers with different precision is not supported");
            }

            var parsedMain = mainNumber.ConvertedBigInteger();
            var parsedSecond = mainNumber.ConvertedBigInteger();

            int countOfMainAtStart = parsedMain.ToString().Length;
            int countOfSecondAtStart = parsedSecond.ToString().Length;

            var algebra = parsedMain / parsedSecond;
            var resultAsString = algebra.ToString();

            throw new NotImplementedException();
            return null;
        }

        public BigInteger ConvertedBigInteger()
        {
            BigInteger totalNumber = this.MainPart;
            BigInteger convertedDecimalPart = this.DecimalPart;
            if (this.DecimalPart > 0)
            {
                int timesToPow = this.decimalCountPrecision - convertedDecimalPart.ToString().Length;
                for (int i = 0; i < timesToPow; i++)
                {
                    convertedDecimalPart *= 10;
                }
            }
            for (int i = 0; i < this.decimalCountPrecision; i++)
            {
                totalNumber *= 10;
            }

            BigInteger result = totalNumber + convertedDecimalPart;
            return result;
        }
    }
}
