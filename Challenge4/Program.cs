using Common;

namespace Challenge4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int currentMaxPalidrome = 0;

            for (int number1 = 100; number1 < 1000; number1++)
            {
                for (int number2 = 100; number2 < 1000; number2++)
                {
                    int multiple = number1 * number2;
                    if (isPalidrome(multiple))
                    {
                        Console.WriteLine($"New Palindrome: {multiple}");
                        if (multiple > currentMaxPalidrome)
                        {
                            currentMaxPalidrome = multiple;
                            Console.WriteLine($"New Max Palindrome: {multiple}");
                        }
                    }
                }
            }

            Console.WriteLine($"Max palindrome: {currentMaxPalidrome}");
        }

        static bool isPalidrome(int number)
        {
            string stringified = number.ToString();
            if (stringified.Length % 2 != 0)
            {
                //Console.WriteLine("ITS NOT EVEN");
                return false;
            }

            int size = stringified.Length;
            string firstPart = stringified.Substring(0, size / 2);
            string secondPart = stringified.Substring((size / 2), size / 2);


            if (firstPart + secondPart != stringified)
            {
                throw new Exception("falsly divided");
            }

            string reversed = secondPart.ToCharArray().Reverse().Stringify();

            if (firstPart == reversed)
            {
                return true;
            }
            return false;
        }
    }
}