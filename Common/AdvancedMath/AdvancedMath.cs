using System;
using System.Numerics;

namespace Common.AdvancedMath
{
    public static class AdvancedMath
    {
        public static bool IsPrime(this long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static bool IsPrime(this int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static IEnumerable<long> GetAllDivisorsExcludingSameNumber(this long number)
        {
            List<long> res = new List<long>();

            res.Add(1);

            long max = (number / 2) + 1;
            for (long i = 2; i < max; i++)
            {
                if (number % i == 0)
                {
                    res.Add(i);
                }
            }

            return res;
        }

        public static IEnumerable<int> GetAllDivisorsExcludingSameNumber(this int number)
        {
            List<int> res = new List<int>();

            res.Add(1);

            for (int i = 2; i < (number / 2) + 1; i++)
            {
                if (number % i == 0)
                {
                    res.Add(i);
                }
            }

            return res;
        }

        public static BigInteger HighestCommonFactor(this BigInteger number, BigInteger number2)
        {
            var smallerNum = number < number2 ? number : number2;

            for (BigInteger i = smallerNum - 1; i > 0; i--)
            {
                if (number % i == 0 && number2 % i == 0)
                {
                    return i;
                }
            }

            return 1;
        }
        
        public static int HighestCommonFactor(this double number, double number2)
        {
            int num1 = (int)number;
            int num2 = (int)number2;
            var smallerNum = num1 < num2 ? num1 : num2;

            for (int i = smallerNum - 1; i > 0; i--)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    return i;
                }
            }

            return 1;
        }
        
        public static bool HasCommonFactorExcept1(this double number, double number2)
        {
            int num1 = (int)number;
            int num2 = (int)number2;
            var smallerNum = num1 < num2 ? num1 : num2;

            for (int i = 2; i <= smallerNum; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    return true;
                }
            }

            return false;
        }
        
        public static bool HasCommonFactorExcept1(this int num1, int num2)
        {
            var smallerNum = num1 < num2 ? num1 : num2;

            for (int i = 2; i <= smallerNum; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    return true;
                }
            }

            return false;
        }
        
        public static BigInteger BigPower(this long number, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            if (power < 0)
            {
                throw new NotImplementedException();
            }

            BigInteger result = number;
            for (int i = 0; i < power - 1; i++)
            {
                result *= number;
            }

            return result;
        }

        public static BigInteger BigPower(this int number, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            if (power < 0)
            {
                throw new NotImplementedException();
            }

            BigInteger result = number;
            for (int i = 0; i < power - 1; i++)
            {
                result *= number;
            }

            return result;
        }

        public static BigInteger BigPower(this BigInteger number, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            if (power < 0)
            {
                throw new NotImplementedException();
            }

            BigInteger result = number;
            for (int i = 0; i < power - 1; i++)
            {
                result *= number;
            }

            return result;
        }

        public static int Factorial(this int number)
        {
            int result = 1;
            for (int i = number; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
        public static long Factorial(this long number)
        {
            long result = 1;
            for (long i = number; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
        public static BigInteger Factorial(this BigInteger number)
        {
            BigInteger result = 1;
            for (BigInteger i = number; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }

        public static bool IsPandigital(this long number)
        {
            string numberAsString = number.ToString();
            for (int j = 0; j < numberAsString.Length; j++)
            {
                if (numberAsString.Contains(((char)(j + 48))) == false)
                {
                    return false;
                }
            }

            return true;
        }
        public static bool IsPandigital(this int number)
        {
            string numberAsString = number.ToString();
            for (int j = 0; j < numberAsString.Length; j++)
            {
                if (numberAsString.Contains(((char)(j + 48))) == false)
                {
                    return false;
                }
            }

            return true;
        }
        public static bool IsPandigital(this BigInteger number)
        {
            string numberAsString = number.ToString();
            for (int j = 0; j < numberAsString.Length; j++)
            {
                if (numberAsString.Contains(((char)(j + 48))) == false)
                {
                    return false;
                }
            }

            return true;
        }

        public static BigInteger RemoveRightZeros(this BigInteger integer)
        {
            BigInteger result = integer;
            while (result % 10 == 0)
            {
                result /= 10;
            }

            return result;
        }

        public static BigInteger GetBigCombination(long totalNumbers, long totalTakeNumbers)
        {
            if (totalTakeNumbers > totalNumbers)
            {
                throw new Exception("totalTakeNumbers cannot be bigger than totalNumbers");
            }

            BigInteger n = totalNumbers;
            BigInteger r = totalTakeNumbers;
            BigInteger nMinusR = n - r;

            BigInteger factorialN = n.Factorial();
            BigInteger factorialR = r.Factorial();
            BigInteger factorialNMinusR = nMinusR.Factorial();

            BigInteger result = factorialN / (factorialR * factorialNMinusR);
            return result;
        }
    }
}