namespace AreaCalculator
{
    internal class Circle : Shape

    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimetar()
        {
            throw new NotImplementedException("За сега няма да се имплементира!");
        }
       

    }
}