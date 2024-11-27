namespace Common.MultiThreading.RuleMultithreading
{
    public interface IRuleEnumarator<T>
    {
        bool ShouldContinue();
        
        T GetNext();
    }
}