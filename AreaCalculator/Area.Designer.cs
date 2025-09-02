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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorMainFrom));
            label1 = new Label();
            MainPanel = new Panel();
            panel3D = new Panel();
            label2 = new Label();
            button3 = new Button();
            button11 = new Button();
            button7 = new Button();
            button10 = new Button();
            button9 = new Button();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button6 = new Button();
            ChangeShapesButton = new Button();
            panel2D = new Panel();
            label3 = new Label();
            TriangleControlButton = new Button();
            button5 = new Button();
            RectangleControlButton = new Button();
            button2 = new Button();
            ParallelogramButtonControl = new Button();
            button1 = new Button();
            RhombusControlButton = new Button();
            splitContainer1 = new SplitContainer();
            panel3D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(133, 45);
            label1.Name = "label1";
            label1.Size = new Size(312, 47);
            label1.TabIndex = 0;
            label1.Text = "Shaper Calculator";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(46, 60, 99);
            MainPanel.Location = new Point(263, 130);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(725, 450);
            MainPanel.TabIndex = 3;
            // 
            // panel3D
            // 
            panel3D.BackColor = Color.FromArgb(42, 56, 92);
            panel3D.Controls.Add(label2);
            panel3D.Controls.Add(button3);
            panel3D.Controls.Add(button11);
            panel3D.Controls.Add(button7);
            panel3D.Controls.Add(button10);
            panel3D.Controls.Add(button9);
            panel3D.Location = new Point(3, 3);
            panel3D.Name = "panel3D";
            panel3D.Size = new Size(263, 188);
            panel3D.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(9, 11);
            label2.Name = "label2";
            label2.Size = new Size(238, 21);
            label2.TabIndex = 10;
            label2.Text = "Изберете желаната фигура:";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(42, 56, 92);
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopLeft;
            button3.Location = new Point(9, 48);
            button3.Name = "button3";
            button3.Size = new Size(238, 36);
            button3.TabIndex = 10;
            button3.Text = "Пирамида";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(42, 56, 92);
            button11.BackgroundImage = (Image)resources.GetObject("button11.BackgroundImage");
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button11.ForeColor = Color.White;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.TopLeft;
            button11.Location = new Point(9, 174);
            button11.Name = "button11";
            button11.Size = new Size(238, 36);
            button11.TabIndex = 13;
            button11.Text = "Паралепипед";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.TextImageRelation = TextImageRelation.ImageBeforeText;
            button11.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(42, 56, 92);
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Image = Properties.Resources.rectangle;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(9, 90);
            button7.Name = "button7";
            button7.Size = new Size(238, 36);
            button7.TabIndex = 11;
            button7.Text = "Цилиндър";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(42, 56, 92);
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button10.ForeColor = Color.White;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.TopLeft;
            button10.Location = new Point(9, 216);
            button10.Name = "button10";
            button10.Size = new Size(238, 36);
            button10.TabIndex = 14;
            button10.Text = "Куб";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.TextImageRelation = TextImageRelation.ImageBeforeText;
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(42, 56, 92);
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button9.ForeColor = Color.White;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.TopLeft;
            button9.Location = new Point(9, 132);
            button9.Name = "button9";
            button9.Size = new Size(238, 36);
            button9.TabIndex = 12;
            button9.Text = "Сфера";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = Properties.Resources.home;
            button6.ImageAlign = ContentAlignment.TopLeft;
            button6.Location = new Point(16, 20);
            button6.Name = "button6";
            button6.Size = new Size(115, 36);
            button6.TabIndex = 6;
            button6.Text = "     Начало";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // ChangeShapesButton
            // 
            ChangeShapesButton.BackColor = Color.Transparent;
            ChangeShapesButton.FlatAppearance.BorderSize = 0;
            ChangeShapesButton.FlatStyle = FlatStyle.Flat;
            ChangeShapesButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangeShapesButton.ForeColor = Color.White;
            ChangeShapesButton.Image = (Image)resources.GetObject("ChangeShapesButton.Image");
            ChangeShapesButton.ImageAlign = ContentAlignment.TopLeft;
            ChangeShapesButton.Location = new Point(139, 20);
            ChangeShapesButton.Name = "ChangeShapesButton";
            ChangeShapesButton.Size = new Size(117, 36);
            ChangeShapesButton.TabIndex = 7;
            ChangeShapesButton.Text = "  Фигури";
            ChangeShapesButton.TextAlign = ContentAlignment.MiddleLeft;
            ChangeShapesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ChangeShapesButton.UseVisualStyleBackColor = false;
            ChangeShapesButton.MouseDown += navbarr3D_MouseDown;
            // 
            // panel2D
            // 
            panel2D.BackColor = Color.FromArgb(42, 56, 92);
            panel2D.Controls.Add(label3);
            panel2D.Controls.Add(TriangleControlButton);
            panel2D.Controls.Add(button5);
            panel2D.Controls.Add(RectangleControlButton);
            panel2D.Controls.Add(button2);
            panel2D.Controls.Add(ParallelogramButtonControl);
            panel2D.Controls.Add(button1);
            panel2D.Controls.Add(RhombusControlButton);
            panel2D.Location = new Point(3, 197);
            panel2D.Name = "panel2D";
            panel2D.Size = new Size(266, 166);
            panel2D.TabIndex = 10;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(15, 11);
            label3.Name = "label3";
            label3.Size = new Size(238, 21);
            label3.TabIndex = 5;
            label3.Text = "Изберете желаната фигура:";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // TriangleControlButton
            // 
            TriangleControlButton.BackColor = Color.FromArgb(42, 56, 92);
            TriangleControlButton.BackgroundImage = (Image)resources.GetObject("TriangleControlButton.BackgroundImage");
            TriangleControlButton.FlatAppearance.BorderSize = 0;
            TriangleControlButton.FlatStyle = FlatStyle.Flat;
            TriangleControlButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TriangleControlButton.ForeColor = Color.White;
            TriangleControlButton.Image = (Image)resources.GetObject("TriangleControlButton.Image");
            TriangleControlButton.ImageAlign = ContentAlignment.TopLeft;
            TriangleControlButton.Location = new Point(15, 43);
            TriangleControlButton.Name = "TriangleControlButton";
            TriangleControlButton.Size = new Size(238, 36);
            TriangleControlButton.TabIndex = 0;
            TriangleControlButton.Text = "Триъгълник";
            TriangleControlButton.TextAlign = ContentAlignment.MiddleLeft;
            TriangleControlButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            TriangleControlButton.UseVisualStyleBackColor = false;
            TriangleControlButton.Click += button1_Click;
            TriangleControlButton.MouseDown += TriangleControlButton_MouseDown;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(42, 56, 92);
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.TopLeft;
            button5.Location = new Point(15, 295);
            button5.Name = "button5";
            button5.Size = new Size(238, 36);
            button5.TabIndex = 9;
            button5.Text = "Ромб";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // RectangleControlButton
            // 
            RectangleControlButton.BackColor = Color.FromArgb(42, 56, 92);
            RectangleControlButton.BackgroundImage = (Image)resources.GetObject("RectangleControlButton.BackgroundImage");
            RectangleControlButton.FlatAppearance.BorderSize = 0;
            RectangleControlButton.FlatStyle = FlatStyle.Flat;
            RectangleControlButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RectangleControlButton.ForeColor = Color.White;
            RectangleControlButton.Image = Properties.Resources.rectangle;
            RectangleControlButton.ImageAlign = ContentAlignment.MiddleLeft;
            RectangleControlButton.Location = new Point(15, 85);
            RectangleControlButton.Name = "RectangleControlButton";
            RectangleControlButton.Size = new Size(238, 36);
            RectangleControlButton.TabIndex = 1;
            RectangleControlButton.Text = " Правоъгълник";
            RectangleControlButton.TextAlign = ContentAlignment.MiddleLeft;
            RectangleControlButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RectangleControlButton.UseVisualStyleBackColor = false;
            RectangleControlButton.Click += RectangleControlButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(42, 56, 92);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(15, 253);
            button2.Name = "button2";
            button2.Size = new Size(238, 36);
            button2.TabIndex = 8;
            button2.Text = "Кръг";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // ParallelogramButtonControl
            // 
            ParallelogramButtonControl.BackColor = Color.FromArgb(42, 56, 92);
            ParallelogramButtonControl.BackgroundImage = (Image)resources.GetObject("ParallelogramButtonControl.BackgroundImage");
            ParallelogramButtonControl.FlatAppearance.BorderSize = 0;
            ParallelogramButtonControl.FlatStyle = FlatStyle.Flat;
            ParallelogramButtonControl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ParallelogramButtonControl.ForeColor = Color.White;
            ParallelogramButtonControl.Image = (Image)resources.GetObject("ParallelogramButtonControl.Image");
            ParallelogramButtonControl.ImageAlign = ContentAlignment.TopLeft;
            ParallelogramButtonControl.Location = new Point(15, 127);
            ParallelogramButtonControl.Name = "ParallelogramButtonControl";
            ParallelogramButtonControl.Size = new Size(238, 36);
            ParallelogramButtonControl.TabIndex = 3;
            ParallelogramButtonControl.Text = "Успоредник";
            ParallelogramButtonControl.TextAlign = ContentAlignment.MiddleLeft;
            ParallelogramButtonControl.TextImageRelation = TextImageRelation.ImageBeforeText;
            ParallelogramButtonControl.UseVisualStyleBackColor = false;
            ParallelogramButtonControl.Click += ParallelogramButtonControl_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(42, 56, 92);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(15, 211);
            button1.Name = "button1";
            button1.Size = new Size(238, 36);
            button1.TabIndex = 7;
            button1.Text = "Квадрат";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // RhombusControlButton
            // 
            RhombusControlButton.BackColor = Color.FromArgb(42, 56, 92);
            RhombusControlButton.BackgroundImage = (Image)resources.GetObject("RhombusControlButton.BackgroundImage");
            RhombusControlButton.FlatAppearance.BorderSize = 0;
            RhombusControlButton.FlatStyle = FlatStyle.Flat;
            RhombusControlButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RhombusControlButton.ForeColor = Color.White;
            RhombusControlButton.Image = (Image)resources.GetObject("RhombusControlButton.Image");
            RhombusControlButton.ImageAlign = ContentAlignment.TopLeft;
            RhombusControlButton.Location = new Point(15, 169);
            RhombusControlButton.Name = "RhombusControlButton";
            RhombusControlButton.Size = new Size(238, 36);
            RhombusControlButton.TabIndex = 4;
            RhombusControlButton.Text = "Ромб";
            RhombusControlButton.TextAlign = ContentAlignment.MiddleLeft;
            RhombusControlButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RhombusControlButton.UseVisualStyleBackColor = false;
            RhombusControlButton.Click += RhombusControlButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(46, 60, 99);
            splitContainer1.Location = new Point(-1, 130);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(38, 50, 83);
            splitContainer1.Panel1.Controls.Add(ChangeShapesButton);
            splitContainer1.Panel1.Controls.Add(button6);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel3D);
            splitContainer1.Panel2.Controls.Add(panel2D);
            splitContainer1.Size = new Size(266, 447);
            splitContainer1.SplitterDistance = 77;
            splitContainer1.TabIndex = 25;
            // 
            // CalculatorMainFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 79, 130);
            ClientSize = new Size(988, 575);
            Controls.Add(splitContainer1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(MainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1004, 614);
            MinimumSize = new Size(1004, 614);
            Name = "CalculatorMainFrom";
            Text = "Shape Calculator";
            panel3D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2D.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel MainPanel;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Button button6;
        private Panel panel2D;
        private Button TriangleControlButton;
        private Label label3;
        private Button button5;
        private Button RectangleControlButton;
        private Button button2;
        private Button ParallelogramButtonControl;
        private Button button1;
        private Button RhombusControlButton;
        private Button ChangeShapesButton;
        private Panel panel3D;
        private Button button3;
        private Button button11;
        private Button button7;
        private Button button10;
        private Button button9;
        private SplitContainer splitContainer1;
        private Label label2;
    }

}
