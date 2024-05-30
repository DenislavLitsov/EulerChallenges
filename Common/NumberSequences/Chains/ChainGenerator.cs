namespace Common.NumberSequences.Chains
{
    public abstract class ChainGenerator<T>
    {
        private T _repeatingElement;
        private List<T> _chain;

        public ChainGenerator()
        {
        }

        public IEnumerable<T> Chain => _chain;

        public T RepeatingElement
        {
            get { return this._repeatingElement; }
        }

        public void GenerateWhileChainIsFormed()
        {
            this.InitChain();
            bool mustStop = false;
            do
            {
                var newElement = this.GenerateNextChainElement();
                if (this.IsElementInChain(newElement))
                {
                    mustStop = true;
                }

                this._chain.Add(newElement);
                this._repeatingElement = newElement;
            } while (!mustStop);
        }

        public void GenerateAmount(int amount)
        {
            this.InitChain();
            for (int i = 0; i < amount; i++)
            {
                var newElement = this.GenerateNextChainElement();
                this._chain.Add(newElement);
                this._repeatingElement = newElement;
            }
        }

        // Gets the distance from first repeating element to the last
        public long GetPeriod()
        {
            var firstIndex = this._chain.IndexOf(this.RepeatingElement);
            var lastIndex = this._chain.LastIndexOf(this.RepeatingElement);

            var res = lastIndex - firstIndex;
            return res;
        }

        public IEnumerable<T> GetPeriodEnumerable()
        {
            var firstIndex = this._chain.IndexOf(this.RepeatingElement);
            var lastIndex = this._chain.LastIndexOf(this.RepeatingElement);

            var result = this._chain.Skip(firstIndex).ToList();
            return result;
        }

        public T GetElementAtIndex(int index)
        {
            var res = this._chain[index];
            return res;
        }

        public T GetLastChainElement()
        {
            return this._chain.Last();
        }

        public abstract bool IsElementInChain(T element);
        
        protected abstract IEnumerable<T> InitializeChainValue();
        protected abstract T GenerateNextChainElement();

        private void InitChain()
        {
            var initedChain = this.InitializeChainValue()
                .ToList();
            this._chain = initedChain;
        }
    }
}