using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Triangles
{
    internal class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double side, double sideB, double sideC, double height) : base(side, sideB, sideC, height)
        {

        }
        public override double CalculateArea()
        {
            return (Math.Sqrt(3) / 4) * Side * Side;
        }
        public override double CalculatePerimeter()
        {
            return 3 * Side;
        }
    }
}
