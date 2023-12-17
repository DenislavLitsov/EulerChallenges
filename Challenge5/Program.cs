using Common;

namespace Challenge5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (IsRight(i))
                {
                    Console.WriteLine($"Answer is: {i}");
                    break;
                }
            }
        }

        public static bool IsRight(int x)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (x % i != 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}