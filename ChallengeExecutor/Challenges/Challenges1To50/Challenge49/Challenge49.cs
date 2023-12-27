using ChallengeExecutor.Challenges.Abstractions;
using Common;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge49
{
    public class Challenge49 : BaseChallenge<string>
    {
        public override string GetName()
        {
            return "Challenge49";
        }

        protected override string SolveImplementation()
        {
            for (int i = 1000; i <= 9999; i++)
            {
                var allPermutations = i.ToString()
                    .GetAllPossibleCombinations()
                    .Where(x=>int.Parse(x).IsPrime() && int.Parse(x).ToString().Length == 4)
                    .ToList();
                //if (allPermutations.Contains(1487.ToString()))
                //    continue;


                for (int j = 0; j < allPermutations.Count; j++)
                {
                    for (int s = 0; s < allPermutations.Count; s++)
                    {
                        if (s == j)
                            continue;

                        if (allPermutations[j] == "1487" || allPermutations[s] == "1487")
                        {
                            continue;
                        }

                        int term = int.Parse(allPermutations[j]) - int.Parse(allPermutations[s]);
                        if (term < 0 || term.ToString().Length != 4)
                            continue;

                        int newNum = term + int.Parse(allPermutations[j]);
                        if (allPermutations.Contains(newNum.ToString()))
                        {
                            return allPermutations[s]+ allPermutations[j] + newNum.ToString();
                        }
                    }
                }

                //allPermutations.Print();
            }

            return "";
        }
    }
}
