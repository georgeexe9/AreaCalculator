namespace AreaCalculator
{
    internal class Parallelogram : Shape
    {
        public double Side { get; set; }
        public double SideB { get; set; }
        public double Height { get; set; }
        public double Angle { get; set; }

        public Parallelogram(double side, double height, double sideb, double angle)
        {
            //конструктора е чувствителен, ще иска и трите стойности
            if (side <= 0)
            {
                throw new ArgumentException("Страната на успоредника трябва да бъде по-голяма от 0");
            }
            else if (height <= 0)
            {
                throw new ArgumentException("Височината на успоредника трябва да бъде по-голяма от 0");
            }
            else if (sideb <= 0)
            {
                throw new ArgumentException("Страната b на успоредника трябва да бъде по-голяма от 0!");
            }
            if (angle <= 0 || angle >= 180)
            {
                throw new ArgumentException("Ъгълът не може да бъде по-малък от 0");
            }
            Side = side;
            SideB = sideb;
            Height = height;
            Angle = angle;

        }
        public override double CalculateArea()
        {
            return Side * Height;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Side + SideB);
        }
        public override double CalculateDiagonal()
        {
            double radians = Angle * Math.PI / 180;
            return Math.Sqrt(Math.Pow(Side, 2) + Math.Pow(SideB, 2) + 2 * Side * SideB * Math.Cos(radians));
        }
        public override string GetShapeName()
        {
            return "Успоредник";
        }
    }

}
