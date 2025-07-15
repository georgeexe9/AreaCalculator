namespace AreaCalculator
{
    internal class Triangle : Shape
    {
        public double Side { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Height { get; set; }

        public Triangle(double side, double sideB, double sideC, double height)
        {

            if (side <= 0)
            {
                throw new ArgumentException(nameof(side), "Страната на триъгълника трябва да бъде по-голяма от 0");
            }
            else if (sideB <= 0)
            {
                throw new ArgumentException(nameof(sideB), "Височината на триъгълника трябва да бъде по-голяма от 0");
            }
            else if (sideC <= 0)
            {
                throw new ArgumentException(nameof(sideC), "Височината на триъгълника трябва да бъде по-голяма от 0");
            }
            else if (height <= 0)
            {
                throw new ArgumentException(nameof(height), "Височината на триъгълника трябва да бъде по-голяма от 0");
            }

            Side = side;
            SideB = sideB;
            SideC = sideC;
            Height = height;
        }

        public override double CalculateArea()
        {

            return 0.5 * Side * Height;
        }


        public override double CalculatePerimeter()
        {
            return Side + SideB + SideC;
        }
        public override string GetShapeName()
        {
            return "Триъгълник";
        }
    }
}
