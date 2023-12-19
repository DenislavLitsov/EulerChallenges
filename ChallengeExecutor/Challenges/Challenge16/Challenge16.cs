﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeExecutor.Challenges.Challenge16
{
    public class Challenge16 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge 16";
        }

        protected override int SolveImplementation()
        {
            BigInteger bigIntegerValue = 1;
            for (BigInteger i = 0; i < 1000; i++)
            {
                bigIntegerValue *= 2;
            }

            string stringifiedNumber = bigIntegerValue.ToString();
            int result = 0;
            for (int i = 0; i < stringifiedNumber.Length; i++)
            {
                result += int.Parse(stringifiedNumber[i].ToString());
            }

            return result;
        }
    }
}