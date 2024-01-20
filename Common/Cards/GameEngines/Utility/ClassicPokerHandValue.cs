namespace Common.Cards.GameEngines.Utility
{
    public class ClassicPokerHandValue : IHandValue
    {
        public ClassicPokerHandValue(int mainValue, int secondaryValue, bool isFound)
        {
            this.MainValue = mainValue;
            this.SecondaryValue = secondaryValue;
            this._IsFound = isFound;
        }

        public int MainValue { get; set; }
        public int SecondaryValue { get; set; }

        public bool _IsFound { get; set; }

        public bool IsFound()
        {
            return this._IsFound;
        }

        /// <summary>
        /// Returns 0 if equal, 1 if first wins, 2 if second wins
        /// </summary>
        /// <param name="handValue1"></param>
        /// <param name="handValue2"></param>
        /// <returns></returns>
        public int WhoWins(IHandValue handValue2)
        {
            var parsed1 = (ClassicPokerHandValue)this;
            var parsed2 = (ClassicPokerHandValue)handValue2;
            if (parsed1.MainValue > parsed2.MainValue)
            {
                return 1;
            }
            else if (parsed1.MainValue < parsed2.MainValue)
            {
                return 2;
            }
            else
            {
                if (parsed1.SecondaryValue > parsed2.SecondaryValue)
                {
                    return 1;
                }
                else if (parsed1.SecondaryValue < parsed2.SecondaryValue)
                {
                    return 2;
                }
            }

            return 0;
        }
    }
}
