using Common;

namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fibonacciNumbers = new List<int>();
            List<int> foundNumbers = new List<int>();

            GenerateFibs(fibonacciNumbers);
            fibonacciNumbers.ForEach(fibonacci => { Console.WriteLine(fibonacci); });

            foundNumbers = fibonacciNumbers.Where(x => x % 2 == 0).ToList();
            Console.WriteLine(foundNumbers.Sum());
        }

        static void GenerateFibs(IList<int> container)
        {
            container.Add(1);
            container.Add(2);
            int currentFib = 3;
            do
            {
                container.Add(currentFib);

                currentFib += container[container.Count - 2];
            } while (currentFib <= 4000000);
        }
    }
}