using AreaCalculator.Helpers;
using AreaCalculator.Triangles;

namespace AreaCalculator
{
    /// <summary>
    ///  Summary:
    ///  Displays all about => TRIANGLES <=
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

        public TriangleForm()
        {
            InitializeComponent();
            panelInfo.Visible = false;
            Infopanel.Visible = false;
            Helper.ConfigureChoiceBox(TriangleChoiceBox);


        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateTriangle();
        }
        //Изчиства съдържанието
        //тва ще се раздели на три метода
        private void ResetAllTextBoxes()
        {
           Helper.ClearAllTextBoxes(SideABox, SideBBox, SideCBox, HeightBox);
            HelperTriangles.ConfigureLabelsbyDefauth(SideALabel, SideBLabel, SideBLabel, HeightLabel);
            HelperTriangles.ConfigureTextBoxesbyDefauth(SideABox, SideBBox, SideCBox, HeightBox);
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
                        if (Helper.VerifyValidationIsOk(SideABox, SideBBox, out sideA, out sideB))
                        {
                            var rightTriangle = new RightTriangle(sideA, sideB);
                            GetCalculatedTriangle(rightTriangle);
                        }
                        break;
                    //Произволен триъгълник
                    case TriangleChoices.Triangle:
                        if (Helper.VerifyValidationIsOk(SideABox, SideBBox, SideCBox, HeightBox, out sideA, out sideB, out sideC, out height))
                        {
                            var triangle = new Triangle(sideA, sideB, sideC, height);
                            GetCalculatedTriangle(triangle);
                        }
                        break;
                    //Равнобедрен триъгълник
                    case TriangleChoices.IsoscelesTriangle:
                        if (Helper.VerifyValidationIsOk(SideABox, SideBBox, out sideA, out sideB))
                        {
                            var isosceleTriangle = new Isoscelestriangle(sideA, sideB);
                            GetCalculatedTriangle(isosceleTriangle);
                        }
                        break;
                    //Равностранен триъгълник
                    case TriangleChoices.EquilateralTriangle:
                        if (Helper.VerifyValidationIsOk(SideABox, out sideA))
                        {
                            var equilateralTriangle = new EquilateralTriangle(sideA);
                            GetCalculatedTriangle(equilateralTriangle);

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

            HelperTriangles.ConfigureUITextBox(type, SideABox, SideBBox, SideCBox, HeightBox);
            HelperTriangles.ConfigureUITriangleLabels(type, SideALabel, SideBLabel, Infopanel, formula, InformationalLabel, nameTriangle);
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
        /// <summary>
        /// Calculates area and perimeter of shape triangles object
        /// </summary>
        /// <param name="triangle"></param>
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