using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal class Triangle : Shape
    {
        public double side { get; set; }
        public double height { get; set; }

        public override double CalculateArea()
        {
           return 0.5 * side * height;
        }
    }
}
