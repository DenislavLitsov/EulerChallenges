﻿using Common.NumberSequences.Abstractions;

namespace Common.NumberSequences
{
    public class PentagonalSequenceGenerator : BaseSequenceGenerator
    {
        public override long CalculateNumberAtExactIndex(int index)
        {
            this.AssertMaxSequenceIndex(index);
            long result = index * (3 * index - 1) / 2;

            return result;
        }

        public override int GetMaximaValidIndex()
        {
            return 1753413056;
        }
    }
}