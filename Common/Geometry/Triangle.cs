namespace Common.Geometry
{
    public class Triangle
    {
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; }
        public double B { get; }
        public double C { get; }

        public bool IsRightAngle
        {
            get
            {
                return (this.A*this.A) + (this.B*this.B) == (this.C*this.C);
            }
        }
    }
}
