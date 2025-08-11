namespace AreaCalculator.Helpers
{
    /// <summary>
    /// Helper е статичен клас, който съдържа статични методи за показване, валидиране и визуализация на данни и съобщения в потребителския интерфейс. Както информация,
    /// така и за грешки. Не може да се инстанцира.
    /// 
    /// </summary>

    public static class Helper
    {

        //показва кратка информация за фигурата
        public static void ShowInformationalPanel(Panel Infopanel, Label formulas, Label TriangleName, string shape, string formula)
        {

            Infopanel.Visible = true;
            formulas.Text = formula;
            TriangleName.Text = shape;
        }
        //Показва резултата и панела,където се визуализира информацията
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

        //Показва съобщение при грешка    
        public static void ShowExceptionalMessage(Panel panelInfo, Label InformationalLabel, string message, Color forecolor, Color backcolor)
        {
            panelInfo.Visible = true;
            InformationalLabel.Text = $"Грешка: {message}";
            InformationalLabel.ForeColor = forecolor;
            InformationalLabel.BackColor = backcolor;

        }
        /// <summary>
        /// Валидира страните дали са числови стойности 
        /// (3 overloads според трита вида триъгълници)
        /// </summary>
        /// <param name="SideABox"></param>
        /// <param name="SideBBox"></param>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <returns></returns>
        public static bool VerifyValidationIsOk(TextBox SideABox, TextBox SideBBox, out double sideA, out double sideB)
        {

            sideB = 0;
            return double.TryParse(SideABox.Text, out sideA) &&
            double.TryParse(SideBBox.Text, out sideB);
        }

        public static bool VerifyValidationIsOk(TextBox SideABox, TextBox SideBBox, TextBox SideCBox,
            TextBox HeightBox, out double sideA, out double sideB, out double sideC, out double height)
        {

            sideB = 0;
            sideC = 0;
            height = 0;
            return double.TryParse(SideABox.Text, out sideA) &&
            double.TryParse(SideBBox.Text, out sideB) &&
            double.TryParse(SideCBox.Text, out sideC) &&
            double.TryParse(HeightBox.Text, out height);
        }

        public static bool VerifyValidationIsOk(TextBox SideABox, out double sideA)
        {
            return double.TryParse(SideABox.Text, out sideA);
        }



        /// <summary>
        /// Конфигурира базов дизайн на listViewSummary
        /// </summary>
        /// <param name="ListView"></param>
        public static void ConfigureListView(ListView listViewSummary)
        {
            listViewSummary.View = View.Details;

            listViewSummary.Columns.Add("Кратка информация:", -2, HorizontalAlignment.Left);

        }
        /// <summary>
        /// Изтрива всеки елемент от listSummary
        /// </summary>
        /// <param name="listSummary"></param>
        public static void ClearListView(ListView listViewSummary)
        {
            if (listViewSummary.Items.Count > 0)
            {
                listViewSummary.Clear();
            }
           

        }


        /// <summary>
        /// Вмъква информацията в listSummary
        /// </summary>
        /// <param name="listSummary"></param>
        /// <param name="summary"></param>
        public static void FillListSummary(ListView listViewSummary, List<string> summaryList)
        {
            ClearListView(listViewSummary);
            ConfigureListView(listViewSummary);
            foreach (string item in summaryList)
            {
                listViewSummary.Items.Add(item);
            }


        }



    }






}

