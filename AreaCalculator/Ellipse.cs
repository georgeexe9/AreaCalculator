namespace AreaCalculator
{
    internal class Ellipse : Shape

    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        public Ellipse(double majorAxis, double minorAxis)
        {
            if (majorAxis <= 0 || minorAxis <= 0)
            {
                throw new ArgumentOutOfRangeException("Полуостта по дължина и полуостта по ширина трябва да е по-голяма от 0!");
            }
            else if (majorAxis <= 0)
            {
                throw new ArgumentOutOfRangeException("Полуостта по дължина трябва да е по-голяма от 0!");
            }
            else if (minorAxis <= 0)
            {
                throw new ArgumentOutOfRangeException("Полуостта по ширина трябва да бъде по-голяма от 0!");
            }
            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
        }
        public override double CalculateArea()
        {
            
            return Math.PI * MajorAxis * MinorAxis;
         
        }
        public override double CalculatePerimetar()
        {
            return base.CalculatePerimetar();
        }
    }
}

