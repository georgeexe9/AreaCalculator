using AreaCalculator.Triangles;
using System.Text;

namespace AreaCalculator
{
    public partial class TriangleForm : UserControl
    {
        public TriangleForm()
        {
            InitializeComponent();
            panelInfo.Visible = false;
            CalculateRightTriangle();

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
            InformationalLabel.Text = "";
            panelInfo.Visible = false;
        }
        private void ShowMessage(string message, Color forecolor)
        {
            panelInfo.Visible = true;
            InformationalLabel.Text = message;
            InformationalLabel.ForeColor = forecolor;
        }
        private bool AreNotBoxesEmpty()
        {
            return !string.IsNullOrEmpty(SideABox.Text) &&
                !string.IsNullOrEmpty(SideBBox.Text) &&
                !string.IsNullOrEmpty(SideCBox.Text) &&
                !string.IsNullOrEmpty(HeightBox.Text);
        }


        private void CalculateTriangle()
        {
            if (AreNotBoxesEmpty())
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

                    StringBuilder newSBS = new StringBuilder();
                    newSBS.AppendLine($"Лице S - {area}");
                    newSBS.AppendLine($"Периметър P - {perimeter} ");
                    panelInfo.Visible = true;
                    string result = newSBS.ToString();
                    ShowMessage(result, Color.White);

                    //
                }
                catch (ArgumentException ex)
                {
                    ShowMessage(ex.Message, Color.Red);

                }
                catch (FormatException)
                {
                    ShowMessage("Моля, въведете валидни\n положителни данни", Color.Red);
                }

            }
            else
            {
                ShowMessage("Моля, въведете данни в полетата!", Color.Red);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();

        }

        private void TriangleForm_Load(object sender, EventArgs e)
        {

        }
        private static void CalculateRightTriangle()
        {
            double sideA = 3;
            double sideB = 4;
            Shape rightTriangle = new RightTriangle(sideA, sideB);
            double area = rightTriangle.CalculateArea();
            double perimeter = rightTriangle.CalculatePerimeter();
            ///
            // Кастинг – правя се на нещо, което не съм, като временно обличам маска,
            // за да се държа като друг тип пред хората. 😀
            // Например, променливата rightTriangle е от тип Shape (форма),
            // но всъщност съдържа обект от RightTriangle (правоъгълен триъгълник).
            // За да използвам специфичното свойство Hypotenuse, трябва да я кастна към RightTriangle.
            // Като човек, който се прави на някой друг, за да постигне целта си.
            
            ///
            
            double hypotenuse = ((RightTriangle)rightTriangle).Hypotenuse;

            StringBuilder sbs = new StringBuilder();
            sbs.AppendLine($"Лице - {area}");
            sbs.AppendLine($"Периметър - {perimeter}");
            sbs.AppendLine($"Хипотенуза - {hypotenuse}");
            MessageBox.Show(sbs.ToString(), "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}