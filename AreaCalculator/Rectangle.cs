namespace AreaCalculator
{
    //съжалявам, но extends е по-добре от ":"

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
            if (Sidea <= 0 && Sideb <= 0)
            {
                throw new ArgumentOutOfRangeException("Страната a и страната b на правоъгълника трябва да бъдат по-големи от нула ");
            }
            else if (Sidea <= 0)
            {
                throw new ArgumentOutOfRangeException("Страната а трябва да бъде по-голяма от 0");
            }
            else if (Sideb <= 0)
            {
                throw new ArgumentOutOfRangeException("Страната b трябва да бъде по-голяма от 0");
            }
            return Sidea * Sideb;
        }
        public override double CalculatePerimetar()
        {

            throw new NotImplementedException();
        }
    }
}
