using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Helpers
{
    public  class HelperRectangleUIControls
    {
        public TextBox SideABox { get; }
        public TextBox SideBBox { get; }
        public Label SideALabel { get; }
        public Label SideBLabel { get; }

        public HelperRectangleUIControls(TextBox sideABox, TextBox sideBBox, Label sideALabel, Label sideBLabel)
        {
            SideABox = sideABox;
            SideBBox = sideBBox;
            SideALabel = sideALabel;
            SideBLabel = sideBLabel;
        }
    }
}
