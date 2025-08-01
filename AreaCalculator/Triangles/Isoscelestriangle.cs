using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Triangles
{
    internal class Isoscelestriangle : Shape

    {
        public double Side { get; set; }
        public double BaseSide { get; set; }
        public double Height
        {
            get
            {
                return Math.Sqrt(Math.Pow(Side, 2) - Math.Pow(BaseSide / 2.0, 2));
            }
        }

        public Isoscelestriangle(double side, double baseSide)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Бедрото на триъгълника трябва да бъде по-голямо от 0!");
            }
            if (baseSide <= 0)
            {
                throw new ArgumentException("Основата на триъгълника трябва да бъде по-голяма от 0!");
            }
            if (2 * side <= baseSide)
            {
                throw new ArgumentException("Неравенството на триъгълника не е изпълнено");
            }

            Side = side;
            BaseSide = baseSide;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Side + BaseSide;
        }
        public override double CalculateArea()
        {
            return (BaseSide * Height) / 2.0;
        }
        
    }
}
