﻿using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenge30
{
    public class Challenge30 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge30";
        }

        protected override int SolveImplementation()
        {
            int result = 0;

            for (int i = 2; i < 354294 + 1; i++)
            {
                string digits = i.ToString();
                int currCheck = 0;
                for (int currChar = 0; currChar < digits.Length; currChar++)
                {
                    int digit = int.Parse(digits[currChar].ToString());
                    int toAdd = (int)Math.Pow(digit, 5);
                    currCheck += toAdd;
                }

                if (currCheck == i)
                {
                    result += currCheck;
                }
            }

            return result;
        }
    }
}
