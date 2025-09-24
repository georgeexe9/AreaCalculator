namespace AreaCalculator
{
    partial class TriangleForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriangleForm));
            SideABox = new TextBox();
            SideBBox = new TextBox();
            SideCBox = new TextBox();
            HeightBox = new TextBox();
            CalculateButton = new Button();
            button1 = new Button();
            label2 = new Label();
            SideBLabel = new Label();
            SideCLabel = new Label();
            HeightLabel = new Label();
            SideALabel = new Label();
            panel1 = new Panel();
            panelInfo = new Panel();
            InformationalLabel = new Label();
            label4 = new Label();
            label3 = new Label();
            ResetTriangles = new Button();
            formulas = new Label();
            label8 = new Label();
            TriangleChoiceBox = new ComboBox();
            TriangleName = new Label();
            Infopanel = new Panel();
            FunFact = new Label();
            listSummary = new ListView();
            FormulaLabel = new Label();
            NoTriangleLabel = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panelInfo.SuspendLayout();
            Infopanel.SuspendLayout();
            SuspendLayout();
            // 
            // SideABox
            // 
            SideABox.BorderStyle = BorderStyle.FixedSingle;
            SideABox.Font = new Font("Segoe UI", 12F);
            SideABox.Location = new Point(16, 80);
            SideABox.Multiline = true;
            SideABox.Name = "SideABox";
            SideABox.Size = new Size(175, 30);
            SideABox.TabIndex = 0;
            // 
            // SideBBox
            // 
            SideBBox.BorderStyle = BorderStyle.FixedSingle;
            SideBBox.Font = new Font("Segoe UI", 12F);
            SideBBox.Location = new Point(16, 137);
            SideBBox.Multiline = true;
            SideBBox.Name = "SideBBox";
            SideBBox.Size = new Size(175, 30);
            SideBBox.TabIndex = 1;
            // 
            // SideCBox
            // 
            SideCBox.BorderStyle = BorderStyle.FixedSingle;
            SideCBox.Font = new Font("Segoe UI", 12F);
            SideCBox.Location = new Point(16, 194);
            SideCBox.Multiline = true;
            SideCBox.Name = "SideCBox";
            SideCBox.Size = new Size(175, 30);
            SideCBox.TabIndex = 2;
            // 
            // HeightBox
            // 
            HeightBox.BorderStyle = BorderStyle.FixedSingle;
            HeightBox.Font = new Font("Segoe UI", 12F);
            HeightBox.Location = new Point(16, 254);
            HeightBox.Multiline = true;
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(175, 30);
            HeightBox.TabIndex = 3;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.White;
            CalculateButton.FlatStyle = FlatStyle.Flat;
            CalculateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalculateButton.ForeColor = Color.Black;
            CalculateButton.Location = new Point(14, 308);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(105, 30);
            CalculateButton.TabIndex = 4;
            CalculateButton.Text = "Изчисли";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(125, 308);
            button1.Name = "button1";
            button1.Size = new Size(105, 30);
            button1.TabIndex = 6;
            button1.Text = "Изтрий";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(132, 15);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 7;
            label2.Text = "Триъгълници";
            // 
            // SideBLabel
            // 
            SideBLabel.AutoSize = true;
            SideBLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SideBLabel.ForeColor = Color.White;
            SideBLabel.Location = new Point(14, 113);
            SideBLabel.Name = "SideBLabel";
            SideBLabel.Size = new Size(83, 21);
            SideBLabel.TabIndex = 9;
            SideBLabel.Text = "Страна b:";
            // 
            // SideCLabel
            // 
            SideCLabel.AutoSize = true;
            SideCLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SideCLabel.ForeColor = Color.White;
            SideCLabel.Location = new Point(14, 170);
            SideCLabel.Name = "SideCLabel";
            SideCLabel.Size = new Size(81, 21);
            SideCLabel.TabIndex = 10;
            SideCLabel.Text = "Страна c:";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            HeightLabel.ForeColor = Color.White;
            HeightLabel.Location = new Point(14, 230);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(105, 21);
            HeightLabel.TabIndex = 11;
            HeightLabel.Text = "Височина h:";
            // 
            // SideALabel
            // 
            SideALabel.AutoSize = true;
            SideALabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SideALabel.ForeColor = Color.White;
            SideALabel.Location = new Point(15, 55);
            SideALabel.Name = "SideALabel";
            SideALabel.Size = new Size(82, 21);
            SideALabel.TabIndex = 18;
            SideALabel.Text = "Страна a:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 52, 92);
            panel1.Controls.Add(panelInfo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(SideALabel);
            panel1.Controls.Add(CalculateButton);
            panel1.Controls.Add(SideABox);
            panel1.Controls.Add(SideBBox);
            panel1.Controls.Add(SideCLabel);
            panel1.Controls.Add(SideCBox);
            panel1.Controls.Add(HeightLabel);
            panel1.Controls.Add(HeightBox);
            panel1.Controls.Add(SideBLabel);
            panel1.Location = new Point(401, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 450);
            panel1.TabIndex = 20;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(33, 47, 83);
            panelInfo.Controls.Add(InformationalLabel);
            panelInfo.Location = new Point(0, 369);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(352, 81);
            panelInfo.TabIndex = 22;
            // 
            // InformationalLabel
            // 
            InformationalLabel.AutoSize = true;
            InformationalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InformationalLabel.ForeColor = Color.White;
            InformationalLabel.Location = new Point(16, 18);
            InformationalLabel.Name = "InformationalLabel";
            InformationalLabel.Size = new Size(112, 21);
            InformationalLabel.TabIndex = 0;
            InformationalLabel.Text = "Sample Label";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 401);
            label4.Name = "label4";
            label4.Size = new Size(227, 21);
            label4.TabIndex = 36;
            label4.Text = "Резултатът ще се появи тук ";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(16, 27);
            label3.Name = "label3";
            label3.Size = new Size(290, 14);
            label3.TabIndex = 35;
            label3.Text = "Въведи нужните страни и натисни \"Изчисли\"";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ResetTriangles
            // 
            ResetTriangles.BackColor = Color.White;
            ResetTriangles.FlatStyle = FlatStyle.Flat;
            ResetTriangles.Location = new Point(309, 80);
            ResetTriangles.Name = "ResetTriangles";
            ResetTriangles.Size = new Size(31, 25);
            ResetTriangles.TabIndex = 23;
            ResetTriangles.Text = "X";
            ResetTriangles.UseVisualStyleBackColor = false;
            ResetTriangles.Click += ResetTriangles_Click;
            // 
            // formulas
            // 
            formulas.AutoSize = true;
            formulas.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formulas.ForeColor = Color.White;
            formulas.Location = new Point(132, 69);
            formulas.Name = "formulas";
            formulas.Size = new Size(0, 20);
            formulas.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(83, 67);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 23;
            // 
            // TriangleChoiceBox
            // 
            TriangleChoiceBox.BackColor = Color.FromArgb(37, 52, 92);
            TriangleChoiceBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TriangleChoiceBox.FlatStyle = FlatStyle.Flat;
            TriangleChoiceBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TriangleChoiceBox.ForeColor = Color.White;
            TriangleChoiceBox.FormattingEnabled = true;
            TriangleChoiceBox.Items.AddRange(new object[] { "Правоъгълен триъгълник", "Произволен триъгълник", "Равнобедрен триъгълник", "Равностранен триъгълник" });
            TriangleChoiceBox.Location = new Point(101, 80);
            TriangleChoiceBox.Name = "TriangleChoiceBox";
            TriangleChoiceBox.RightToLeft = RightToLeft.No;
            TriangleChoiceBox.Size = new Size(202, 25);
            TriangleChoiceBox.TabIndex = 24;
            TriangleChoiceBox.SelectedIndexChanged += TriangleChoiceBox_SelectedIndexChanged;
            // 
            // TriangleName
            // 
            TriangleName.AutoSize = true;
            TriangleName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TriangleName.ForeColor = Color.White;
            TriangleName.Location = new Point(120, 17);
            TriangleName.Name = "TriangleName";
            TriangleName.Size = new Size(160, 20);
            TriangleName.TabIndex = 25;
            TriangleName.Text = ":Име на триъгълник:";
            // 
            // Infopanel
            // 
            Infopanel.BackColor = Color.FromArgb(41, 54, 89);
            Infopanel.Controls.Add(FunFact);
            Infopanel.Controls.Add(listSummary);
            Infopanel.Controls.Add(FormulaLabel);
            Infopanel.Controls.Add(TriangleName);
            Infopanel.Controls.Add(formulas);
            Infopanel.Location = new Point(0, 120);
            Infopanel.Name = "Infopanel";
            Infopanel.Size = new Size(401, 330);
            Infopanel.TabIndex = 26;
            // 
            // FunFact
            // 
            FunFact.AutoSize = true;
            FunFact.BackColor = Color.FromArgb(41, 54, 89);
            FunFact.BorderStyle = BorderStyle.FixedSingle;
            FunFact.ForeColor = Color.White;
            FunFact.Location = new Point(28, 56);
            FunFact.Name = "FunFact";
            FunFact.Size = new Size(70, 17);
            FunFact.TabIndex = 29;
            FunFact.Text = "funfacthere";
            // 
            // listSummary
            // 
            listSummary.BackColor = Color.FromArgb(33, 44, 72);
            listSummary.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listSummary.Location = new Point(28, 161);
            listSummary.Name = "listSummary";
            listSummary.Size = new Size(352, 141);
            listSummary.TabIndex = 27;
            listSummary.UseCompatibleStateImageBehavior = false;
            // 
            // FormulaLabel
            // 
            FormulaLabel.AutoSize = true;
            FormulaLabel.BackColor = Color.FromArgb(62, 73, 104);
            FormulaLabel.BorderStyle = BorderStyle.FixedSingle;
            FormulaLabel.ForeColor = Color.White;
            FormulaLabel.Location = new Point(28, 116);
            FormulaLabel.Name = "FormulaLabel";
            FormulaLabel.Size = new Size(51, 17);
            FormulaLabel.TabIndex = 26;
            FormulaLabel.Text = "formula";
            // 
            // NoTriangleLabel
            // 
            NoTriangleLabel.BackColor = Color.Transparent;
            NoTriangleLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoTriangleLabel.ForeColor = Color.White;
            NoTriangleLabel.Location = new Point(28, 230);
            NoTriangleLabel.Name = "NoTriangleLabel";
            NoTriangleLabel.Size = new Size(358, 54);
            NoTriangleLabel.TabIndex = 27;
            NoTriangleLabel.Text = "Няма избран триъгълник!";
            NoTriangleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(99, 50);
            label1.Name = "label1";
            label1.Size = new Size(207, 15);
            label1.TabIndex = 34;
            label1.Text = "Избери вид триъгълник от списъка:";
            // 
            // TriangleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 99);
            Controls.Add(label1);
            Controls.Add(ResetTriangles);
            Controls.Add(panel1);
            Controls.Add(TriangleChoiceBox);
            Controls.Add(label8);
            Controls.Add(Infopanel);
            Controls.Add(label2);
            Controls.Add(NoTriangleLabel);
            Name = "TriangleForm";
            Size = new Size(753, 450);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            Infopanel.ResumeLayout(false);
            Infopanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SideABox;
        private TextBox SideBBox;
        private TextBox SideCBox;
        private TextBox HeightBox;
        private Button CalculateButton;
        private Button button1;
        private Label label2;
        private Label SideBLabel;
        private Label SideCLabel;
        private Label HeightLabel;
        private Label SideALabel;
        private Panel panel1;
        private Panel panelInfo;
        private Label InformationalLabel;
        private Label formulas;
        private Label label8;
        private ComboBox TriangleChoiceBox;
        private Label TriangleName;
        private Panel Infopanel;
        private Label NoTriangleLabel;
        private Button ResetTriangles;
        private Label FormulaLabel;
        private ListView listSummary;
        private Label label1;
        private Label label3;
        private Label FunFact;
        private Label label4;
    }
}
