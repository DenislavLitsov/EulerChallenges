using Common;
using Common.Combinatorics;
using System;

namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> possibleValues = new List<int>() { 1, 2, 3, 4, 5 };

            CombinatoricsEngine<int> engine1 = new CombinatoricsEngine<int>(null, possibleValues, true);
            CombinatoricsEngine<int> engine2 = new CombinatoricsEngine<int>(engine1, possibleValues, true);
            CombinatoricsEngine<int> engine3 = new CombinatoricsEngine<int>(engine2, possibleValues, true);
            CombinatoricsEngine<int> engine4 = new CombinatoricsEngine<int>(engine3, possibleValues, true);

            while (engine4.IsOverflown == false)
            {
                var next = engine4.GetNextCombination();
                foreach (var item in next)
                {
                    Console.Write($"{item}, ");
                }

                Console.WriteLine();
            }
        }
    }
}