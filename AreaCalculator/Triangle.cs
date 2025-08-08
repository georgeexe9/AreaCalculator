using System.Text;

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
                throw new ArgumentException("Страната на триъгълника трябва да бъде по-голяма от 0");
            }
            if (sideB <= 0)
            {
                throw new ArgumentException("Височината на триъгълника трябва да бъде по-голяма от 0");
            }
            if (sideC <= 0)
            {
                throw new ArgumentException("Височината на триъгълника трябва да бъде по-голяма от 0");
            }
            if (height <= 0)
            {
                throw new ArgumentException("Височината на триъгълника трябва да бъде по-голяма от 0");
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
        [Obsolete("Този метод ще хвърчи през прозореца, използвайте GetShapeInfo()")]
        public override string GetShapeName()
        {
            return "Триъгълник";
        }

        public override string GetShapeInfo()
        {
            StringBuilder newSBS = new StringBuilder();
            newSBS.AppendLine($"Фигура: Триъгълник\n");
            newSBS.AppendLine($"Страна a: {Side}\n");
            newSBS.AppendLine($"Страна b: {SideB}\n");
            newSBS.AppendLine($"Страна c: {SideC}\n");
            newSBS.AppendLine($"Височина h: {Height}");
            newSBS.AppendLine($"Лице/Площ S - {CalculateArea()}\n");
            newSBS.AppendLine($"Периметър P - {CalculatePerimeter()}\n");
            return newSBS.ToString();
        }

    }
}
