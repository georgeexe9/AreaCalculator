namespace AreaCalculator
{
    internal class Circle : Shape

    {
        public double Radius { get;  }

        public Circle(double radius)
        {

            if (radius <= 0)
            {
                throw new ArgumentException("Радиусът трябва да е по-голям от 0!");
            }

            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {

            return 2 * Math.PI * Radius;
        }
        [Obsolete]
        public override string GetShapeName()
        {
            return "Кръг";
        }


    }
}