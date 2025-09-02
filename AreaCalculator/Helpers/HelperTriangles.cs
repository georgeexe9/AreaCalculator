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
    

        public static void ConfigureUITextBox(TriangleUIControls UI, TriangleChoices type)
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
        
        
        public static void ConfigureUITriangleLabels(TriangleUIControls UI, TriangleChoices type, Panel InfoPanel)
        {
            switch(type)
            {
                case TriangleChoices.Right_Triangle:
                    UI.TriangleNameType.Text = "Правоъгълен триъгълник";
                    UI.FormulaLabel.Text = "Формули: Area S = (1/2) * a * b \nPerimeter P = a + b + c";
                    UI.FunFactLabel.Text = "Fun Fact: The Pythagorean theorem states that in a right triangle, \nthe square of the hypotenuse (the side opposite the right angle)\nis equal to the sum of the squares of the other two sides.";
                    Helper.ShowInformationalPanel(InfoPanel);
                    break;
                case TriangleChoices.Triangle:
                    UI.TriangleNameType.Text = "Произволен Триъгълник";
                    UI.FormulaLabel.Text = "Формули: Area S = 0.5 * a * h \nPerimeter P = a + b + c";
                    UI.FunFactLabel.Text = "Fun Fact: The sum of the interior angles of any triangle \nis always 180 degrees.";
                    Helper.ShowInformationalPanel(InfoPanel);
                    break;
                case TriangleChoices.IsoscelesTriangle:
                    UI.TriangleNameType.Text = "Равнобедрен триъгълник";
                    UI.FormulaLabel.Text = "Формули: Area S = (Base * Height) / 2 \nPerimeter P = 2 * Side + Base";
                    UI.SideALabel.Text = "Страна:";
                    UI.SideBLabel.Text = "Основа:";
                    UI.FunFactLabel.Text = "Fun Fact: In an isosceles triangle, \nthe angles opposite the equal sides are also equal.";
                    Helper.ShowInformationalPanel(InfoPanel);
                    break;
                case TriangleChoices.EquilateralTriangle:
                    UI.TriangleNameType.Text = "Равностранен триъгълник";
                    UI.FormulaLabel.Text = "Формули: Area S = (Base * Height) / 2 \nPerimeter P = 3 * Side";
                    UI.SideALabel.Text = "Страна:";
                    UI.FunFactLabel.Text = "Fun Fact: All angles in an equilateral triangle \nare equal to 60 degrees.";
                    Helper.ShowInformationalPanel(InfoPanel);
                    break;
            }
        }


        public static void ConfigureLabelsByDefault(TriangleUIControls UI)
        {
            UI.SideALabel.Text = "Страна а:";
            UI.SideBLabel.Text = "Страна b:";
            UI.SideCLabel.Text = "Страна c:";
            UI.HeightLabel.Text = "Височина h:";
        }
        public static void ConfigureTextBoxesByDefault(TriangleUIControls UI)
        {
            UI.SideABox.Enabled = UI.SideABox.Visible = true;
            UI.SideBBox.Enabled = UI.SideBBox.Visible = true;
            UI.SideCBox.Enabled = UI.SideCBox.Visible = true;
            UI.HeightBox.Enabled = UI.HeightBox.Visible = true;
    
        }

    }
    
}








