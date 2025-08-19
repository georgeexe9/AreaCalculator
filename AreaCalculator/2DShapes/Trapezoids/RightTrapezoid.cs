namespace AreaCalculator.Trapezoids
{
    internal class RightTrapezoid : Trapezoid
    {
        public RightTrapezoid(double sideA, double sideB, double sideC, double sideD, double height)
            : base(sideA, sideB, sideC, sideD, height)
        {

        }
        public override double CalculateArea()
        {
            return (SideA + SideB) * Height / 2;
        }
        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC + SideD;
        }
        public override string GetShapeName()
        {
            return "Правоъгълен трапец";
        }
    }
}
