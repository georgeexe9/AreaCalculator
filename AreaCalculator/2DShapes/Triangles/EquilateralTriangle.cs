using System.Text;

namespace AreaCalculator.Triangles
{
    internal class EquilateralTriangle : Shape
    {
        //само едно пропърти, всичките страни равни! 
        public double Side { get; set; }


        public EquilateralTriangle(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Страната трябва да\nбъде по-голяма от 0!");
            }
            Side = side;
        }
        public override double CalculateArea()
        {
            return (Side * Side * Math.Sqrt(3)) / 4;
        }
        public override double CalculatePerimeter()
        {
            return 3 * Side;
        }
        [Obsolete("Ще се трие, използвай, GetShapeName()!")]
        public override string GetShapeName()
        {
            return "Равнобедрен триъгълник";
        }
        public override List<string> GetSummary()
        {
            return new List<string>
            {
                $"Равностранен триъгълник",
                $"Страна: {Side} cm",
                $"Лице/Площ: {CalculateArea():F2} cm",
                $"Периметър: {CalculatePerimeter():F2} cm"
            };
        }

    }

}