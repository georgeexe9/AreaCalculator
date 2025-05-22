namespace AreaCalculator
{
    public partial class CalculatorMainFrom : Form
    {
        
        public CalculatorMainFrom()
        {
            InitializeComponent();
        }

        private void CalculatorMainFrom_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double square = double.Parse(SquareAside.Text);
            double squareArea = Calculator.SquareArea(square);
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
            double triangleArea = Calculator.TriangleArea(sideA, height);
            AreaTriangle.Text = $"Лицето е {triangleArea}";
        }

        private void изчистиПолетаToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            Calculator.ClearAllBoxes(SquareAside,sideATriangle,SideBRectangle,SideARectangle,heightTriangle);
        }
    }
}
