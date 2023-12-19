using Common;
using Common.Maps;
using Common.Maps.PathFinding;

namespace ChallengeExecutor.Challenges.Challenge18
{
    public class Challenge18 : BaseChallenge<long>
    {
        private AStarImplmentation aStarImplmentation;

        public override string GetName()
        {
            return "Challenge18";
        }

        protected override long SolveImplementation()
        {
            this.InitAStarImplementation();
            var bestWeight = this.aStarImplmentation.GetTotalWeight();
            return bestWeight;
        }

        private void InitAStarImplementation()
        {
            Map<WeightedNode> map = new Map<WeightedNode>();
            using (StreamReader sr = new StreamReader("Challenges/Challenge18/map.txt"))
            {
                int y = 0;
                do
                {
                    var line  = sr.ReadLine();
                    map.AddNewRow();

                    var values = line.Split(" ");
                    for (int x = 0; x < values.Length; x++)
                    {
                        WeightedNode node = new WeightedNode(int.Parse(values[x]), new Position() { X = x, Y = y });
                        map.AddNewNodeToRow(node, y);
                    }

                    y++;

                } while (!sr.EndOfStream);
            }

            this.aStarImplmentation = new AStarImplmentation(map);
        }
    }
}
