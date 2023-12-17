namespace Common
{
    public static class AdvancedMath
    {
        public static bool IsPrime(this long number)
        {
            if (number == 2)
            {
                return true;
            }

            for (var i = 2; i < number / 2 + 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsPrime(this int number)
        {
            if (number == 2)
            {
                return true;
            }

            for (var i = 2; i < number / 2 + 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}