namespace AreaCalculator
{
    internal class Square : Shape
    {
        public double SideA { get; set; }

        public Square(double sidea)
        {
            SideA = sidea;
        }

        public override double CalculateArea()
        {
            if (SideA < 0)
            {
                throw new ArgumentOutOfRangeException("Страната на квадрата трябва да бъде по-голяма от 0");
            }
            return SideA * SideA;
        }
        public override double CalculatePerimetar()
        {
            throw new NotImplementedException();
        }
    }
}
