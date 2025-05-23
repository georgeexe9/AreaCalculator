namespace AreaCalculator
{
    public partial class CalculatorMainFrom : Form
    {
        /// <summary>
        /// ========================= AREA CALCULATOR C# .NET APPLICATION ;)=============================
        /// The purpose of this project is to demonstrate how object-oriented abstraction works.
        /// I have used a public abstract class named 'Shape', which is inherited by other non-sealed classes,
        /// in order to hide their internal implementation from the user and expose only the final result (e.g., area). 
        ///
        /// 
        ///
        /// ABSTRACT SHAPE
        /// ----> INHERITED BY INTERNAL CIRCLE, ELLIPSE, SQUARE, RECTANGLE, TRIANGLE, TRAPEZOID.
        /// 
        /// </summary>

        public CalculatorMainFrom()
        {
            InitializeComponent();
        }

        private void CalculatorMainFrom_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {


            //животът на променливата е кратък като моя!
            double side = double.Parse(SquareAside.Text);
           //създаваме нова инстанция Квадрат от абстрактен тип Форма
           //присвояваме променливата side в абстрактия клас Форма
            Shape shape = new Square(side);
            //Извикваме CalculateArea без да ни интересува как подяволите работи,
            //защриховаме към променлива от същия типаж
            double squareArea = shape.CalculateArea();
            //визуализираме резултата в лейбъл
            SquareAreaResult.Text = $"Лицето е {squareArea}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sideA = double.Parse(SideARectangle.Text);
            double sideB = double.Parse(SideBRectangle.Text);
            Shape shape = new Rectangle(sideA, sideB);
            double rectangleArea = shape.CalculateArea();
            RectangleAreaResult.Text = $"Лицето е {rectangleArea}";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double sideA = double.Parse(sideATriangle.Text);
            double height = double.Parse(heightTriangle.Text);
            Shape shape = new Triangle(sideA, height);
            double triangleArea = shape.CalculateArea();
            AreaTriangle.Text = $"Лицето е {triangleArea}";
        }

        //private void ПолетаToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Calculator.ClearAllBoxes(SquareAside, sideATriangle, SideBRectangle, SideARectangle, heightTriangle);
        //}
    }
}
