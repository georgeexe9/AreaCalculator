namespace AreaCalculator
{
    //съжалявам, но extends е по-добре от ":"


    internal class Rectangle : Shape
    {

        public double Sidea { get; set; }
        public double Sideb { get; set; }

        public Rectangle(double sidea, double sideb)
        {
            if (sidea <= 0 || sideb <= 0)
            {
                throw new ArgumentException("Страните на правоъгълника трябва да бъдат по-големи от нула.");
            }
            Sidea = sidea;
            Sideb = sideb;
        }

        public override double CalculateArea()
        {
            return Sidea * Sideb;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Sidea + Sideb);

        }
        public override double CalculateDiagonal()
        {
            return Math.Sqrt(Math.Pow(Sidea, 2) + Math.Pow(Sideb, 2));
        }
        public override string GetShapeName()
        {
            return "Правоъгълник";
        }
    }
}
