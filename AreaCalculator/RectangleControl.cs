
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
        private HelperRectangleUIControls RecUI;

        public RectangleControl()
        {
            InitializeComponent();
            Infopanel.Visible = false;
            panelInfo.Visible = false;
            RecUI = new HelperRectangleUIControls(SideABox, SideBBox, SideALabel, SideBLabel);
        }

        public void CalculateRectangle()
        {
            try
            {
                if (Helper.VerifyValidationIsOk(RecUI,out side, out sideB))
                {
                    var rectangle = new Rectangle(side, sideB);
                    CalculateRectangle(rectangle);

                    Helper.ShowInformationalPanel(Infopanel);
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
        private void CalculateRectangle(Shape rectangle)
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
