
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
                throw new ArgumentException("Страната а на правоъгълника трябва да бъдат по-големи от нула.");
            }
            if (sideb <= 0)
            {
                throw new ArgumentException("Страната b на правоъгълника трябва да бъдат по-големи от нула.");
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
        public override List<string> GetSummary()
        {
            return new List<string>()
            {
                $"Правоъгълник",
                $"Страна а: {Sidea}",
                $"Страна b: {Sideb}",
                $"Диагонал - {CalculateDiagonal():F2}",
                $"Лице/Площ - {CalculateArea():F2}",
                $"Периметър - {CalculatePerimeter():F2}",
            };
        }
    }
}
