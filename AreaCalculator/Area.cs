namespace AreaCalculator
{
    public partial class CalculatorMainFrom : Form
    {
        /// <summary>
        /// ИЗПОЛЗВАМ АБСТРАКЦИЯ КАТО СКРИВАМ НЕНУЖНАТА ИНФОРАМИЦИЯ ЗА ПОТРЕБИТЕЛЯ
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



            double side = double.Parse(SquareAside.Text);
            Shape shape = new Square(side);
            double squareArea = shape.CalculateArea();
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
