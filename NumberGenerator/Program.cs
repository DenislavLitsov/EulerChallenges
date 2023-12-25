using Common;

namespace NumberGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int>();
            int milionCount = 0;

            primes.Add(2);
            for (long i = 3; i <= int.MaxValue; i += 2)
            {
                if (i.IsPrime())
                {
                    primes.Add((int)i);

                    if (primes.Count % 1000000 == 0)
                    {
                        WritePrimes(primes, milionCount);
                        primes = new List<int>();
                        milionCount++;
                        Console.WriteLine($"Curr index: {i}, left: {int.MaxValue - i}, Found primes: {milionCount}");
                    }
                }
            }

            WritePrimes(primes, milionCount);
        }

        static void WritePrimes(List<int> primes, int milionIndex)
        {
            using (StreamWriter sw = new StreamWriter($"Primes_{milionIndex}.txt"))
            {
                sw.Write(primes[0]);
                for (int i = 1; i < primes.Count; i++)
                {
                    sw.Write("," + primes[i]);
                }

                sw.Flush();
            }
        }
    }
}