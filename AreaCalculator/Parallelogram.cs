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
        public double SideB {  get; set; }
        public double Height { get; set; }

        public Parallelogram(double side, double height, double sideb) 
        {
          //конструктора е чувствителен, ще иска и трите стойности
            if (side <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(side),"Страната на успоредника трябва да бъде по-голяма от 0");
            }
            else if (height <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(sideb),"Височината на успоредника трябва да бъде по-голяма от 0");
            }
            else if (sideb <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height),"Страната b на успоредника трябва да бъде по-голяма от 0!");
            }
            Side = side;
            SideB = sideb;
            Height = height;
            
        }
        public override double CalculateArea()
        {
            return Side * Height;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Side +  SideB);
        }
        public override string GetShapeName()
        {
            return "Успоредник";
        }
    }
    
}
