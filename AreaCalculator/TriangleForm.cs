using AreaCalculator.Helpers;
using AreaCalculator.Triangles;

namespace AreaCalculator
{
    /// <summary>
    ///  Summary:
    ///      
    /// </summary>
    public partial class TriangleForm : UserControl
    {
        private int triangleType;
        public double sideA;
        public double sideB;
        public double sideC;
        public double height;
        public double area;
        public double perimeter;



        public TriangleForm()
        {
            InitializeComponent();
            panelInfo.Visible = false;
            Infopanel.Visible = false;
            TriangleChoiceBox.Items.Insert(0, "-Избери триъгълник-");
            TriangleChoiceBox.SelectedIndex = 0;
            
            


        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateTriangle();
        }
        //Изчиства съдържанието
        private void ResetAllTextBoxes()
        {
            SideABox.Clear();
            SideBBox.Clear();
            SideCBox.Clear();
            HeightBox.Clear();
            SideABox.Enabled = true;
            SideBBox.Enabled = true;
            SideCBox.Enabled = true;
            HeightBox.Enabled = true;
            SideABox.Visible = true;
            SideBBox.Visible = true;
            SideCBox.Visible = true;
            HeightBox.Visible = true;
            InformationalLabel.Text = "";
            panelInfo.Visible = false;
            SideALabel.Text = "Страна а:";
            SideBLabel.Text = "Страна b:";
            SideCLabel.Text = "Страна c:";
            HeightLabel.Text = "Височина h:";
            Infopanel.Visible = false;
            panelInfo.Visible = false;

        }
        public void ClearBox()
        {
            SideABox.Clear();
            SideBBox.Clear();
            SideCBox.Clear();
            HeightBox.Clear();
        }
        //Тва ще се изнася в Helper класа
        private void UITriangleControl()
        {
            //ResetAllTextBoxes();

            triangleType = TriangleChoiceBox.SelectedIndex;
            string? triangleName = TriangleChoiceBox.Items[triangleType]?.ToString();
            //clear the selection
            if (triangleName == null)
            {

                return;
            }

            switch (triangleType)
            {
                case 1:

                    Helper.ShowInformationalPanel(Infopanel, formula, TriangleName, triangleName, "Area = (1/2) * a * b \n Perimeter = a + b + c");
                    SideCBox.Enabled = false;
                    HeightBox.Enabled = false;
                    break;
                case 2:
                    Helper.ShowInformationalPanel(Infopanel, formula, TriangleName, triangleName, "Area= 0.5 * a * h \n Perimeter = a + b + c");

                    break;
                case 3:
                    Helper.ShowInformationalPanel(Infopanel, formula, TriangleName, triangleName, "Area= (Base * Height) / 2 \n Perimeter = 2 * Side + Base");
                    SideCBox.Enabled = false;
                    SideALabel.Text = "Страна:";
                    SideBLabel.Text = "Основа:";
                    break;
                case 4:
                    Helper.ShowInformationalPanel(Infopanel, formula, TriangleName, triangleName, "Area= (Base * Height) / 2 \n Perimeter = 3 * Side");
                    SideBBox.Enabled = false;
                    SideCBox.Enabled = false;
                    HeightBox.Enabled = false;
                    SideALabel.Text = "Страна:";
                    break;
            }

        }

        private void CalculateTriangle()
        {
            try
            {
                //Взима индекса на текущия избран триъгълник(ред(string)) от ComboBox
                //int triangleType = 0 - "Избери триъгълник"
                //int triangleType =  1 - Правоъгълен триъгълник,
                //2 - Произволен триъгълник,
                //3 - Равнобедрен,
                //4 - Равностранен
                triangleType = TriangleChoiceBox.SelectedIndex;

                if (triangleType == 0)
                {
                    Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, "Няма избран триъгълник!", Color.White, Color.Red);
                    ResetAllTextBoxes();
                }
                switch (triangleType)
                {
                    case 1:
                        //Правоъгълен триъгълник
                        CalculateRightTriangle();
                        break;
                    //Произволен триъгълник
                    case 2:
                        CalculateTriangles();
                        break;
                    //Равнобедрен триъгълник
                    case 3:
                        CalculateIsoscelestriangle();
                        break;
                    //Равностранен триъгълник
                    case 4:
                        CalculateEquilateralTriangle();
                        break;
                    //Ако не е избран триъгълник (или друга причина)
                    default:
                        Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, "Няма такъв триъгълник! Неподдържана фигура!", Color.White, Color.Red);
                        break;
                }
            }
            catch (FormatException)
            {
                Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, "Моля въведете числови стойности!", Color.White, Color.Red);
            }
            catch (ArgumentException ex)
            {
                Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, ex.Message, Color.White, Color.Red);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ClearBox();
        }

        //Контрол над формите
        private void TriangleChoiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UITriangleControl();
        }

        private void ResetTriangles_Click(object sender, EventArgs e)
        {
            TriangleChoiceBox.SelectedIndex = 0;
            ResetAllTextBoxes();

        }
        public void CalculateTriangles()
        {
            if (Helper.VerifyValidationIsOk(SideABox, SideBBox, SideCBox, HeightBox, out sideA, out sideB, out sideC, out height))
            {
                Shape triangle = new Triangle(sideA, sideB, sideC, height);
                area = triangle.CalculateArea();
                perimeter = triangle.CalculatePerimeter();
                string summaryInfo = triangle.GetSummary();
                Helper.FillListSummary(listSummary, summaryInfo);
                Helper.ShowMessageResult(panelInfo, InformationalLabel, area, perimeter);
            }
            else
            {
                Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, "Моля въведете числови\n стойности!", Color.White, Color.Red);
            }
           
        }
        public void CalculateRightTriangle()
        {
            if (Helper.VerifyValidationIsOk(SideABox, SideBBox, out sideA, out sideB))
            {
                Shape rightTriangle = new RightTriangle(sideA, sideB);
                area = rightTriangle.CalculateArea();
                perimeter = rightTriangle.CalculatePerimeter();
                string summaryInfo = rightTriangle.GetSummary();
                Helper.FillListSummary(listSummary, summaryInfo);
                Helper.ShowMessageResult(panelInfo, InformationalLabel, area, perimeter);
            }
            else
            {
                Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, "Моля въведете числови\n стойности!", Color.White, Color.Red);
            }

        }
        private void CalculateIsoscelestriangle()
        {
            if (Helper.VerifyValidationIsOk(SideABox, SideABox, out sideA, out sideB))
            {
                Shape isoscelestriangle = new Isoscelestriangle(sideA, sideB);
                area = isoscelestriangle.CalculateArea();
                perimeter = isoscelestriangle.CalculatePerimeter();
                //tried casting for first time
                //Кажи на Равнобедрения триъгълник, че е равнобедрен триъгълник, а не общо , че е фигура ;)
                double h = ((Isoscelestriangle)isoscelestriangle).Height;
                string summaryInfo = isoscelestriangle.GetSummary();
                Helper.FillListSummary(listSummary,summaryInfo);
                HeightBox.Text = h.ToString();
                Helper.ShowMessageResult(panelInfo, InformationalLabel, area, perimeter);
            }
            else
            {
                Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, "Моля въведете числови\n стойности!", Color.White, Color.Red);
            }

        }
        private void CalculateEquilateralTriangle()
        {
            if (Helper.VerifyValidationIsOk(SideABox, out sideA))
            {
                Shape equilateralTriangle = new EquilateralTriangle(sideA);
                area = equilateralTriangle.CalculateArea();
                perimeter = equilateralTriangle.CalculatePerimeter();
                string summaryInfo = equilateralTriangle.GetSummary();
                Helper.FillListSummary(listSummary,summaryInfo);
                Helper.ShowMessageResult(panelInfo, InformationalLabel, area, perimeter);
            }
            else
            {
                Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, "Моля въведете числови\n стойности!", Color.White, Color.Red);
            }

        }
        
        


    }
}