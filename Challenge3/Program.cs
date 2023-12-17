using Common;

namespace Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = 600851475143;
            List<long> dividers = new List<long>();

            do
            {
                for (int i = 2; i < (number / 2) + 1; i++)
                {
                    if (number % i == 0)
                    {
                        dividers.Add(i);
                        number = number / i;
                        Console.WriteLine($"Number: {number}, divider: {i}");
                        break;
                    }
                }
            } while (number != 1);


            // 6857 is the answer
            dividers.Print();
        }
    }
}