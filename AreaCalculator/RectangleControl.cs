
using AreaCalculator.Helpers;

namespace AreaCalculator
{
    public partial class RectangleControl : UserControl
    {
        private double side;
        private double sideB;
        private double area;
        private double perimeter;
        private List<string> summary = new List<string>();
        private HelperTriangleUIControls UI;

        public RectangleControl()
        {
            InitializeComponent();
            Infopanel.Visible = false;
            panelInfo.Visible = false;
        }

        public void CalculateRectangle()
        {
            try
            {
                if (Helper.VerifyValidationIsOk(UI,out side, out sideB))
                {
                    var rectangle = new Rectangle(side, sideB);
                    Calculate(rectangle);

                    Helper.ShowInformationalPanel(Infopanel, formula, RectangleName, "Правоъгълник", "ee");
                }
                else
                {
                    Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, "Моля въведете числови стойности!", Color.White, Color.Red);
                }

            }
            catch (ArgumentException ex)
            {
                Helper.ShowExceptionalMessage(panelInfo, InformationalLabel, ex.Message, Color.White, Color.Red);
            }

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateRectangle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Helper.ClearAllTextBoxes(SideABox, SideBBox);
            Helper.ClearListView(listSummary);
            Infopanel.Visible = false;
            panelInfo.Visible = false;
        }
        private void Calculate(Shape rectangle)
        {
            perimeter = rectangle.CalculatePerimeter();
            area = rectangle.CalculateArea();
            summary = rectangle.GetSummary();
            Helper.ShowMessageResult(panelInfo, InformationalLabel, area, perimeter);
            Helper.FillListSummary(listSummary, summary);
        }

        private void RectangleName_Click(object sender, EventArgs e)
        {

        }
    }
}
