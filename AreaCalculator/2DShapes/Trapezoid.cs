namespace AreaCalculator
{
    //нека си признаем, че extends е по-добре от :
    internal class Trapezoid : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }
        public double Height { get; set; }

        public Trapezoid(double sideA, double sideB, double sideC, double sideD, double height)
        {

            if (sideA <= 0)
            {
                throw new ArgumentException
                    ("Страната а трябва да бъде по-голяма от 0!");
            }
            else if (sideB <= 0)
            {

                throw new ArgumentException("Страната b трябва да бъде по-голяма от 0!");
            }
            else if (sideC <= 0)
            {
                throw new ArgumentException("Страната c трябва да бъде по-голяма от 0!");
            }
            else if (sideD <= 0)
            {
                throw new ArgumentException("Страната d трябва да бъде по-голяма от 0!");
            }
            else if (height <= 0)
            {
                throw new ArgumentException("Височината трябва да бъде по-голяма от 0");
            }
            double difference = Math.Abs(sideA - sideB);
            if (height > difference)
            {
                throw new ArgumentException("Височината не може да бъде по-голяма от разликата на основите! ");
            }

            if (sideC + sideD < difference)
            {
                throw new ArgumentException("Страната c и страната d не могат да се свържат, моля проверете дължините и височината");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
            Height = height;
        }
        public override double CalculateArea()
        {

            return 0.5 * (SideA + SideB) * Height;
        }
        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC + SideD;
        }

        [Obsolete]
        public override string GetShapeName()
        {
            return "Трапец";
        }

    }

}
