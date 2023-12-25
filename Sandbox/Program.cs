using Common;
using System;

namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (long index = 0; index < long.MaxValue; index++)
            {
                long result = index * (index + 1) / 2;
                if (result < 0)
                {
                    Console.WriteLine($"Index: {index}, value: {result}");
                    break;
                }
            }
        }
    }
}