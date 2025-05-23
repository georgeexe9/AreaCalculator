namespace AreaCalculator
{
    internal class Triangle : Shape
    {
        public double Side { get; set; }
        public double Height { get; set; }

        public Triangle(double side, double height)
        {
            Side = side;
            Height = height;
        }

        public override double CalculateArea()
        {
            if (Side <= 0 && Height <= 0)
            {
                throw new ArgumentOutOfRangeException("Страната и височината на триъгълника трябва да бъдат по-големи от 0");
            }

            else if (Side <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Side),"Страната на триъгълника трябва да бъде по-голяма от 0");
            }
            else if (Height <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Height),"Височината на триъгълника трябва да бъде по-голяма от 0");
            }

            return 0.5 * Side * Height;

        }
    }
}
