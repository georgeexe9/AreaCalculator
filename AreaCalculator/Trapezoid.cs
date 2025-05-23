namespace AreaCalculator
{
    //нека си признаем, че extends е по-добре от :
    internal class Trapezoid : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double Height { get; set; }

        public Trapezoid(double sideA, double sideB, double height)
        {
            SideA = sideA;
            SideB = sideB;
            Height = height;
        }
        public override double CalculateArea()
        {
            if (SideA <= 0 && SideB <= 0 && Height <= 0)
            {
                throw new ArgumentOutOfRangeException("Страната а, страната b и височината трябва да бъдат по-големи от 0");
            }
            else if (SideA <= 0)
            {
                throw new ArgumentOutOfRangeException("Страната а трябва да бъде по-голяма от 0!");
            }
            else if (SideB <= 0)
            {
                throw new ArgumentOutOfRangeException("Страната b трябва да бъде по-голяма от 0!");
            }
            else if (Height <= 0)
            {
                throw new ArgumentOutOfRangeException("Височината трябва да бъде по-голяма от 0");
            }
            return 0.5 * (SideA + SideB) * Height;
        }
        public override double CalculatePerimetar()
        {
            throw new NotImplementedException();
        }
    }

}
