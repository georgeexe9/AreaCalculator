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
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button6 = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            TriangleControlButton = new Button();
            label3 = new Label();
            button5 = new Button();
            RectangleControlButton = new Button();
            button2 = new Button();
            ParallelogramButtonControl = new Button();
            button1 = new Button();
            RhombusControlButton = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(110, 40);
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
            MainPanel.Paint += MainPanel_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 79);
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
            button6.Location = new Point(19, 17);
            button6.Name = "button6";
            button6.Size = new Size(115, 36);
            button6.TabIndex = 6;
            button6.Text = "     Начало";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 50, 83);
            panel3.Controls.Add(button6);
            panel3.Location = new Point(0, 130);
            panel3.Name = "panel3";
            panel3.Size = new Size(265, 69);
            panel3.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.Controls.Add(TriangleControlButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(RectangleControlButton);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(ParallelogramButtonControl);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(RhombusControlButton);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 390);
            panel1.TabIndex = 10;
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
            TriangleControlButton.Location = new Point(12, 48);
            TriangleControlButton.Name = "TriangleControlButton";
            TriangleControlButton.Size = new Size(238, 36);
            TriangleControlButton.TabIndex = 0;
            TriangleControlButton.Text = "Триъгълник";
            TriangleControlButton.TextAlign = ContentAlignment.MiddleLeft;
            TriangleControlButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            TriangleControlButton.UseVisualStyleBackColor = false;
            TriangleControlButton.Click += button1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(12, 23);
            label3.Name = "label3";
            label3.Size = new Size(238, 21);
            label3.TabIndex = 5;
            label3.Text = "Изберете желаната фигура:";
            label3.TextAlign = ContentAlignment.BottomCenter;
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
            button5.Location = new Point(12, 300);
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
            RectangleControlButton.Location = new Point(12, 90);
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
            button2.Location = new Point(12, 258);
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
            ParallelogramButtonControl.Location = new Point(12, 132);
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
            button1.Location = new Point(12, 216);
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
            RhombusControlButton.Location = new Point(12, 174);
            RhombusControlButton.Name = "RhombusControlButton";
            RhombusControlButton.Size = new Size(238, 36);
            RhombusControlButton.TabIndex = 4;
            RhombusControlButton.Text = "Ромб";
            RhombusControlButton.TextAlign = ContentAlignment.MiddleLeft;
            RhombusControlButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RhombusControlButton.UseVisualStyleBackColor = false;
            RhombusControlButton.Click += RhombusControlButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 56, 92);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(0, 189);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 388);
            panel2.TabIndex = 4;
            // 
            // CalculatorMainFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 79, 130);
            ClientSize = new Size(988, 575);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(MainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CalculatorMainFrom";
            Text = "Shape Calculator";
            FormClosing += CalculatorMainFrom_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel MainPanel;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Button button6;
        private Panel panel3;
        private Panel panel1;
        private Button TriangleControlButton;
        private Label label3;
        private Button button5;
        private Button RectangleControlButton;
        private Button button2;
        private Button ParallelogramButtonControl;
        private Button button1;
        private Button RhombusControlButton;
        private Panel panel2;
    }

}
