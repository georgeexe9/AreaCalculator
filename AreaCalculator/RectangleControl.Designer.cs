namespace AreaCalculator
{
    partial class RectangleControl
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
            panel1 = new Panel();
            panelInfo = new Panel();
            InformationalLabel = new Label();
            button1 = new Button();
            SideALabel = new Label();
            CalculateButton = new Button();
            SideABox = new TextBox();
            SideBBox = new TextBox();
            SideBLabel = new Label();
            Infopanel = new Panel();
            listSummary = new ListView();
            formula = new Label();
            TriangleName = new Label();
            formulas = new Label();
            RectangleName = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panelInfo.SuspendLayout();
            Infopanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 52, 92);
            panel1.Controls.Add(panelInfo);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(SideALabel);
            panel1.Controls.Add(CalculateButton);
            panel1.Controls.Add(SideABox);
            panel1.Controls.Add(SideBBox);
            panel1.Controls.Add(SideBLabel);
            panel1.Location = new Point(367, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 453);
            panel1.TabIndex = 28;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(33, 47, 83);
            panelInfo.Controls.Add(InformationalLabel);
            panelInfo.Location = new Point(0, 369);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(358, 81);
            panelInfo.TabIndex = 22;
            // 
            // InformationalLabel
            // 
            InformationalLabel.AutoSize = true;
            InformationalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InformationalLabel.ForeColor = Color.White;
            InformationalLabel.Location = new Point(16, 18);
            InformationalLabel.Name = "InformationalLabel";
            InformationalLabel.Size = new Size(57, 21);
            InformationalLabel.TabIndex = 0;
            InformationalLabel.Text = "label7";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(142, 315);
            button1.Name = "button1";
            button1.Size = new Size(105, 30);
            button1.TabIndex = 6;
            button1.Text = "Изтрий";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SideALabel
            // 
            SideALabel.AutoSize = true;
            SideALabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SideALabel.ForeColor = Color.White;
            SideALabel.Location = new Point(31, 97);
            SideALabel.Name = "SideALabel";
            SideALabel.Size = new Size(82, 21);
            SideALabel.TabIndex = 18;
            SideALabel.Text = "Страна a:";
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.White;
            CalculateButton.FlatStyle = FlatStyle.Flat;
            CalculateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalculateButton.ForeColor = Color.Black;
            CalculateButton.Location = new Point(31, 315);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(105, 30);
            CalculateButton.TabIndex = 4;
            CalculateButton.Text = "Изчисли";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // SideABox
            // 
            SideABox.BorderStyle = BorderStyle.FixedSingle;
            SideABox.Font = new Font("Segoe UI", 12F);
            SideABox.Location = new Point(31, 132);
            SideABox.Multiline = true;
            SideABox.Name = "SideABox";
            SideABox.Size = new Size(175, 30);
            SideABox.TabIndex = 0;
            // 
            // SideBBox
            // 
            SideBBox.BorderStyle = BorderStyle.FixedSingle;
            SideBBox.Font = new Font("Segoe UI", 12F);
            SideBBox.Location = new Point(31, 210);
            SideBBox.Multiline = true;
            SideBBox.Name = "SideBBox";
            SideBBox.Size = new Size(175, 30);
            SideBBox.TabIndex = 1;
            // 
            // SideBLabel
            // 
            SideBLabel.AutoSize = true;
            SideBLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SideBLabel.ForeColor = Color.White;
            SideBLabel.Location = new Point(31, 175);
            SideBLabel.Name = "SideBLabel";
            SideBLabel.Size = new Size(83, 21);
            SideBLabel.TabIndex = 9;
            SideBLabel.Text = "Страна b:";
            // 
            // Infopanel
            // 
            Infopanel.BackColor = Color.FromArgb(41, 54, 89);
            Infopanel.Controls.Add(listSummary);
            Infopanel.Controls.Add(formula);
            Infopanel.Controls.Add(TriangleName);
            Infopanel.Controls.Add(formulas);
            Infopanel.Location = new Point(0, 138);
            Infopanel.Name = "Infopanel";
            Infopanel.Size = new Size(380, 315);
            Infopanel.TabIndex = 32;
            // 
            // listSummary
            // 
            listSummary.BackColor = SystemColors.MenuBar;
            listSummary.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listSummary.Location = new Point(43, 78);
            listSummary.Name = "listSummary";
            listSummary.Size = new Size(285, 195);
            listSummary.TabIndex = 27;
            listSummary.UseCompatibleStateImageBehavior = false;
            // 
            // formula
            // 
            formula.AutoSize = true;
            formula.Location = new Point(153, 45);
            formula.Name = "formula";
            formula.Size = new Size(49, 15);
            formula.TabIndex = 26;
            formula.Text = "formula";
            // 
            // TriangleName
            // 
            TriangleName.AutoSize = true;
            TriangleName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TriangleName.ForeColor = Color.White;
            TriangleName.Location = new Point(147, 28);
            TriangleName.Name = "TriangleName";
            TriangleName.Size = new Size(0, 20);
            TriangleName.TabIndex = 25;
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
            // RectangleName
            // 
            RectangleName.AutoSize = true;
            RectangleName.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RectangleName.ForeColor = Color.White;
            RectangleName.Location = new Point(113, 177);
            RectangleName.Name = "RectangleName";
            RectangleName.RightToLeft = RightToLeft.No;
            RectangleName.Size = new Size(159, 30);
            RectangleName.TabIndex = 27;
            RectangleName.Text = "Правоъгълник";
            RectangleName.Click += RectangleName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 219);
            label1.Name = "label1";
            label1.Size = new Size(254, 15);
            label1.TabIndex = 33;
            label1.Text = "Въведи страните и кликни върху \"Изчисли\".";
            // 
            // RectangleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 99);
            Controls.Add(panel1);
            Controls.Add(Infopanel);
            Controls.Add(RectangleName);
            Controls.Add(label1);
            Name = "RectangleControl";
            Size = new Size(725, 450);
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

        private Panel panel1;
        private Panel panelInfo;
        private Label InformationalLabel;
        private Button button1;
        private Label SideALabel;
        private Button CalculateButton;
        private TextBox SideABox;
        private TextBox SideBBox;
        private Label SideBLabel;
        private Panel Infopanel;
        private ListView listSummary;
        private Label formula;
        private Label TriangleName;
        private Label formulas;
        private Label RectangleName;
        private Label label1;
    }
}
