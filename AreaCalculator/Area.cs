namespace AreaCalculator
{

    public partial class CalculatorMainFrom : Form
    {

        readonly HomeControlcs hc = new HomeControlcs();
        public CalculatorMainFrom()
        {
            InitializeComponent();
            MainPanel.Controls.Add(hc);

        }
        private void LoadControl(UserControl uc)
        {
            MainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(uc);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            TriangleForm tr = new TriangleForm();
            LoadControl(tr);
        }

        private void RectangleControlButton_Click(object sender, EventArgs e)
        {
            RectangleControl r = new RectangleControl();
            LoadControl(r);
        }

        private void ParallelogramButtonControl_Click(object sender, EventArgs e)
        {
            ParallelogramControl para = new ParallelogramControl();
            LoadControl(para);
        }

        private void RhombusControlButton_Click(object sender, EventArgs e)
        {
            PhombusControl rhom = new PhombusControl();
            LoadControl(rhom);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadControl(hc);
        }
        
    }
}

