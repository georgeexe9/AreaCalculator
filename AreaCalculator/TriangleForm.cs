using AreaCalculator.Helpers;
using AreaCalculator.Triangles;

namespace AreaCalculator
{
    /// <summary>
    ///  Displays Triangle Control
    ///  - Calculates every triangle
    /// 
    /// </summary>
    public partial class TriangleForm : UserControl
    {

        private int triangleType;
        private double sideA;
        private double sideB;
        private double sideC;
        private double height;
        private double area;
        private double perimeter;
        private List<string> summary = new List<string>();
        private readonly HelperTriangleUIControls triangleUI;


        public TriangleForm()
        {
            InitializeComponent();
            panelInfo.Visible = false;
            Infopanel.Visible = false;
            Helper.ConfigureChoiceBox(TriangleChoiceBox);
            triangleUI = new HelperTriangleUIControls(SideABox, SideBBox, SideCBox, HeightBox, SideALabel, SideBLabel, SideCLabel, HeightLabel);

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateTriangle();
        }
        private void ResetAllTextBoxes()
        {
            Helper.ClearAllTextBoxes(SideABox, SideABox);
            HelperTriangles.ConfigureLabelsByDefault(triangleUI);
            HelperTriangles.ConfigureTextBoxesByDefault(triangleUI);
            InformationalLabel.Text = "";
            panelInfo.Visible = false;
            Infopanel.Visible = false;


        }

        //Тва ще се изнася в Helper класа

        private void CalculateTriangle()
        {
            try
            {
                triangleType = TriangleChoiceBox.SelectedIndex;
                TriangleChoices type = (TriangleChoices)triangleType;

                switch (type)
                {
                    case TriangleChoices.Non:
                        MessageBox.Show("Няма избран триъгълник!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, "Няма избран триъгълник!", Color.White, Color.Red);
                        ResetAllTextBoxes();
                        break;
                    case TriangleChoices.Right_Triangle:
                        //Правоъгълен триъгълник
                        if (Helper.VerifyValidationIsOk(triangleUI, out sideA, out sideB))
                        {
                            RightTriangle rightTriangle = new RightTriangle(sideA, sideB);
                            GetCalculatedTriangle(rightTriangle);
                        }
                        else
                        {
                            Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, "Моля въведете числови стойности!", Color.White, Color.Red);
                        }

                        break;
                    //Произволен триъгълник
                    case TriangleChoices.Triangle:
                        if (Helper.VerifyValidationIsOk(triangleUI, out sideA, out sideB, out sideC, out height))
                        {
                            Triangle triangle = new Triangle(sideA, sideB, sideC, height);
                            GetCalculatedTriangle(triangle);
                        }
                        else
                        {
                            Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, "Моля въведете числови стойности!", Color.White, Color.Red);

                        }

                        break;
                    //Равнобедрен триъгълник
                    case TriangleChoices.IsoscelesTriangle:
                        if (Helper.VerifyValidationIsOk(triangleUI, out sideA, out sideB))
                        {
                            Isoscelestriangle isosceleTriangle = new Isoscelestriangle(sideA, sideB);
                            GetCalculatedTriangle(isosceleTriangle);
                        }
                        else
                        {
                            Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, "Моля въведете числови стойности!", Color.White, Color.Red);

                        }
                        break;
                    //Равностранен триъгълник
                    case TriangleChoices.EquilateralTriangle:
                        if (Helper.VerifyValidationIsOk(triangleUI, out sideA))
                        {
                            EquilateralTriangle equilateralTriangle = new EquilateralTriangle(sideA);
                            GetCalculatedTriangle(equilateralTriangle);

                        }
                        else
                        {
                            Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, "Моля въведете числови стойности!", Color.White, Color.Red);

                        }
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

            Helper.ClearAllTextBoxes(SideABox, SideBBox, SideCBox, HeightBox);
        }
        private void UIControlTriangle()
        {
            var type = (TriangleChoices)TriangleChoiceBox.SelectedIndex;

            string? nameTriangle = TriangleChoiceBox.GetItemText(TriangleChoiceBox.SelectedIndex);

            HelperTriangles.ConfigureUITextBox(triangleUI, type);
            HelperTriangles.ConfigureUITriangleLabels(triangleUI, type, Infopanel, formula, InformationalLabel, nameTriangle);
            Helper.ClearListView(listSummary);
            Helper.ClearAllTextBoxes(SideABox, SideBBox, SideCBox, HeightBox);

        }

        //Контрол над формите
        private void TriangleChoiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIControlTriangle();
        }

        private void ResetTriangles_Click(object sender, EventArgs e)
        {
            TriangleChoiceBox.SelectedIndex = 0;
            ResetAllTextBoxes();

        }

        private void GetCalculatedTriangle(Shape triangle)
        {

            area = triangle.CalculateArea();
            perimeter = triangle.CalculatePerimeter();
            summary = triangle.GetSummary();
            Helper.ShowMessageResult(panelInfo, InformationalLabel, area, perimeter);
            Helper.FillListSummary(listSummary, summary);

        }


    }
}