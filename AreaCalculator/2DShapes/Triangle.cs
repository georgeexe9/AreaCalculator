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
                throw new ArgumentException("Страната на триъгълника\nтрябва да бъде по-голяма от 0");
            }
            if (sideB <= 0)
            {
                throw new ArgumentException("Височината на триъгълника\nтрябва да бъде по-голяма от 0");
            }
            if (sideC <= 0)
            {
                throw new ArgumentException("Височината на триъгълника\nтрябва да бъде по-голяма от 0");
            }
            if (height <= 0)
            {
                throw new ArgumentException("Височината на триъгълника\nтрябва да бъде по-голяма от 0");
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

        public override List<string> GetSummary()
        {
            return new List<string>
            {
                $"Триъгълник",
                $"Страна а: {Side}",
                $"Страна b: {SideB}",
                $"Страна c: {SideC}",
                $"Височина h: {Height}",
                $"Лице/Площ: {CalculateArea():F2}",
                $"Периметър: {CalculatePerimeter():F2}"
            };
        }
       

    }
}
