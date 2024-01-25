namespace Common.Maps
{
    public class Map<T> where T : BaseNode
    {
        private List<List<T>> map;

        public Map()
        {
            map = new List<List<T>>();
        }

        public void AddNewRow()
        {
            this.map.Add(new List<T>());
        }

        public void AddNewNodeToRow(T node, int y)
        {
            if (y < 0)
            {
                throw new ArgumentOutOfRangeException($"Y is smaller than 0: {y}");
            }
            if (y >= map.Count)
            {
                throw new ArgumentOutOfRangeException($"Y is out of boundaries: {y}. Max is: {map.Count - 1}");
            }

            map[y].Add(node);
        }

        public T GetNode(Position position)
        {
            var row = this.map[(int)position.Y];
            var node = row[(int)position.X];

            return node;
        }

        public T GetNode(int x, int y)
        {
            var res = this.GetNode(new Position { X = x, Y = y });
            return res;
        }

        public T GetNode(double x, double y)
        {
            var res = this.GetNode(new Position { X = x, Y = y });
            return res;
        }

        public int GetMaxXAtY(int y)
        {
            var res = this.map[y].Count - 1;
            return res;
        }

        public int GetMaxY()
        {
            var res = this.map.Count - 1;
            return res;
        }
       
        public bool AssertPositin(Position position)
        {
            if (position.X >= 0 && position.Y >= 0
                && position.Y <= this.GetMaxY() && position.X <= this.GetMaxXAtY((int)position.Y))
            {
                return true;
            }

            return false;
        }

        public List<T> GetRow(int y)
        {
            return this.map[y];
        }
    }
}