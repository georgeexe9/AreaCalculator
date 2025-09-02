

namespace AreaCalculator.Helpers
{
    /// <summary>
    /// Helper е статичен клас, който съдържа статични методи за показване, валидиране и визуализация на данни и съобщения в потребителския интерфейс. Както информация,
    /// така и за грешки. Не може да се инстанцира.
    /// Обща логика за всички фигури
    /// 
    /// </summary>

    public static class Helper
    {
        

        public static void ConfigureChoiceBox(ComboBox TriangleChoiceBox)
        {
            TriangleChoiceBox.Items.Insert(0, "-Избери-");
            TriangleChoiceBox.FlatStyle = FlatStyle.System;
            TriangleChoiceBox.SelectedIndex = 0;
        }

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

        public static bool VerifyValidationIsOk(HelperTriangleUIControls UI, out double sideA, out double sideB)
        {
            
            sideB = 0;
            return double.TryParse(UI.SideABox.Text, out sideA) &&
            double.TryParse(UI.SideBBox.Text, out sideB);
        }
        public static bool VerifyValidationIsOk(HelperRectangleUIControls recUI, out double sideA, out double sideB)
        {

            sideB = 0;
            return double.TryParse(recUI.SideABox.Text, out sideA) &&
            double.TryParse(recUI.SideBBox.Text, out sideB);
        }

        public static bool VerifyValidationIsOk(HelperTriangleUIControls UI, out double sideA, out double sideB, out double sideC, out double height)
        {

            sideB = 0;
            sideC = 0;
            height = 0;
            return double.TryParse(UI.SideABox.Text, out sideA) &&
            double.TryParse(UI.SideBBox.Text, out sideB) &&
            double.TryParse(UI.SideCBox.Text, out sideC) &&
            double.TryParse(UI.HeightBox.Text, out height);
        }
        
           

        public static bool VerifyValidationIsOk(HelperTriangleUIControls UI, out double sideA)
        {
           
            return double.TryParse(UI.SideABox.Text, out sideA);
        }

        public static void ConfigureListView(ListView listViewSummary)
        {
            listViewSummary.View = View.Details;
            listViewSummary.Columns.Add("Кратка информация:", -2, HorizontalAlignment.Left);

        }

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
        /// 
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

        public static void ClearAllTextBoxes(TextBox SideABox, TextBox SideBBox, TextBox SideCBox, TextBox HeightBox)
        {
            
                SideABox.Clear();
                SideBBox.Clear();
                SideCBox.Clear();
                HeightBox.Clear();
            
               
        }
        public static void ClearAllTextBoxes(TextBox SideABox, TextBox SideBBox)
        {
            SideABox.Clear();
            SideBBox.Clear();
        }
        public static void ClearAllTextBoxes(TextBox SideABox)
        {
            SideABox.Clear();
        }
        //public static void ClearAllTextBoxesWithParams(params TextBox[] Textbox)
        //{
        //    foreach(var box in Textbox)
        //    {
        //        box.Clear();
        //    }
        //}






    }






}

