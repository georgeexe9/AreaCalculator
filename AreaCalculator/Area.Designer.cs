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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorMainFrom));
            label1 = new Label();
            MainPanel = new Panel();
            panel2 = new Panel();
            button6 = new Button();
            label3 = new Label();
            RhombusControlButton = new Button();
            ParallelogramButtonControl = new Button();
            RectangleControlButton = new Button();
            TriangleControlButton = new Button();
            menuStrip1 = new MenuStrip();
            помощToolStripMenuItem = new ToolStripMenuItem();
            заПриложениетоToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(104, 53);
            label1.Name = "label1";
            label1.Size = new Size(298, 47);
            label1.TabIndex = 0;
            label1.Text = "Shape Calculator";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(46, 60, 99);
            MainPanel.Location = new Point(263, 130);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(725, 450);
            MainPanel.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 56, 92);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(RhombusControlButton);
            panel2.Controls.Add(ParallelogramButtonControl);
            panel2.Controls.Add(RectangleControlButton);
            panel2.Controls.Add(TriangleControlButton);
            panel2.Location = new Point(0, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 447);
            panel2.TabIndex = 4;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(42, 56, 92);
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = Properties.Resources.home;
            button6.ImageAlign = ContentAlignment.TopLeft;
            button6.Location = new Point(19, 47);
            button6.Name = "button6";
            button6.Size = new Size(238, 36);
            button6.TabIndex = 6;
            button6.Text = "     Начало";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 18);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 5;
            label3.Text = "Изберете желаната фигура:";
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
            RhombusControlButton.Location = new Point(19, 215);
            RhombusControlButton.Name = "RhombusControlButton";
            RhombusControlButton.Size = new Size(238, 36);
            RhombusControlButton.TabIndex = 4;
            RhombusControlButton.Text = "Ромб";
            RhombusControlButton.TextAlign = ContentAlignment.MiddleLeft;
            RhombusControlButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RhombusControlButton.UseVisualStyleBackColor = false;
            RhombusControlButton.Click += RhombusControlButton_Click;
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
            ParallelogramButtonControl.Location = new Point(19, 173);
            ParallelogramButtonControl.Name = "ParallelogramButtonControl";
            ParallelogramButtonControl.Size = new Size(238, 36);
            ParallelogramButtonControl.TabIndex = 3;
            ParallelogramButtonControl.Text = "Успоредник";
            ParallelogramButtonControl.TextAlign = ContentAlignment.MiddleLeft;
            ParallelogramButtonControl.TextImageRelation = TextImageRelation.ImageBeforeText;
            ParallelogramButtonControl.UseVisualStyleBackColor = false;
            ParallelogramButtonControl.Click += ParallelogramButtonControl_Click;
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
            RectangleControlButton.Location = new Point(19, 131);
            RectangleControlButton.Name = "RectangleControlButton";
            RectangleControlButton.Size = new Size(238, 36);
            RectangleControlButton.TabIndex = 1;
            RectangleControlButton.Text = " Правоъгълник";
            RectangleControlButton.TextAlign = ContentAlignment.MiddleLeft;
            RectangleControlButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RectangleControlButton.UseVisualStyleBackColor = false;
            RectangleControlButton.Click += RectangleControlButton_Click;
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
            TriangleControlButton.Location = new Point(19, 89);
            TriangleControlButton.Name = "TriangleControlButton";
            TriangleControlButton.Size = new Size(238, 36);
            TriangleControlButton.TabIndex = 0;
            TriangleControlButton.Text = "Триъгълник";
            TriangleControlButton.TextAlign = ContentAlignment.MiddleLeft;
            TriangleControlButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            TriangleControlButton.UseVisualStyleBackColor = false;
            TriangleControlButton.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSteelBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { помощToolStripMenuItem, заПриложениетоToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(988, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // помощToolStripMenuItem
            // 
            помощToolStripMenuItem.Name = "помощToolStripMenuItem";
            помощToolStripMenuItem.Size = new Size(62, 20);
            помощToolStripMenuItem.Text = "Помощ";
            // 
            // заПриложениетоToolStripMenuItem
            // 
            заПриложениетоToolStripMenuItem.Name = "заПриложениетоToolStripMenuItem";
            заПриложениетоToolStripMenuItem.Size = new Size(117, 20);
            заПриложениетоToolStripMenuItem.Text = "За приложението";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
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
            button1.Location = new Point(19, 257);
            button1.Name = "button1";
            button1.Size = new Size(238, 36);
            button1.TabIndex = 7;
            button1.Text = "Квадрат";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // CalculatorMainFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 79, 130);
            ClientSize = new Size(988, 575);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(MainPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CalculatorMainFrom";
            Text = "Shape Calculator";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel MainPanel;
        private Panel panel2;
        private Button RhombusControlButton;
        private Button ParallelogramButtonControl;
        private Button RectangleControlButton;
        private Button TriangleControlButton;
        private Label label3;
        private Button button6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem помощToolStripMenuItem;
        private ToolStripMenuItem заПриложениетоToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button button1;
    }

}
