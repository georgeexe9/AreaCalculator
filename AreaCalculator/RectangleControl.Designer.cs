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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectangleControl));
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ClearButton = new Button();
            InformationalLabel = new Label();
            CalculateButton = new Button();
            SideBBox = new TextBox();
            SideABox = new TextBox();
            pictureBox1 = new PictureBox();
            diagonalRadioButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(37, 75);
            label7.Name = "label7";
            label7.Size = new Size(474, 45);
            label7.TabIndex = 29;
            label7.Text = "Правоъгълникът е геометрична фигура с четири страни, където всички ъгли са 90°. \r\nАко всички страни на правоъгълника са с еднаква дължина, \r\nтой обикновено се нарича квадрат.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(37, 212);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 26;
            label4.Text = "Страна b:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 173);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 25;
            label3.Text = "Страна a:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 35);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 24;
            label2.Text = "Правоъгълник";
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.White;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Location = new Point(148, 348);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 30);
            ClearButton.TabIndex = 23;
            ClearButton.Text = "Изтрий";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // InformationalLabel
            // 
            InformationalLabel.AutoSize = true;
            InformationalLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InformationalLabel.ForeColor = Color.White;
            InformationalLabel.Location = new Point(37, 295);
            InformationalLabel.Name = "InformationalLabel";
            InformationalLabel.Size = new Size(120, 32);
            InformationalLabel.TabIndex = 22;
            InformationalLabel.Text = ":Резултат:";
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.White;
            CalculateButton.FlatStyle = FlatStyle.Flat;
            CalculateButton.ForeColor = Color.Black;
            CalculateButton.Location = new Point(37, 348);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(105, 30);
            CalculateButton.TabIndex = 21;
            CalculateButton.Text = "Изчисли";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // SideBBox
            // 
            SideBBox.Location = new Point(117, 209);
            SideBBox.Name = "SideBBox";
            SideBBox.Size = new Size(100, 23);
            SideBBox.TabIndex = 18;
            // 
            // SideABox
            // 
            SideABox.Location = new Point(117, 170);
            SideABox.Multiline = true;
            SideABox.Name = "SideABox";
            SideABox.Size = new Size(100, 23);
            SideABox.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(268, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 144);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // diagonalRadioButton
            // 
            diagonalRadioButton.AutoSize = true;
            diagonalRadioButton.ForeColor = Color.White;
            diagonalRadioButton.Location = new Point(37, 261);
            diagonalRadioButton.Name = "diagonalRadioButton";
            diagonalRadioButton.Size = new Size(137, 19);
            diagonalRadioButton.TabIndex = 31;
            diagonalRadioButton.TabStop = true;
            diagonalRadioButton.Text = "Изчисли диагонал d";
            diagonalRadioButton.UseVisualStyleBackColor = true;
            // 
            // RectangleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 99);
            Controls.Add(diagonalRadioButton);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ClearButton);
            Controls.Add(InformationalLabel);
            Controls.Add(CalculateButton);
            Controls.Add(SideBBox);
            Controls.Add(SideABox);
            Name = "RectangleControl";
            Size = new Size(725, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button ClearButton;
        private Label InformationalLabel;
        private Button CalculateButton;
        private TextBox SideBBox;
        private TextBox SideABox;
        private PictureBox pictureBox1;
        private RadioButton diagonalRadioButton;
    }
}
