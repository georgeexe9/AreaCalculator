namespace AreaCalculator
{
    internal class Triangle : Shape
    {
        public double Side { get; set; }
        public double Height { get; set; }

        public Triangle(double side, double height)
        {
            Side = side;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Side * Height;
        }
    }
}
