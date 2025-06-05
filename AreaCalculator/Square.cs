namespace AreaCalculator
{
    internal class Square : Shape
    {
        public double SideA { get; set; }

        public Square(double sidea)
        {
           
            if (sidea <= 0)
            {
                throw new ArgumentOutOfRangeException("Страната на квадрата трябва да бъде по-голяма от 0");
            }

            SideA = sidea;
        }

        public override double CalculateArea()
        {

            return SideA * SideA;
        }
        public override double CalculatePerimeter()
        {

            return 4 * SideA;
        }

        public override string GetShapeName()
        {
            return "Square";
        }
    }
}
