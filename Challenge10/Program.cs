using Common;

namespace Challenge10
{
    internal class Program
    {
        static void Main()
        {
            List<long> primes = new List<long>();
            for (int i = 2; i < 2000000; i++)
            {
                if (i.IsPrime())
                {
                    primes.Add(i);
                    if (primes.Count % 1000 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.WriteLine(primes.Sum());
        }
    }
}