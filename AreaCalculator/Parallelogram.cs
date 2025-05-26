using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal class Parallelogram : Shape
    {
        public double Side { get;  set; }
        public double Height { get; set; }

        public Parallelogram(double side, double height) 
        {
            if (side <= 0 && height <= 0)
            {
                throw new ArgumentOutOfRangeException("Страната и височината на успоредника трябва да бъдат по-големи от 0!");
            }
            else if (side <= 0)
            {
                throw new ArgumentOutOfRangeException("Страната на успоредника трябва да бъде по-голяма от 0");
            }
            else if (height <= 0)
            {
                throw new ArgumentOutOfRangeException("Височината на успоредника трябва да бъде по-голяма от 0");
            }
            Side = side;
            Height = height;
        }
        public override double CalculateArea()
        {
            
            return Side * Height;
        }
        public override double CalculatePerimeter()
        {
            return base.CalculatePerimeter();
        }
    }
    
}
