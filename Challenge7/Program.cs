using Common;

namespace Challenge7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<long> primes = new List<long>();
            for (long i = 3; i < long.MaxValue; i += 2)
            {
                if (i.IsPrime())
                {
                    primes.Add(i);

                    Console.WriteLine($"New prime: {i}, TotalSize: {primes.Count}");
                }

                if (primes.Count == 10001)
                {
                    break;
                }
            }

            Console.WriteLine("Result: ");
            Console.WriteLine(primes.Last());
        }
    }
}