namespace Common.Maps
{
    public abstract class BaseNode
    {
        public BaseNode(Position position)
        {
            this.Position = position;
        }

        public Position Position { get; private set; }
    }
}
