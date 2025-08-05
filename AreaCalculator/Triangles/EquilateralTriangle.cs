using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Triangles
{
    internal class EquilateralTriangle : Shape
    {
        //само една страна, равностранен триъгълник Side = Side = Side
        public double Side { get; set; }

        public EquilateralTriangle(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Страната трябва да бъде по-голяма от 0!");
            }
            Side = side;
        }
        public override double CalculateArea()
        {
            return (Side * Side* Math.Sqrt(3)) / 4;
        }
        public override double CalculatePerimeter()
        {
            return 3 * Side;
        }

    }

}