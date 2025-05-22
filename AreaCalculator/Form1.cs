namespace AreaCalculator
{
    public partial class CalculatorMainFrom : Form
    {
        Calculator calculator = new Calculator();
        public CalculatorMainFrom()
        {
            InitializeComponent();
        }

        private void CalculatorMainFrom_Load(object sender, EventArgs e)
        {


        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double square = double.Parse(SquareAside.Text);
            double squareArea = calculator.SquareArea(square);
            SquareAreaResult.Text = $"Лицето е {squareArea}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sideA = double.Parse(SideARectangle.Text);
            double sideB = double.Parse(SideBRectangle.Text);
            double rectangleArea = calculator.RectangleArea(sideA, sideB);
            RectangleAreaResult.Text = $"Лицето е {rectangleArea}";
        }
    }
}
