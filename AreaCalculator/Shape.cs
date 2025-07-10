using System.Text;

namespace AreaCalculator
{
   
    public abstract class Shape
    {
        public abstract double CalculateArea();
       
        public virtual string GetShapeName()
        {
            throw new NotSupportedException("няма да се имплементира. В процес на строеж в други класове");
        }
        //виртуален - незадължителен метод
        public  virtual double CalculatePerimeter()
        {
            throw new NotSupportedException("Този метод ще бъде override-нат по-късно! Ако го извикате, ще даде грешка");
        }
        public virtual void Draw()
        {
            throw new NotSupportedException("Бъдещо разширение..., най-вероятно");
        }
        public virtual double CalculateDiagonal()
        {
            throw new NotSupportedException("Само в правоъгълник");
        }
        public virtual string GetSummary()
        {
            
            StringBuilder newSBS = new StringBuilder();
            newSBS.Append("Благодаря, че използвахте калкулатора! Кратка информация:\n" +
                        $"Фигура: {GetShapeName()}\n" +
                        $"Лице/Площ: {CalculateArea()}\n" +
                        $"Периметър: {CalculatePerimeter()}");
          
          
            return newSBS.ToString();


        }

    }

}
