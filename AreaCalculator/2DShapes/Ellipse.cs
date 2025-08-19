namespace AreaCalculator
{
    internal class Ellipse : Shape

    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        public Ellipse(double majorAxis, double minorAxis)
        {
            //If проверки в конструктора
            if (majorAxis <= 0)
            {
                throw new ArgumentException("Полуостта по дължина трябва да е по-голяма от 0!");
            }
            else if (minorAxis <= 0)
            {
                throw new ArgumentException("Полуостта по ширина трябва да бъде по-голяма от 0!");
            }

            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
        }
        public override double CalculateArea()
        {

            return Math.PI * MajorAxis * MinorAxis;

        }
        public override double CalculatePerimeter()
        {
            return Math.PI * (3 * (MajorAxis + MinorAxis) - Math.Sqrt((3 * MajorAxis + MinorAxis) * (MajorAxis + 3 * MinorAxis)));
        }
        public override string GetShapeName()
        {
            return "Елипса";
        }
    }
}

