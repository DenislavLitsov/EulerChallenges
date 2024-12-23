﻿using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge11
{
    public class Challenge11 : BaseChallenge<long>
    {
        private string numbers = "08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08\r\n49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00\r\n81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65\r\n52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91\r\n22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80\r\n24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50\r\n32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70\r\n67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21\r\n24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72\r\n21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95\r\n78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92\r\n16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57\r\n86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58\r\n19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40\r\n04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66\r\n88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69\r\n04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36\r\n20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16\r\n20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54\r\n01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48";
        private List<string> grid;
        public Challenge11()
        {
            grid = numbers.Split("\r\n").ToList();
        }

        protected override long SolveImplementation()
        {
            int maxValue = 0;

            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    int currFound = GetLargestProduct(x, y);
                    if (currFound > maxValue)
                    {
                        maxValue = currFound;
                        Console.WriteLine($"New max found: {maxValue}. Position (X, Y): ({x},{y})");
                    }
                }
            }

            return maxValue;
        }

        private int GetNumber(int x, int y)
        {
            if (x >= 20 || x < 0)
            {
                throw new ArgumentOutOfRangeException($"X {x}");
            }
            if (y >= 20 || y < 0)
            {
                throw new ArgumentOutOfRangeException($"Y {y}");
            }

            var gridRow = grid[y].Split(" ");
            var result = int.Parse(gridRow[x]);
            return result;
        }

        private int GetLargestProduct(int x, int y)
        {
            int product1 = 0;
            int product2 = 0;
            int product3 = 0;
            int product4 = 0;

            if (x < 19 - 4)
            {
                int num11 = GetNumber(x, y);
                int num12 = GetNumber(x + 1, y);
                int num13 = GetNumber(x + 2, y);
                int num14 = GetNumber(x + 3, y);

                product1 = num11 * num12 * num13 * num14;
            }

            if (y < 19 - 4)
            {
                int num21 = GetNumber(x, y);
                int num22 = GetNumber(x, y + 1);
                int num23 = GetNumber(x, y + 2);
                int num24 = GetNumber(x, y + 3);

                product2 = num21 * num22 * num23 * num24;
            }

            if (x < 19 - 4 && y < 19 - 4)
            {
                int num31 = GetNumber(x, y);
                int num32 = GetNumber(x + 1, y + 1);
                int num33 = GetNumber(x + 2, y + 2);
                int num34 = GetNumber(x + 3, y + 3);

                product3 = num31 * num32 * num33 * num34;
            }

            if (x >= 3 && y < 19 - 4)
            {
                int num41 = GetNumber(x, y);
                int num42 = GetNumber(x - 1, y + 1);
                int num43 = GetNumber(x - 2, y + 2);
                int num44 = GetNumber(x - 3, y + 3);

                product4 = num41 * num42 * num43 * num44;
            }

            List<int> list = new List<int>() { product1, product2, product3, product4 };
            var max = list.Max(x => x);
            return max;
        }
    }
}
