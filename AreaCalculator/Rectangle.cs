namespace AreaCalculator
{
    //съжалявам, но extends е по-добре от ":"

    internal class Rectangle : Shape
    {
        public double Sidea { get; set; }
        public double Sideb { get; set; }

        public Rectangle(double sidea, double sideb)
        {
            if (sidea <= 0)
            {
                throw new ArgumentOutOfRangeException("Страната a и страната b на правоъгълника трябва да бъдат по-големи от нула ");
            }
            else if (sideb <= 0)
            {
                throw new ArgumentOutOfRangeException("Страната b трябва да бъде по-голяма от 0");
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
            {

                return 2 * (Sidea + Sideb);
            }
        }
    }
}
