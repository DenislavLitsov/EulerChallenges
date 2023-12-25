namespace Common.NumberSequences.Abstractions
{
    public abstract class BaseSequenceGenerator
    {
        protected List<int> _CachedNumbers = null;

        public abstract int CalculateNumberAtExactIndex(int index);

        public virtual List<int> GetNumberSequence(int startIndex, int endIndex)
        {
            this.AssertMaxSequenceIndex(endIndex);

            List<int> generatedNumbers = new List<int>();

            for (int currIndex = startIndex; currIndex <= endIndex; currIndex++)
            {
                generatedNumbers.Add(this.CalculateNumberAtExactIndex(currIndex));
            }

            return generatedNumbers;
        }

        public virtual void CacheSequence(int startCacheIndex, int endCacheIndex)
        {
            this._CachedNumbers = new List<int>();
            this._CachedNumbers = this.GetNumberSequence(startCacheIndex, endCacheIndex);
        }

        public bool IsPartOfCachedSequence(int number)
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
        public int GetIndexInCachedSquence(int number)
        {
            int index = this._CachedNumbers.BinarySearch(number);
            return index;
        }

        public int GetCachedValue(int index)
        {
            return this._CachedNumbers[index];
        }

        protected abstract void AssertMaxSequenceIndex(int index);
    }
}
