﻿using System.Numerics;

namespace Common
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

            for (long i = 2; i < (number / 2) + 1; i++)
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
    }
}