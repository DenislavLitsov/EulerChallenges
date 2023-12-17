using Common;

namespace Challenge9
{
    internal class Program
    {
        static void Main()
        {
            for (int a = 0; a < 1000; a++)
            {
                for (int b = a + 1; b < 1000; b++)
                {
                    for (int c = b + 1; c < 1000; c++)
                    {
                        if (a + b + c != 1000)
                        {
                            continue;
                        }

                        int product1 = a * a + b * b;
                        int product2 = c * c;

                        if (product1 != product2)
                        {
                            continue;
                        }

                        Console.WriteLine($"Triplets: {a}, {b}, {c}");
                        Console.WriteLine($"Product: {a * b * c}");
                    }
                }
            }
        }
    }
}