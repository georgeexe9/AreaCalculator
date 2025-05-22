namespace AreaCalculator
{
    internal class Square : Shape
    {
        public double SideA { get; set; }

        public Square(double sidea)
        {
            SideA = sidea;
        }

        public override double CalculateArea()
        {
            return SideA * SideA;
        }
    }
}
