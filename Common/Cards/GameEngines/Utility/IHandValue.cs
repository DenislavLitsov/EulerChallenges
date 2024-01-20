namespace Common.Cards.GameEngines.Utility
{
    public interface IHandValue
    {
        bool IsFound();

        int WhoWins(IHandValue handValue2);
    }
}
