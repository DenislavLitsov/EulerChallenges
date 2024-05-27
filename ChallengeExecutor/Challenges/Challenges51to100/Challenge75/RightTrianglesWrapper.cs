namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge75
{
    public class RightTrianglesWrapper
    {
        public RightTrianglesWrapper(string initValue)
        {
            this.RightTriangles = new List<string>()
            {
                initValue
            };   
        }

        public RightTrianglesWrapper()
        {
            this.RightTriangles = new List<string>();
        }

        public ICollection<string> RightTriangles { get; set; }
    }
}