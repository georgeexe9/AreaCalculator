using AreaCalculator.Helpers;
namespace AreaCalculator
{

    public partial class CalculatorMainFrom : Form
    {

        readonly HomeControlcs hc = new HomeControlcs();
        public CalculatorMainFrom()
        {
            InitializeComponent();
            HelperAreaUI.ConfigureMainPanel(MainPanel,hc);
            HelperAreaUI.ConfigureNavBars(splitContainer1,panel2D);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TriangleForm tr = new TriangleForm();
            HelperAreaUI.ConfigureUserControls(MainPanel, tr);
        }

        private void RectangleControlButton_Click(object sender, EventArgs e)
        {
            RectangleControl r = new RectangleControl();
            HelperAreaUI.ConfigureUserControls(MainPanel, r);
        }

        private void ParallelogramButtonControl_Click(object sender, EventArgs e)
        {
            ParallelogramControl para = new ParallelogramControl();
            HelperAreaUI.ConfigureUserControls(MainPanel, para);
        }

        private void RhombusControlButton_Click(object sender, EventArgs e)
        {
            PhombusControl rhom = new PhombusControl();
            HelperAreaUI.ConfigureUserControls(MainPanel, rhom);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            HelperAreaUI.ConfigureUserControls(MainPanel, hc);
        }

        private void navbarr3D_MouseDown(object sender, MouseEventArgs clickTimes)
        {
           HelperAreaUI.ConfigureButtonClicks(splitContainer1, panel2D, panel3D, (Button)sender, clickTimes);
        }

       
    }
}

