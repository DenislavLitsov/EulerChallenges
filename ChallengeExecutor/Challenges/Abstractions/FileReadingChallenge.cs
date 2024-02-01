using System.Text;

namespace ChallengeExecutor.Challenges.Abstractions
{
    public abstract class FileReadingChallenge<T> : BaseChallenge<T>
    {
        protected abstract string GetFilePath();

        protected string ReadFileAsOneLine()
        {
            var list = this.ReadFile();

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in list)
            {
                stringBuilder.Append(item);
            }

            return stringBuilder.ToString();
        }

        protected IEnumerable<IEnumerable<string>> ReadFileAndSplitLines(string separator)
        {
            List<List<string>> result = new List<List<string>>();
            var file = this.ReadFile();
            foreach (var item in file)
            {
                var splitedLines = item.Split(separator);
                result.Add(splitedLines.ToList());
            }

            return result;
        }

        protected IEnumerable<string> ReadFile()
        {
            List<string> result = new List<string>();
            using (StreamReader sr = new StreamReader(this.GetFilePath()))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    if (line != null && line != string.Empty)
                        result.Add(line);
                }
            }

            return result;
        }
    }
}
