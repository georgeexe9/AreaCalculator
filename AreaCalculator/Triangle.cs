namespace AreaCalculator
{
    internal class Triangle : Shape
    {
        public double Side { get; set; }
        public double Height { get; set; }

        public Triangle(double side, double height)
        {
            if (side <= 0 && height <= 0)
            {
                throw new ArgumentOutOfRangeException("Страната и височината на триъгълника трябва да бъдат по-големи от 0");
            }

            else if (side <= 0)
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
    }
}
