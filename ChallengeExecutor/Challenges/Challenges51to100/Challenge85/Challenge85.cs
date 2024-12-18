using ChallengeExecutor.Challenges.Abstractions;
using Common;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge85
{
    public class Challenge85 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            const int searchedFor = 2000000;

            int bestX = 0;
            int bestY = 0;
            int bestResult = searchedFor;
            
            for (int x = 1; x < 60; x++)
            {
                Console.WriteLine(x);
                for (int y = 1; y < 100; y++)
                {
                    var totalRects = this.GetTotalRectAngles(x, y);
                    var diff = Math.Abs(searchedFor - totalRects);
                    if (diff < bestResult)
                    {
                        bestX = x; 
                        bestY = y;
                        bestResult = diff;
                    }
                }
            }
            
            return bestX * bestY;
        }

        private int GetTotalRectAngles(int xMaxSize, int yMaxSize)
        {
            int totalTimes = 0;

            for (int xSize = 1; xSize <= xMaxSize; xSize++)
            {
                for (int ySize = 1; ySize <= yMaxSize; ySize++)
                {
                    for (int xPosition = 0; xPosition < xMaxSize; xPosition++)
                    {
                        if (xPosition + xSize > xMaxSize)
                        {
                            break;
                        }

                        for (int yPosition = 0; yPosition < yMaxSize; yPosition++)
                        {
                            if (yPosition + ySize > yMaxSize)
                            {
                                break;
                            }

                            totalTimes++;
                        }
                    }
                }
            }

            return totalTimes;
        }
    }
}