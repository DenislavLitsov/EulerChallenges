namespace Common.Exceptions
{
    [Serializable]
    public class NoSolutionFound : Exception
    {
        public NoSolutionFound() { }

        public NoSolutionFound(string message)
            : base(message) { }

        public NoSolutionFound(string message, Exception inner)
            : base(message, inner) { }
    }
}
