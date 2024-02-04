namespace Common.NumberSequences.Abstractions
{
    public abstract class BaseSequenceGenerator
    {
        protected List<long> _CachedNumbers = null;

        public abstract long CalculateNumberAtExactIndex(int index);

        public abstract int GetMaximaValidIndex();

        public virtual List<long> GetNumberSequence(int startIndex, int endIndex)
        {
            this.AssertMaxSequenceIndex(endIndex);

            List<long> generatedNumbers = new List<long>();

            for (int currIndex = startIndex; currIndex <= endIndex; currIndex++)
            {
                generatedNumbers.Add(this.CalculateNumberAtExactIndex(currIndex));
            }

            return generatedNumbers;
        }

        public virtual void CacheSequence(int startCacheIndex, int endCacheIndex)
        {
            this.AssertMaxSequenceIndex(endCacheIndex);

            this._CachedNumbers = new List<long>(endCacheIndex - startCacheIndex);
            this._CachedNumbers = this.GetNumberSequence(startCacheIndex, endCacheIndex);
        }

        /// <summary>
        /// Values are inclusive
        /// </summary>
        /// <param name="minValue">Inclusive</param>
        /// <param name="maxValue">Inclusive</param>
        public virtual void CacheSequenceByValues(long minValue, long maxValue)
        {
            var cachedValues = new List<long>();

            int index = 0;
            long currValue = this.CalculateNumberAtExactIndex(index);
            
            do
            {
                if (currValue >= minValue)
                    cachedValues.Add(currValue);

                index++;
                this.AssertMaxSequenceIndex(index);
                currValue = this.CalculateNumberAtExactIndex(index);
            } while (currValue <= maxValue);

            this._CachedNumbers = cachedValues;
        }

        public void CacheAll()
        {
            this.CacheSequence(0, this.GetMaximaValidIndex());
        }

        public IEnumerable<long> GetCachedNumbers()
        {
            return this._CachedNumbers;
        }

        public bool ContainsInCachedSequence(long number)
        {
            int index = this._CachedNumbers.BinarySearch(number);
            if (index >= 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns -10 if not found
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returns -10 if not found</returns>
        public int GetIndexInCachedSquence(long number)
        {
            int index = this._CachedNumbers.BinarySearch(number);
            return index;
        }

        public long GetCachedValue(int index)
        {
            return this._CachedNumbers[index];
        }

        protected void AssertMaxSequenceIndex(int index)
        {
            if (index > this.GetMaximaValidIndex())
            {
                throw new OverflowException($"Integer overflow at index: {index}");
            }
        }
    }
}
