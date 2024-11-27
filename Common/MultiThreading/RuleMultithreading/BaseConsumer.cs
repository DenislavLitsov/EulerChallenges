namespace Common.MultiThreading.RuleMultithreading
{
    public abstract class BaseConsumer<T>
    {
        private readonly IRuleEnumarator<T> _ruleEnumarator;

        public BaseConsumer(IRuleEnumarator<T> ruleEnumarator)
        {
            _ruleEnumarator = ruleEnumarator;
        }
        
        public void Start()
        {
            while (_ruleEnumarator.ShouldContinue())
            {
                var nextValue = _ruleEnumarator.GetNext();
                Test(nextValue);
            }
        }

        protected abstract void Test(T testItem);
    }
}