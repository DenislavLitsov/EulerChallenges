using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenge38
{
    public class Challenge38 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge38";
        }

        protected override int SolveImplementation()
        {
            int bestPanDigital = 0;
            int bestIndex = 0;
            int currNumber = 1;

            do
            {
                string numToCheck = "";
                int n = 0;
                for (n = 1; n <= 9; n++)
                {
                    numToCheck += (currNumber * n).ToString();
                    if (numToCheck.Length >= 9)
                        break;
                }

                if (n < 2)
                    break;

                if (numToCheck.Length == 9)
                {
                    bool isPandigital = true;
                    for (int i = 1; i <= 9; i++)
                    {
                        if (numToCheck.Contains(i.ToString()) == false)
                        {
                            isPandigital = false;
                            break;
                        }
                    }

                    if (isPandigital)
                    {
                        if (bestPanDigital < int.Parse(numToCheck))
                        {
                            bestPanDigital = int.Parse(numToCheck);
                            bestIndex = currNumber;
                            Console.WriteLine($"New best: {bestIndex} with pandigital: {bestPanDigital}");
                        }
                    }
                }

                currNumber++;
            } while (true);

            return bestPanDigital;
        }
    }
}
