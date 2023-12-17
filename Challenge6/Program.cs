namespace Challenge6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long sumOfSquares = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
            }


            long squareOfSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                squareOfSum += i;
            }

            squareOfSum *= squareOfSum;

            Console.WriteLine($"sumOfSquares: {sumOfSquares}");
            Console.WriteLine($"squareOfSum: {squareOfSum}");

            Console.WriteLine($"Difference: {squareOfSum - sumOfSquares}");
        }
    }
}