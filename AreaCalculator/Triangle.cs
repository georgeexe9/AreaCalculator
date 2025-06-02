namespace AreaCalculator
{
    internal class Triangle : Shape
    {
        public double Side { get; set; }
        public double Height { get; set; }

        public Triangle(double side, double height)
        {

            if (side <= 0)
            {
                throw new ArgumentOutOfRangeException("Страната на триъгълника трябва да бъде по-голяма от 0");
            }
            else if (height <= 0)
            {
                throw new ArgumentOutOfRangeException("Височината на триъгълника трябва да бъде по-голяма от 0");
            }

            Side = side;
            Height = height;
        }

        public override double CalculateArea()
        {

            return 0.5 * Side * Height;

        }

        public override string GetShapeName()
        {
            return "Триъгълник\n" +
                $"Страна: {Side}\n" +
                $"Височина: {Height}";
        }
        public override double CalculatePerimeter()
        {
            return base.CalculatePerimeter();
        }
    }
}
