using Common;
using Common.NumberSequences;
using System;

namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr= new StreamReader("Data/Primes/Primes_105.txt"))
            {
                var line = sr.ReadLine();
                Console.WriteLine(line.Split(',').Length);
            }

            int theoreticalAll = (105 * Constants.OneMilion) + 97565;

            PrimeSequenceGenerator primeSequenceGenerator = new PrimeSequenceGenerator(0, 105097565);
        }
    }
}