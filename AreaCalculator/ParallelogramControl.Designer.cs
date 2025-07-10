namespace AreaCalculator
{
    partial class ParallelogramControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParallelogramControl));
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ClearButton = new Button();
            InformationalLabel = new Label();
            CalculateButton = new Button();
            SideBBox = new TextBox();
            SideABox = new TextBox();
            label1 = new Label();
            HeightBox = new TextBox();
            pictureBox1 = new PictureBox();
            AngleBox = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(37, 77);
            label7.Name = "label7";
            label7.Size = new Size(544, 45);
            label7.TabIndex = 39;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(37, 214);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 38;
            label4.Text = "Страна b:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 175);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 37;
            label3.Text = "Страна a:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 37);
            label2.Name = "label2";
            label2.Size = new Size(127, 30);
            label2.TabIndex = 36;
            label2.Text = "Успоредник";
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.White;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Location = new Point(148, 372);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 30);
            ClearButton.TabIndex = 35;
            ClearButton.Text = "Изтрий";
            ClearButton.UseVisualStyleBackColor = false;
            // 
            // InformationalLabel
            // 
            InformationalLabel.AutoSize = true;
            InformationalLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InformationalLabel.ForeColor = Color.White;
            InformationalLabel.Location = new Point(37, 327);
            InformationalLabel.Name = "InformationalLabel";
            InformationalLabel.Size = new Size(120, 32);
            InformationalLabel.TabIndex = 34;
            InformationalLabel.Text = ":Резултат:";
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.White;
            CalculateButton.FlatStyle = FlatStyle.Flat;
            CalculateButton.ForeColor = Color.Black;
            CalculateButton.Location = new Point(37, 372);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(105, 30);
            CalculateButton.TabIndex = 33;
            CalculateButton.Text = "Изчисли";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // SideBBox
            // 
            SideBBox.Location = new Point(117, 211);
            SideBBox.Name = "SideBBox";
            SideBBox.Size = new Size(100, 23);
            SideBBox.TabIndex = 32;
            // 
            // SideABox
            // 
            SideABox.Location = new Point(117, 172);
            SideABox.Multiline = true;
            SideABox.Name = "SideABox";
            SideABox.Size = new Size(100, 23);
            SideABox.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 255);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 42;
            label1.Text = "Височина h:";
            // 
            // HeightBox
            // 
            HeightBox.Location = new Point(117, 252);
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(100, 23);
            HeightBox.TabIndex = 41;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(253, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 172);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // AngleBox
            // 
            AngleBox.Location = new Point(117, 289);
            AngleBox.Name = "AngleBox";
            AngleBox.Size = new Size(100, 23);
            AngleBox.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 292);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 46;
            label5.Text = "Ъгъл:";
            // 
            // ParallelogramControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 99);
            Controls.Add(label5);
            Controls.Add(AngleBox);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(HeightBox);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ClearButton);
            Controls.Add(InformationalLabel);
            Controls.Add(CalculateButton);
            Controls.Add(SideBBox);
            Controls.Add(SideABox);
            Name = "ParallelogramControl";
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
        private Label label1;
        private TextBox HeightBox;
        private PictureBox pictureBox1;
        private TextBox AngleBox;
        private Label label5;
    }
}
