namespace AreaCalculator
{
    internal class Rectangle : Shape
    {
        public double Sidea { get; set; }
        public double Sideb { get; set; }

        public Rectangle(double sidea, double sideb)
        {
            Sidea = sidea;
            Sideb = sideb;
        }

        public override double CalculateArea()
        {
            return Sidea * Sideb;
        }
    }
}
