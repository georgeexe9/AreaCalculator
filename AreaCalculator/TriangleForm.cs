using AreaCalculator.Helpers;
using AreaCalculator.Triangles;

namespace AreaCalculator
{
    public partial class TriangleForm : UserControl
    {


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
      
         
        //Основен метод
        private void CalculateTriangle()
        {
            if (TriangleChoiceBox.SelectedItem == null)
            {
                Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, "Моля избери триъгълник!", Color.Red);
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
                //string summary = "";

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
                        //ShowMessageResult(area, perimeter, Color.White);
                        Helper.ShowMessageResult(panelInfo, InformationalLabel, area, perimeter, Color.White);
                        
                        break;

                    case "Произволен триъгълник":
                        Shape triangle = new Triangle(sideA, sideB, sideC, height);
                        area = triangle.CalculateArea();
                        perimeter = triangle.CalculatePerimeter();
                        Helper.ShowMessageResult(panelInfo, InformationalLabel, area, perimeter, Color.White);
                        break;

                    case "Равнобедрен триъгълник":
                        Shape isoscelestriangle = new Isoscelestriangle(sideA, sideB);
                        area = isoscelestriangle.CalculateArea();
                        perimeter = isoscelestriangle.CalculatePerimeter();
                        double h = ((Isoscelestriangle)isoscelestriangle).Height;
                        HeightBox.Text = h.ToString();
                        Helper.ShowMessageResult(panelInfo, InformationalLabel, area, perimeter, Color.White);
                        
                        break;
                    case "Равностранен триъгълник":

                        break;

                    default:
                        Helper.ShowExceptionalMessage(panelInfo,InformationalLabel,"Няма такъв триъгълник! Неподдържана фигура!", Color.Red);
                        break;
                }
            }
            catch (FormatException)
            {
                Helper.ShowExceptionalMessage(panelInfo, InformationalLabel,"Моля въведете числови стойности!", Color.Red);
            }
            catch (ArgumentException ex)
            {
                Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, ex.Message, Color.Red);
            }
            catch (Exception ex)
            {
                Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, ex.Message, Color.Red);
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
                    ClearAllTextBoxes();
                    break;
                case "Произволен триъгълник":
                    ShowInformatioalPanel(triangleType, "Area= 0.5 * a * h \n Perimeter = a + b + c");
                    ClearAllTextBoxes();
                    break;
                case "Равнобедрен триъгълник":
                    //да сменя името на втория лейбъл на основа
                    SideCBox.Enabled = false;
                    HeightBox.Enabled = false;
                    ClearAllTextBoxes();
                    break;

            }

        }

        private void Infopanel_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}