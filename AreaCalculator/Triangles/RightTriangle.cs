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


        public override List<string> GetSummary()
        {
            return new List<string>
            {
                $"Правоъгълен триъгълник",
                $"Страна а: {SideA}",
                $"Страна b: {SideB}",
                $"Хипотенуза c: {Hypotenuse:F2}",
                $"Лице/Площ: {CalculateArea():F2}",
                $"Периметър: {CalculatePerimeter():F2}"
            };
        }

    }
}
