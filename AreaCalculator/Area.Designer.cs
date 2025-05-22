namespace AreaCalculator
{
    partial class CalculatorMainFrom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            помощToolStripMenuItem = new ToolStripMenuItem();
            изчистиПолетаToolStripMenuItem = new ToolStripMenuItem();
            изходToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            RectangleAreaResult = new Label();
            button2 = new Button();
            label11 = new Label();
            SideBRectangle = new TextBox();
            SideARectangle = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            SquareAreaResult = new Label();
            label9 = new Label();
            button1 = new Button();
            SquareAside = new TextBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            AreaTriangle = new Label();
            button3 = new Button();
            label12 = new Label();
            heightTriangle = new TextBox();
            sideATriangle = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 39);
            label1.Name = "label1";
            label1.Size = new Size(448, 57);
            label1.TabIndex = 0;
            label1.Text = "Area Figure Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 96);
            label2.Name = "label2";
            label2.Size = new Size(270, 21);
            label2.TabIndex = 1;
            label2.Text = "За да започнете, изберете фигура!";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { помощToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(475, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // помощToolStripMenuItem
            // 
            помощToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { изчистиПолетаToolStripMenuItem, изходToolStripMenuItem });
            помощToolStripMenuItem.ForeColor = Color.White;
            помощToolStripMenuItem.Name = "помощToolStripMenuItem";
            помощToolStripMenuItem.Size = new Size(62, 20);
            помощToolStripMenuItem.Text = "Помощ";
            // 
            // изчистиПолетаToolStripMenuItem
            // 
            изчистиПолетаToolStripMenuItem.Name = "изчистиПолетаToolStripMenuItem";
            изчистиПолетаToolStripMenuItem.Size = new Size(161, 22);
            изчистиПолетаToolStripMenuItem.Text = "Изчисти полета";
            // 
            // изходToolStripMenuItem
            // 
            изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            изходToolStripMenuItem.Size = new Size(161, 22);
            изходToolStripMenuItem.Text = "Изход";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 60, 99);
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(0, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 427);
            panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(31, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(414, 379);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightSteelBlue;
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(406, 351);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Правоъгълник и квадрат";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RectangleAreaResult);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(SideBRectangle);
            groupBox2.Controls.Add(SideARectangle);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(17, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 160);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Правоъгълник:";
            // 
            // RectangleAreaResult
            // 
            RectangleAreaResult.AutoSize = true;
            RectangleAreaResult.BackColor = Color.Transparent;
            RectangleAreaResult.ForeColor = Color.FromArgb(46, 60, 99);
            RectangleAreaResult.Location = new Point(84, 127);
            RectangleAreaResult.Name = "RectangleAreaResult";
            RectangleAreaResult.Size = new Size(57, 15);
            RectangleAreaResult.TabIndex = 6;
            RectangleAreaResult.Text = "Резултат:";
            // 
            // button2
            // 
            button2.Location = new Point(250, 113);
            button2.Name = "button2";
            button2.Size = new Size(111, 29);
            button2.TabIndex = 3;
            button2.Text = "Пресметни";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.ForeColor = Color.FromArgb(46, 60, 99);
            label11.Location = new Point(21, 127);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 5;
            label11.Text = "Резултат:";
            // 
            // SideBRectangle
            // 
            SideBRectangle.Location = new Point(79, 77);
            SideBRectangle.Name = "SideBRectangle";
            SideBRectangle.Size = new Size(100, 23);
            SideBRectangle.TabIndex = 5;
            // 
            // SideARectangle
            // 
            SideARectangle.Location = new Point(79, 37);
            SideARectangle.Name = "SideARectangle";
            SideARectangle.Size = new Size(100, 23);
            SideARectangle.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.FromArgb(46, 60, 99);
            label5.Location = new Point(17, 80);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "страна b:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.FromArgb(46, 60, 99);
            label4.Location = new Point(17, 40);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "страна а:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SquareAreaResult);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(SquareAside);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(17, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Квадрат:";
            // 
            // SquareAreaResult
            // 
            SquareAreaResult.AutoSize = true;
            SquareAreaResult.BackColor = Color.Transparent;
            SquareAreaResult.ForeColor = Color.FromArgb(46, 60, 99);
            SquareAreaResult.Location = new Point(84, 106);
            SquareAreaResult.Name = "SquareAreaResult";
            SquareAreaResult.Size = new Size(57, 15);
            SquareAreaResult.TabIndex = 4;
            SquareAreaResult.Text = "Резултат:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.FromArgb(46, 60, 99);
            label9.Location = new Point(21, 106);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 3;
            label9.Text = "Резултат:";
            // 
            // button1
            // 
            button1.Location = new Point(250, 99);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 2;
            button1.Text = "Пресметни";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SquareAside
            // 
            SquareAside.Location = new Point(79, 32);
            SquareAside.Name = "SquareAside";
            SquareAside.Size = new Size(100, 23);
            SquareAside.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(46, 60, 99);
            label3.Location = new Point(17, 35);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 0;
            label3.Text = "страна a";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightSteelBlue;
            tabPage2.Controls.Add(AreaTriangle);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(heightTriangle);
            tabPage2.Controls.Add(sideATriangle);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(406, 351);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Триъгълник";
            // 
            // AreaTriangle
            // 
            AreaTriangle.AutoSize = true;
            AreaTriangle.BackColor = Color.Transparent;
            AreaTriangle.ForeColor = Color.FromArgb(46, 60, 99);
            AreaTriangle.Location = new Point(88, 129);
            AreaTriangle.Name = "AreaTriangle";
            AreaTriangle.Size = new Size(73, 15);
            AreaTriangle.TabIndex = 8;
            AreaTriangle.Text = "AreaTriangle";
            AreaTriangle.TextAlign = ContentAlignment.TopCenter;
            // 
            // button3
            // 
            button3.Location = new Point(19, 163);
            button3.Name = "button3";
            button3.Size = new Size(111, 29);
            button3.TabIndex = 3;
            button3.Text = "Пресметни";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.FromArgb(46, 60, 99);
            label12.Location = new Point(25, 129);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 7;
            label12.Text = "Резултат:";
            // 
            // heightTriangle
            // 
            heightTriangle.Location = new Point(88, 85);
            heightTriangle.Name = "heightTriangle";
            heightTriangle.Size = new Size(100, 23);
            heightTriangle.TabIndex = 7;
            // 
            // sideATriangle
            // 
            sideATriangle.Location = new Point(88, 53);
            sideATriangle.Name = "sideATriangle";
            sideATriangle.Size = new Size(100, 23);
            sideATriangle.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.FromArgb(46, 60, 99);
            label8.Location = new Point(19, 88);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 6;
            label8.Text = "височина:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.FromArgb(46, 60, 99);
            label7.Location = new Point(19, 53);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 1;
            label7.Text = "страна:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(46, 60, 99);
            label6.Location = new Point(19, 15);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 5;
            label6.Text = "Триъгълник";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightSkyBlue;
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(406, 351);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Трапец";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.LightSteelBlue;
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(406, 351);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Кръг";
            // 
            // CalculatorMainFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 79, 130);
            ClientSize = new Size(475, 562);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "CalculatorMainFrom";
            Text = "Калкулатор на фигури";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem помощToolStripMenuItem;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label3;
        private Button button2;
        private TextBox SideBRectangle;
        private TextBox SideARectangle;
        private Label label5;
        private Label label4;
        private Button button1;
        private TextBox SquareAside;
        private Button button3;
        private TextBox heightTriangle;
        private TextBox sideATriangle;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label SquareAreaResult;
        private Label label9;
        private Label RectangleAreaResult;
        private Label label11;
        private Label AreaTriangle;
        private Label label12;
        private ToolStripMenuItem изчистиПолетаToolStripMenuItem;
        private ToolStripMenuItem изходToolStripMenuItem;
    }
}
