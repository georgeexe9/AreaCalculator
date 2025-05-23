namespace AreaCalculator
{
    public abstract class Shape
    {

        public abstract double CalculateArea();
        public virtual double CalculatePerimetar()
        {
            throw new NotSupportedException("СЯЯЯ НЯЯ СЕ ИЗПОЛЗВА");
        }

    }

}
