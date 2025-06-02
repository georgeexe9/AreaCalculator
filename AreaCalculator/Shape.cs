using System.Text;

namespace AreaCalculator
{

    /// <summary>
    /// =======
    /// AreaCalculator project written by George Lavchanski
    /// Written in C#, WindowsForms
    /// Used OOP, Abstraction
    /// ============= get to know ;) =============================================================================
    /// 1. Абстракцията скрива детайлите от потребителя, показвайки само крайния резултат.
    /// Тя позволява да работим с обекти без да знаем как точно функционират вътре.
    ///  
    ///  
    /// 2 .Примери за абстракция включват: 
    /// любов, форма, връзка, SQL връзка, животни,
    /// хора, начини на поведение,психика, управление на устройства и други.
    /// Примери:
    /// 
    /// public partial abstract Love 
    /// 
    ///
    ///
    /// 3. Методите се дефинират абстрактно в базовия клас и се имплементират в наследниците.
    /// Например, методът CalculateArea() е абстрактен и се пренаписва според вида фигура.
    ///
    /// Лицето на квадрат и триъгълник се изчисляват по различни формули.
    ///
    /// Абстрактните класове са шаблони и не могат да се създават директно като обекти.
    ///
    /// Примерни наследници на Shape са: Triangle, Rectangle, Parallelogram, Trapezoid, Square, Ellipse.
    ///
    /// Обект от наследник може да се създаде и държи чрез променлива от тип Shape:
    /// Shape (променлива)shape = new Triangle((,където sideA и height са параметри от конструктора)sideA, height);
    /// shape.CalculateArea();
    /// 
    /// 
    /// 
    /// 
    /// </summary>

    /// </summary>

    public abstract class Shape
    {

        //ще се override-ва във всичките класове
        public abstract double CalculateArea();
        //виртуален - незадължителен метод,
        //ще се override-ва(пренаписва), където пожелая
        //ще бъде нормална абструкция, не виртуален сроко
        public virtual string GetShapeName()
        {
            throw new NotSupportedException("няма да се имплементира. В процес на строеж в други класове");
        }
        //виртуален - незадължителен метод
        public virtual double CalculatePerimeter()
        {
            throw new NotSupportedException("Този метод ще бъде override-нат по-късно! Ако го извикате, ще даде грешка");
        }
        public virtual void Draw()
        {
            throw new NotSupportedException("Бъдещо разширение..., най-вероятно");
        }
        public virtual string GetSummary()
        {
            //инициализация на нов newSBS от тип StringBuilder
            StringBuilder newSBS = new StringBuilder();
            newSBS.Append("Благодаря, че използвахте калкулатора! Кратка информация:\n" +
                        $"Фигура: {GetShapeName()}\n" +
                        $"Лице/Площ: {CalculateArea()}\n" +
                        $"Периметър: {CalculatePerimeter()}");
           
            
            //връща -> to string
            return newSBS.ToString();


        }

    }

}
