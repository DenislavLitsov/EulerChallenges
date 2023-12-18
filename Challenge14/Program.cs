namespace Challenge14
{
    internal class Program
    {
        static void Main()
        {
            long bestNumber = 0;
            long bestIterations = 0;
            for (long i = 2; i < 1000000; i++)
            {
                long currNum = i;
                long totalIterations = 1;

                while (currNum != 1)
                {
                    totalIterations++;
                    currNum = GetNext(currNum);
                }

                if (totalIterations > bestIterations)
                {
                    bestIterations = totalIterations;
                    bestNumber = i;

                    Console.WriteLine($"New best iterations: {bestIterations}, number: {bestNumber}");
                }
            }

            Console.WriteLine("end");
        }

        static long  GetNext(long num)
        {
            if (num % 2 == 0)
            {
                return num / 2;
            }

            return (3 * num) + 1;
        }
    }
}