using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Triangles
{
    internal class Isoscelestriangle : Triangle

    {
        public Isoscelestriangle(double side, double sideB, double sideC, double height) 
            : base(side, sideB, sideC, height)
        {
           
        }
        public override double CalculateArea()
        {
            return 0.5 * Side * Height;
        }
        public override double CalculatePerimeter()
        {
            return Side + SideB * Height;
        }
        public override string GetShapeName()
        {
            return "Равнобедрен триъгълник";
        }
    }
}
