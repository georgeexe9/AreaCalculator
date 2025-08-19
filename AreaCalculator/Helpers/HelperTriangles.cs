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
    /// UI контролите в TrianlgeControl
    /// САМО ЗА ТРИЪГЪЛНИЦИ, НЕ МОЖЕ ДА СЕ ИЗПОЛЗВА ЗА ДРУГИ ФИГУРИ
    /// НЕ ПИПАЙ using AreaCalculator.Triangles; РАБОТЯТ ЗАЕДНО ❤️
    /// </summary>
    /// 
    //
    public static class HelperTriangles
    {
    

        public static void ConfigureUITextBox(HelperTriangleUIControls UI, TriangleChoices type)
        {

            switch (type)
            {
                case TriangleChoices.Right_Triangle:
                    UI.SideCBox.Enabled = false;
                    UI.HeightBox.Enabled = false;
                    break;
                case TriangleChoices.Triangle:
                    break;
                case TriangleChoices.IsoscelesTriangle:
                    UI.SideCBox.Enabled = false;
                    break;
                case TriangleChoices.EquilateralTriangle:
                    UI.SideBBox.Enabled = false;
                    UI.SideCBox.Enabled = false;
                    UI.HeightBox.Enabled = false;
                    break;

            }
        }
        public static void ConfigureUITriangleLabels(HelperTriangleUIControls UI,TriangleChoices type,
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
                    UI.SideALabel.Text = "Страна:";
                    UI.SideBLabel.Text = "Основа:";
                    break;
                case TriangleChoices.EquilateralTriangle:
                    Helper.ShowInformationalPanel(infoPanel, formulaLabel, triangleNameLabel, nameTriangle,
                       "Area = (Base * Height) / 2 \n Perimeter = 3 * Side");
                    UI.SideALabel.Text = "Страна:";
                    break;


            }
        }

        public static void ConfigureLabelsByDefault(HelperTriangleUIControls UI)
        {
            UI.SideALabel.Text = "Страна а:";
            UI.SideBLabel.Text = "Страна b:";
            UI.SideCLabel.Text = "Страна c:";
            UI.HeightLabel.Text = "Височина h:";
        }
        public static void ConfigureTextBoxesByDefault(HelperTriangleUIControls UI)
        {
            UI.SideABox.Enabled = UI.SideABox.Visible = true;
            UI.SideBBox.Enabled = UI.SideBBox.Visible = true;
            UI.SideCBox.Enabled = UI.SideCBox.Visible = true;
            UI.HeightBox.Enabled = UI.HeightBox.Visible = true;


            
        }

    }
    
}








