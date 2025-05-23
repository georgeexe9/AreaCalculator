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
            if (Radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Радиусът трябва да е по-голям от 0!");
            }
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimetar()
        {
            if (Radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Радиусът трябва да е по-голям от 0!");
            }
            return 2 * Math.PI * Radius;
        }


    }
}