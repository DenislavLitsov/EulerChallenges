namespace Challenge1
{
    using Common;

    internal class Program
    {
        static int[] possibleMultiples = new int[] { 3, 5 };
        static List<int> foundNumbers = new List<int>();
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % possibleMultiples[0] == 0 || i % possibleMultiples[1] == 0)
                {
                    foundNumbers.Add(i);
                }
            }

            Console.WriteLine(foundNumbers.TotalSum());
        }
    }
}