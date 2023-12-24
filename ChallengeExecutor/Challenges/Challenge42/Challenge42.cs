using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenge42
{
    public class Challenge42 : FileReadingChallenge<int>
    {
        private List<string> _Names;
        private List<int> _TValues;

        public override string GetName()
        {
            return "Challenge42";
        }

        protected override string GetFilePath()
        {
            return "Challenges/Challenge42/Names.txt";
        }

        protected override void Setup()
        {
            // Chache Names
            this._Names = new List<string>();
            var allNotParsedNames = this.ReadFileAsOneLine().Split(',');
            foreach (var notParsedNames in allNotParsedNames)
            {
                string toAdd = notParsedNames.Substring(1, notParsedNames.Length - 2);
                this._Names.Add(toAdd);
            }

            // Cache T Values
            this._TValues = new List<int>();
            for (int n = 0; n < 1000; n++)
            {
                int newTValue = ((n + 1) * n) / 2;
                this._TValues.Add(newTValue);
            }
        }

        protected override int SolveImplementation()
        {
            int numberOfTriangleWords = 0;
            foreach (var name in this._Names)
            {
                int nameTValue = this.GetTValueOfName(name);
                if (this._TValues.Contains(nameTValue))
                    numberOfTriangleWords++;
            }

            return numberOfTriangleWords;
        }

        private int GetTValueOfName(string name)
        {
            int result = 0;
            foreach (var letter in name)
            {
                int letterIndex = ((byte)letter) - ((byte)'A') + 1;
                result += letterIndex;
            }

            return result;
        }
    }
}
