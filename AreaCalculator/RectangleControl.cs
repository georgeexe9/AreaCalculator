namespace AreaCalculator
{
    public partial class RectangleControl : UserControl
    {
        public RectangleControl()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateRectangle();
        }
        private void CalculateRectangle()
        {
            if (!string.IsNullOrEmpty(SideABox.Text) && !string.IsNullOrEmpty(SideBBox.Text))
            {
                try
                {
                    double sideA = double.Parse(SideABox.Text);
                    double sideB = double.Parse(SideBBox.Text);
                    Shape rectangle = new Rectangle(sideA, sideB);

                    double area = rectangle.CalculateArea();
                    double perimeter = rectangle.CalculatePerimeter();

                    if (diagonalRadioButton.Checked)
                    {
                        double diagonal = rectangle.CalculateDiagonal();
                        InformationalLabel.Text = $"Лице/Площ - {area}, Периметър - {perimeter}, " +
                            $"Диагонал - {diagonal:F2}";
                    }
                    else
                    {
                        InformationalLabel.Text = $"Лице/Площ - {area}, Периметър - {perimeter}";
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Моля, въведете правилни стойности!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Моля, въведете стойности!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
        }

        private void ClearAllTextBoxes()
        {
            SideABox.Clear();
            SideBBox.Clear();
            diagonalRadioButton.Checked = false;

        }
    }
}
