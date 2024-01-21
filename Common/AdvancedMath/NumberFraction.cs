using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Common.AdvancedMath
{
    public class NumberFraction
    {
        private BigInteger number;
        private BigInteger denominator;

        public NumberFraction(BigInteger number, BigInteger denominator)
        {
            this.Number = number;
            this.Denominator = denominator;
        }

        public NumberFraction(BigInteger number)
        {
            this.Number = number;
            this.Denominator = 1;
        }

        /// <summary>
        /// Number Above fraction line
        /// </summary>
        public BigInteger Number
        {
            get => number;
            set
            {
                if (value < 0)
                    throw new NotSupportedException("Values cannot be below 0! Add another bool flag to indicate if number is minus. Probably overflow");

                this.number = value;
            }
        }

        /// <summary>
        /// Number Below fraction line
        /// </summary>
        public BigInteger Denominator
        {
            get => denominator; 
            set
            {
                if (value < 1)
                    throw new NotSupportedException("Values cannot be below 0 or equal to 0 because we will be deviding by zero! Add another bool flag to indicate if number is minus. Probably overflow");

                denominator = value;
            }
        }

        public static NumberFraction operator +(NumberFraction mainNumber, NumberFraction secondNumber)
        {
            if (mainNumber.Denominator != secondNumber.Denominator)
            {
                var denom1 = mainNumber.Denominator;
                var denom2 = secondNumber.Denominator;

                mainNumber.Denominator *= denom2;
                mainNumber.Number *= denom2;

                secondNumber.Denominator *= denom1;
                secondNumber.Number *= denom1;
            }

            var newNum = mainNumber.Number + secondNumber.Number;
            var denom = mainNumber.Denominator;

            var newFraction = new NumberFraction(newNum, denom);

            return newFraction;
        }

        public static NumberFraction operator -(NumberFraction mainNumber, NumberFraction secondNumber)
        {
            throw new NotImplementedException();
        }

        public static NumberFraction operator /(NumberFraction mainNumber, NumberFraction secondNumber)
        {
            var reversedNumber = secondNumber.Reverse();
            var result = mainNumber * reversedNumber;
            return result;
        }

        public static NumberFraction operator *(NumberFraction mainNumber, NumberFraction secondNumber)
        {
            var result = new NumberFraction(mainNumber.Number * secondNumber.Number, mainNumber.Denominator * secondNumber.Denominator);
            return result;
        }

        public static NumberFraction operator +(NumberFraction mainNumber, long secondNumber)
        {
            var secondNumberAsFraction = new NumberFraction(secondNumber * mainNumber.denominator, mainNumber.denominator);
            var result = mainNumber + secondNumberAsFraction;
            return result;
        }

        public static NumberFraction operator -(NumberFraction mainNumber, long secondNumber)
        {
            throw new NotImplementedException();
        }

        public static NumberFraction operator /(NumberFraction mainNumber, long secondNumber)
        {
            var parsedNumber = new NumberFraction(secondNumber * mainNumber.Denominator, mainNumber.Denominator);
            var result = mainNumber / parsedNumber;
            return result;
        }

        public static NumberFraction operator *(NumberFraction mainNumber, long secondNumber)
        {
            throw new NotImplementedException();
        }

        public static NumberFraction operator +(NumberFraction mainNumber, int secondNumber)
        {
            var secondNumberAsFraction = new NumberFraction(secondNumber * mainNumber.denominator, mainNumber.denominator);
            var result = mainNumber + secondNumberAsFraction;
            return result;
        }

        public static NumberFraction operator -(NumberFraction mainNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static NumberFraction operator /(NumberFraction mainNumber, int secondNumber)
        {
            var parsedNumber = new NumberFraction(secondNumber * mainNumber.Denominator, mainNumber.Denominator);
            var result = mainNumber / parsedNumber;
            return result;
        }

        public static NumberFraction operator *(NumberFraction mainNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{this.Number}/{this.Denominator}";
        }

        public void ScaleDown()
        {
            BigInteger smallerNum = this.Number < this.Denominator ? this.Number : this.Denominator;

            for (int i = 2; i <= smallerNum / 2; i++)
            {
                if (this.Number % i == 0 && this.Denominator % i == 0)
                {
                    this.Number /= i;
                    this.Denominator /= i;

                    // Reset the cycle
                    i = 2;
                }
            }

            if (this.Denominator % this.Number == 0)
            {
                this.Number /= this.Number;
                this.Denominator /= this.Number;
            }
        }

        /// <summary>
        /// Returns new Number!
        /// </summary>
        /// <returns></returns>
        public NumberFraction Reverse()
        {
            return new NumberFraction(this.Denominator, this.Number);
        }
    }
}
