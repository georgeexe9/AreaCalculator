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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatorMainFrom calc = new CalculatorMainFrom();
            this.Hide();
            calc.ShowDialog();
            this.Show();

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult decision = MessageBox.Show("Наистина ли искате да затворите приложението?", "Тъжно", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
            
        }
    }
}
