using System.Text;

namespace AreaCalculator
{

    public  abstract class Shape
    {
        /// <summary>
        /// Hides funtionality like George
        /// </summary>
        /// <returns></returns>

        //изчислява лице/площ
        public abstract double CalculateArea();

        //връща пълна информация за фигурата
        public virtual string GetShapeInfo()
        {
            //търси логика в другите класове в тва assembly
            throw new NotSupportedException("temporary method");
        }

        //STANDBY METHOD ;) 
        [Obsolete("THROW OUT OF THE WINDOWWW!")]
        public virtual string GetShapeName()
        {
            throw new NotSupportedException("Overrides in other classes");
        }
        //virtual - not required
        public virtual double CalculatePerimeter()
        {
            throw new NotSupportedException("Calculates Perimeter in child classes");
        }
        public virtual void Draw()
        {
            throw new NotSupportedException("I do not touch that shit");
        }
        public virtual double CalculateDiagonal()
        {
            throw new NotSupportedException("Only in rectangle and parallelogram");
        }
        public virtual string GetSummary()
        {

            StringBuilder newSBS = new StringBuilder();
            newSBS.Append("Благодаря, че използвахте калкулатора! Кратка информация:\n" +
                        $"{GetShapeInfo}");
            return newSBS.ToString();
        }
        

    }

}
