using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCalculator
{
    public partial class ParallelogramControl : UserControl
    {
        public ParallelogramControl()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateParallelogram();
        }
        private void CalculateParallelogram()
        {
            if (!string.IsNullOrEmpty(SideABox.Text) && !string.IsNullOrEmpty(SideBBox.Text) && !string.IsNullOrEmpty(HeightBox.Text) && !string.IsNullOrEmpty(AngleBox.Text))
            {
                try
                {
                    double sideA = double.Parse(SideABox.Text);
                    double sideB = double.Parse(SideBBox.Text);
                    double Height = double.Parse(HeightBox.Text);
                    double angle = double.Parse(AngleBox.Text);

                    Shape parallelogram = new Parallelogram(sideA, sideB, Height, angle);
                    double area = parallelogram.CalculateArea();
                    double perimeter = parallelogram.CalculatePerimeter();
                    double diagonal = parallelogram.CalculateDiagonal();

                    InformationalLabel.Text = $"Лице/Площ - {area}, Периметър - {perimeter}," +
                        $"Диагонал d - {diagonal}";
                }
                catch (ArgumentException e)
                {
                    MessageBox.Show(e.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Моля, въведете правилни стойности", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Моля, въведете стойности!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
