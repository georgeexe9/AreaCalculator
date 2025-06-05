using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Triangles
{
    internal class RightTriangle : Triangle
    {
        public RightTriangle(double side, double sideB, double sideC, double height) : base(side, sideB, sideC, height)
        {
            //проверки в базов клас
        }
        public override double CalculateArea()
        {
            return (Side * SideB) / 2;
        }
        public override double CalculatePerimeter()
        {
            return Side + SideB + SideC;
        }
        public double CalculateHypotenuse(double side, double sideB, double height)
        {
            return Math.Sqrt(Side * Side + SideB * SideB);
        }
        
    }
}
