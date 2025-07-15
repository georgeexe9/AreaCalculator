using System.Text;

namespace AreaCalculator
{
    public partial class TriangleForm : UserControl
    {
        public TriangleForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateTriangle();
        }
        private void ClearAllTextBoxes()
        {
            SideABox.Clear();
            SideBBox.Clear();
            SideCBox.Clear();
            HeightBox.Clear();
        }
        private void CalculateTriangle()
        {
            if (!string.IsNullOrEmpty(SideABox.Text) && !string.IsNullOrEmpty(SideBBox.Text) && !string.IsNullOrEmpty(SideCBox.Text) && !string.IsNullOrEmpty(HeightBox.Text))
            {
                try
                {
                    double sideA = double.Parse(SideABox.Text);
                    double sideB = double.Parse(SideBBox.Text);
                    double sideC = double.Parse(SideCBox.Text);
                    double Height = double.Parse(HeightBox.Text);

                    Shape triangle = new Triangle(sideA, sideB, sideC, Height);
                    double area = triangle.CalculateArea();
                    double perimeter = triangle.CalculatePerimeter();


                    label1.Text = $"Лицето/Площта - {area}, Периметър - {perimeter}";
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Моля, въведете правилни стойности!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Моля, въведете данни, за да се направят изчисленията!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
        }

        private void TriangleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
