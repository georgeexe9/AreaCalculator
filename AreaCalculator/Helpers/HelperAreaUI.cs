using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCalculator.Helpers
{
    /// <summary>
    /// Defines the UI controls used in the AreaControl - Helper - HelperAreaUI classes.
    /// </summary>
    internal class HelperAreaUI
    {
        public static void ConfigureNavBars(SplitContainer spC,Panel panel)
        {
            foreach(Control control in  spC.Panel2.Controls)
            {
                if (control is Panel)
                {
                    control.Visible = false;
                }
            }
            panel.Visible = true;
            panel.Dock = DockStyle.Fill;
        }

        public static void ConfigureButtonClicks(SplitContainer spc,Panel panel3,Panel panel2,Button button, MouseEventArgs clickTimes)
        {
        {
            if (clickTimes.Clicks == 2)
            {
                ConfigureNavBars(spc, panel2);
            }
            else if (clickTimes.Clicks == 1)
            {
                ConfigureNavBars(spc, panel3);
            }
        }
        }
        public static void ConfigureUserControls(Panel MainPanel,UserControl uc)
        {
          MainPanel.Controls.Clear();
          uc.Dock = DockStyle.Fill;
          MainPanel.Controls.Add(uc);
        }
        public static void ConfigureMainPanel(Panel panel, UserControl uc)
        {
            panel.Controls.Add(uc);
        }
    }
}
