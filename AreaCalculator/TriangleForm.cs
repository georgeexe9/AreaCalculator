using AreaCalculator.Triangles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace AreaCalculator
{
    public partial class TriangleForm : UserControl
    {

        //Конструктор
        public TriangleForm()
        {
            InitializeComponent();
            panelInfo.Visible = false;
            Infopanel.Visible = false;
            ClearAllTextBoxes();




        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateTriangle();
        }
        //Изчиства съдържанието
        private void ClearAllTextBoxes()
        {
            SideABox.Clear();
            SideBBox.Clear();
            SideCBox.Clear();
            HeightBox.Clear();
            SideABox.Enabled = true;
            SideBBox.Enabled = true;
            SideCBox.Enabled = true;
            HeightBox.Enabled = true;
            InformationalLabel.Text = "";
            panelInfo.Visible = false;
        }

        //Показва информация на избрания триъгълник
        private void ShowInformatioalPanel(string shape, string formula)
        {
            Infopanel.Visible = true;
            formulas.Text = formula;
            TriangleName.Text = shape;

        }
        //Показва резултата на избрания триъгълник
        private void ShowMessageResult(double area, double perimeter, Color forecolor)
        {
            panelInfo.Visible = true;
            InformationalLabel.Text = $"Лице: {area:F2} cm.\n Периметър: {perimeter:F2} cm.";
            InformationalLabel.ForeColor = forecolor;
        }
        //Показва съобщение при грешка
        private void ShowExceptionalMessage(string message, Color forecolor)
        {
            panelInfo.Visible = true;
            InformationalLabel.Text = message;
            InformationalLabel.ForeColor = forecolor;
        }



        //Основен метод
        private void CalculateTriangle()
        {
            if (TriangleChoiceBox.SelectedItem == null)
            {
                ShowExceptionalMessage("Моля избери триъгълник!", Color.Red);
                return;
            }

            try
            {
                string? triangleType = TriangleChoiceBox.SelectedItem.ToString();


                double sideA = double.Parse(SideABox.Text);
                double sideB = double.Parse(SideBBox.Text);
                double sideC = 0;
                double height = 0;
                double area = 0;
                double perimeter = 0;
                string summary = "";

                if (triangleType == "Произволен триъгълник")
                {
                    sideC = double.Parse(SideCBox.Text);
                    height = double.Parse(HeightBox.Text);
                }



                switch (triangleType)
                {
                    case "Правоъгълен триъгълник":
                        Shape rightTriangle = new RightTriangle(sideA, sideB);
                        area = rightTriangle.CalculateArea();
                        perimeter = rightTriangle.CalculatePerimeter();                      
                        ShowMessageResult(area, perimeter, Color.White);
                        break;

                    case "Произволен триъгълник":
                        Shape triangle = new Triangle(sideA, sideB, sideC, height);
                        area = triangle.CalculateArea();
                        perimeter = triangle.CalculatePerimeter();
                        ShowMessageResult(area, perimeter, Color.White);
                        break;

                    case "Равнобедрен триъгълник":
                        break;
                    case "Равностранен триъгълник":

                        break;

                    default:
                        ShowExceptionalMessage("Няма такъв триъгълник! Неподдържана фигура!", Color.Red);
                        break;
                }
            }
            catch (FormatException)
            {
                ShowExceptionalMessage("Моля въведете числови стойности!", Color.Red);
            }
            catch (ArgumentException ex)
            {
                ShowExceptionalMessage(ex.Message, Color.Red);
            }
            catch (Exception ex)
            {
                ShowExceptionalMessage(ex.Message, Color.Red);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();

        }
        //Контрол над формите
        private void TriangleChoiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
            string? triangleType = TriangleChoiceBox.SelectedItem?.ToString();
            switch (triangleType)
            {
                case "Правоъгълен триъгълник":
                    SideCBox.Enabled = false;
                    HeightBox.Enabled = false;
                    ShowInformatioalPanel(triangleType, "Area = (1/2) * a * b \n Perimeter = a + b + c");
                    break;
                case "Произволен триъгълник":
                    ShowInformatioalPanel(triangleType, "Area= 0.5 * a * h \n Perimeter = a + b + c");
                    break;
            }

        }

        private void Infopanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}