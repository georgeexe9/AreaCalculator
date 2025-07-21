using System.Text;

namespace AreaCalculator
{

    public abstract class Shape
    {
        /// <summary>
        /// TODO - имплементирай GetShapeInfo навсякъде в другите класове
        /// </summary>
        /// <returns></returns>

        //изчислява лице/площ
        public abstract double CalculateArea();

        //връща пълна информация за фигурата
        public virtual string GetShapeInfo()
        {
            //търси логика в другите класове в тва assembly
            throw new NotSupportedException("временно виртуален метод");
        }

        //МЕТОД НА STANDBY ;) 
        [Obsolete("Този метод е морално остарял, използвайте GetShapeInfo()")]
        public virtual string GetShapeName()
        {
            throw new NotSupportedException("Override-ва се в другите класове");
        }
        //виртуален - незадължителен метод
        public virtual double CalculatePerimeter()
        {
            throw new NotSupportedException("Този метод ще бъде override-нат по-късно! Ако го извикате, ще даде грешка");
        }
        public virtual void Draw()
        {
            throw new NotSupportedException("Бъдещо разширение..., най-вероятно не");
        }
        public virtual double CalculateDiagonal()
        {
            throw new NotSupportedException("Само в правоъгълник и успоредник");
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
