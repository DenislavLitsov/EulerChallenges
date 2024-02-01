using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.Exceptions;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge79
{
    public class Challenge79 : FileReadingChallenge<string>
    {
        IEnumerable<string> passcodes;

        protected override string GetFilePath()
        {
            return "Challenges/Challenges51To100/Challenge79/passcodes.txt";
        }

        protected override void Setup()
        {
            this.passcodes = this.ReadFile()
                .Distinct()
                .ToList();
        }

        protected override string SolveImplementation()
        {
            this.passcodes.Print();

            throw new NoSolutionFound();
        }
    }
}
