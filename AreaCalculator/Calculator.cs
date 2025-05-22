namespace AreaCalculator
{
    internal class Calculator
    {
        public double SquareArea(double x)
        {
            return x * x;
        }
        public double TriangleArea(double BaseLength, double height)
        {
            return 0.5 * BaseLength * height;
        }
        public double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        public double RectangleArea(double side, double height)
        {
            return side * height;
        }
        public double EclipseArea(double b, double a)
        {
            return Math.PI * a * b;
        }
        public double TrapezoidArea(double sideA, double sideB, double height)
        {
            return 0.5 * (sideA + sideB) * height;
        }

    }
}
