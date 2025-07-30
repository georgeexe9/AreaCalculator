using System.Text;

namespace AreaCalculator.Triangles
{
    //Ще наследява Shape, а не Triangle
    internal class RightTriangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double Hypotenuse
        {
            get
            {
                return Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
            }

        }

        public RightTriangle(double sidea, double sideb)
        {
            if (sidea <= 0)
            {
                throw new ArgumentException("Страната a трябва да бъде по-голяма от 0");
            }
            if (sideb <= 0)
            {
                throw new ArgumentException("Страната b трябва да бъде по-голяма от 0");
            }
            SideA = sidea;
            SideB = sideb;
        }
        public override double CalculateArea()
        {
            return 0.5 * SideA * SideB;
        }
        
        public override double CalculatePerimeter()
        {
            return SideA + SideB + Hypotenuse;
        }

        [Obsolete("Ще се изхвърля през прозореца!")]
        public override string GetShapeName()
        {
            return "Правоъгълен триъгълник";
        }
        public override string GetSummary()
        {
            StringBuilder newSBS = new StringBuilder();
            newSBS.AppendLine($"Фигура: Триъгълник");
            newSBS.AppendLine($"Страна a:{SideA}");
            newSBS.AppendLine($"Страна b:{SideB}");
            newSBS.AppendLine($"Хипотенуза c:{Hypotenuse:F2}");
            newSBS.AppendLine($"Лице/Площ S - {CalculateArea()}");
            newSBS.AppendLine($"Периметър P - {CalculatePerimeter()}");
            return newSBS.ToString();
        }
    }
}
