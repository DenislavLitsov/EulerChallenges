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

            for (long i = 1; i < (number / 2) + 1; i++)
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

            if (number == 1)
            {
                res.Add(1);
                return res;
            }

            for (int i = 1; i < (number / 2) + 1; i++)
            {
                if (number % i == 0)
                {
                    res.Add(i);
                }
            }

            return res;
        }
    }
}