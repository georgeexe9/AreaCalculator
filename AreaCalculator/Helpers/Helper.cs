//Written by George
namespace AreaCalculator.Helpers
{
    /// <summary>
    /// Helper е статичен клас, който съдържа статични методи за показване и визуализация на данни и съобщения в потребителския интерфейс. Както информация,
    /// така и за грешки. Не може да се инстанцира.
    /// </summary>

    public static class Helper
    {
        /// <summary>
        /// Визуализира основен панел с кратка информация за избрания триъгълник
        /// </summary>
        /// <param name="Infopanel"></param>
        /// <param name="formulas"></param>
        /// <param name="TriangleName"></param>
        /// <param name="shape"></param>
        /// <param name="formula"></param>
        public static void ShowInformationalPanel(Panel Infopanel, Label formulas, Label TriangleName, string shape, string formula)
        {

            Infopanel.Visible = true;
            formulas.Text = formula;
            TriangleName.Text = shape;
        }
        /// <summary>
        /// Визуализира вторичен панел с изчисления резултат (Лице и Периметър).
        /// </summary>
        /// <param name="panelInfo"></param>
        /// <param name="InformationalLabel"></param>
        /// <param name="area"></param>
        /// <param name="perimeter"></param>
        public static void ShowMessageResult(Panel panelInfo, Label InformationalLabel, double area, double perimeter)
        {
            //Лейбъл конфигурации
            InformationalLabel.ForeColor = Color.White;
            InformationalLabel.BackColor = Color.Transparent;
            //Показва резултата от обекта

            //Показва панела
            panelInfo.Visible = true;

            //Показва резултата от обекта
            InformationalLabel.Text = $"Лице: {area:F2} cm.\n Периметър: {perimeter:F2} cm.";

        }


        /// <summary>
        /// //Визуализира вторичния панел, обаче при наличието на хвърлена грешка
        /// </summary>
        /// <param name="panelInfo"></param>
        /// <param name="InformationalLabel"></param>
        /// <param name="message"></param>
        /// <param name="forecolor"></param>
        /// <param name="backcolor"></param>

        public static void ShowExceptionalMessage(Panel panelInfo, Label InformationalLabel, string message, Color forecolor, Color backcolor)
        {
            panelInfo.Visible = true;
            InformationalLabel.Text = $"Грешка: {message}";
            InformationalLabel.ForeColor = forecolor;
            InformationalLabel.BackColor = backcolor;

        }

        public static void HideUnnecessaryBoxes(ComboBox combobox, string shapeType, TextBox SideABox, TextBox SideBBox, TextBox SideCBox, TextBox Height)
        {
            SideABox.Enabled = false;
            SideBBox.Enabled = false;
            SideCBox.Enabled = false;
            Height.Enabled = false;
        }
        public static void HideUnnecessaryBoxes()
        {

        }




    }
}
