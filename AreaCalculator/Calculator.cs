namespace AreaCalculator
{
    internal class Calculator
    {

        public static double SquareArea(double x)
        {
            return x * x;
        }
        public static double TriangleArea(double BaseLength, double height)
        {
            return 0.5 * BaseLength * height;
        }
        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        public static double RectangleArea(double side, double height)
        {
            return side * height;
        }
        public static double EclipseArea(double b, double a)
        {
            return Math.PI * a * b;
        }
        public static double TrapezoidArea(double sideA, double sideB, double height)
        {
            //1/2 e 0.5
            return 0.5 * (sideA + sideB) * height;
        }

        public static void ClearAllBoxes(params TextBox[] textboxes)
        {
            foreach (var box in textboxes)
            {
                box.Clear();
            }
        }



    }
}
