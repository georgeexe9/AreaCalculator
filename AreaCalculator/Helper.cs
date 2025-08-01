namespace AreaCalculator
{
    /// <summary>
    /// Helper е статичен клас, съдържащ различни методи за UI визуализация на данните
    /// 
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// 
        /// </summary>

        public static void ShowInformationalPanel(Panel Infopanel, Label formulas, Label TriangleName, string shape, string formula)
        {

            Infopanel.Visible = true;
            formulas.Text = formula;
            TriangleName.Text = shape;
        }
        /// <summary>
        /// ShowMessageResult помага за визуализирането на намереното лице и периметър на фигурата. 
        /// </summary>

        public static void ShowMessageResult(Panel panelInfo, Label InformationalLabel, double area, double perimeter, Color forecolor)
        {

            panelInfo.Visible = true;
            InformationalLabel.Text = $"Лице: {area:F2} cm.\n Периметър: {perimeter:F2} cm.";
            InformationalLabel.ForeColor = forecolor;
        }
        /// <summary>
        /// ShowExceptionalMessage помага за визуализирането на хвърлена грешка       
        /// /// </summary>
        public static void ShowExceptionalMessage(Panel panelInfo, Label InformationalLabel, string message, Color forecolor)
        {
            panelInfo.Visible = true;
            InformationalLabel.Text = message;
            InformationalLabel.ForeColor = forecolor;
        }

    }
}
