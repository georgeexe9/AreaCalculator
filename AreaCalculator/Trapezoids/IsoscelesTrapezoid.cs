using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Trapezoids
{
    //наследяваме кучка
    internal class IsoscelesTrapezoid : Trapezoid

    {
        public IsoscelesTrapezoid(double sideA, double sideB, double sideC, double sideD, double height)
        //базов конструктор, от оригиналния клас, с една проверкаа
        : base(sideA, sideB, sideC, sideD, height)
        {
            if (sideC != sideD)
            {
                throw new ArgumentException("Бедрата на трапеца трябва да бъдат равни!");
            }
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
            return "Равнобедрен трапец";
        }
    }
}
