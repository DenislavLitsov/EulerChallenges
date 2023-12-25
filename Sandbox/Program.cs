using Common;
using System;

namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int index = 0; index < Constants.OneMilion; index++)
            {
                int result = index * (index + 1) / 2;
                Console.WriteLine($"Index: {index}, value: {result}");
                if (result < 0)
                {
                    break;
                }
            }
        }
    }
}