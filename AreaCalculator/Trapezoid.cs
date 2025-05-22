using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal class Trapezoid : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double Height { get; set; }

        public Trapezoid(double sideA, double sideB, double height)
        {
            SideA = sideA;
            SideB = sideB;
            Height = height;
        }
        public override double CalculateArea()
        {
            return 0.5 * (SideA + SideB) * Height;
        }
    }
    
}
