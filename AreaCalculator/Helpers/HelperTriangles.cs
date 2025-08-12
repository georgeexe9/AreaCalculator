using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaCalculator.Triangles;

namespace AreaCalculator.Helpers
{
    /// <summary>
    /// Представлява статичен клас, пълен със статични методи, които помагат за правилната визуализация на 
    /// UI контролите в TrianlgeControl прозореца
    /// </summary>
    public static class HelperTriangles
    {
        public static void ConfigureUILabels(ComboBox combo, Label SideALabel,
        Label SideBLabel,
        Panel infoPanel,
        Label formulaLabel,
        Label triangleNameLabel)
        {

        }
        public static void ConfigureUITextBox(TriangleChoices type, TextBox SideABox, TextBox SideBBox, TextBox SideCBox, TextBox HeightBox)
        {

            switch (type)
            {
                case TriangleChoices.Right_Triangle:
                    SideCBox.Enabled = false;
                    HeightBox.Enabled = false;
                    break;
                case TriangleChoices.Triangle:
                    break;
                case TriangleChoices.IsoscelesTriangle:
                    SideCBox.Enabled = false;
                    break;
                case TriangleChoices.EquilateralTriangle:
                    SideBBox.Enabled = false;
                    SideCBox.Enabled = false;
                    HeightBox.Enabled = false;
                    break;

            }
        }
        public static void ConfigureUITriangleLabels(TriangleChoices type, Label SideALabel,
        Label SideBLabel,
        Panel infoPanel,
        Label formulaLabel,
        Label triangleNameLabel,
        string nameTriangle)
        {

            switch (type)
            {
                case TriangleChoices.Right_Triangle:
                    Helper.ShowInformationalPanel(infoPanel, formulaLabel, triangleNameLabel, nameTriangle, "Area = (1/2) * a * b \n Perimeter = a + b + c");
                    break;
                case TriangleChoices.Triangle:
                    Helper.ShowInformationalPanel(infoPanel, formulaLabel, triangleNameLabel, nameTriangle,
                       "Area = 0.5 * a * h \n Perimeter = a + b + c");
                    break;
                case TriangleChoices.IsoscelesTriangle:
                    Helper.ShowInformationalPanel(infoPanel, formulaLabel, triangleNameLabel, nameTriangle,
                        "Area = (Base * Height) / 2 \n Perimeter = 2 * Side + Base");
                    SideALabel.Text = "Страна:";
                    SideBLabel.Text = "Основа:";
                    break;
                case TriangleChoices.EquilateralTriangle:
                    Helper.ShowInformationalPanel(infoPanel, formulaLabel, triangleNameLabel, nameTriangle,
                       "Area = (Base * Height) / 2 \n Perimeter = 3 * Side");
                    SideALabel.Text = "Страна:";
                    break;


            }
        }
    }
}








