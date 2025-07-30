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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            panelInfo = new Panel();
            InformationalLabel = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SideABox
            // 
            SideABox.BorderStyle = BorderStyle.FixedSingle;
            SideABox.Font = new Font("Segoe UI", 12F);
            SideABox.Location = new Point(33, 87);
            SideABox.Multiline = true;
            SideABox.Name = "SideABox";
            SideABox.Size = new Size(175, 30);
            SideABox.TabIndex = 0;
            // 
            // SideBBox
            // 
            SideBBox.BorderStyle = BorderStyle.FixedSingle;
            SideBBox.Font = new Font("Segoe UI", 12F);
            SideBBox.Location = new Point(33, 144);
            SideBBox.Multiline = true;
            SideBBox.Name = "SideBBox";
            SideBBox.Size = new Size(175, 30);
            SideBBox.TabIndex = 1;
            // 
            // SideCBox
            // 
            SideCBox.BorderStyle = BorderStyle.FixedSingle;
            SideCBox.Font = new Font("Segoe UI", 12F);
            SideCBox.Location = new Point(33, 201);
            SideCBox.Multiline = true;
            SideCBox.Name = "SideCBox";
            SideCBox.Size = new Size(175, 30);
            SideCBox.TabIndex = 2;
            // 
            // HeightBox
            // 
            HeightBox.BorderStyle = BorderStyle.FixedSingle;
            HeightBox.Font = new Font("Segoe UI", 12F);
            HeightBox.Location = new Point(33, 261);
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
            CalculateButton.Location = new Point(31, 315);
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
            button1.Location = new Point(142, 315);
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
            label2.Location = new Point(36, 26);
            label2.Name = "label2";
            label2.Size = new Size(125, 30);
            label2.TabIndex = 7;
            label2.Text = "Триъгълник";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 120);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 9;
            label4.Text = "Страна b:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(31, 177);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 10;
            label5.Text = "Страна c:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(31, 237);
            label6.Name = "label6";
            label6.Size = new Size(105, 21);
            label6.TabIndex = 11;
            label6.Text = "Височина h:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(31, 63);
            label10.Name = "label10";
            label10.Size = new Size(82, 21);
            label10.TabIndex = 18;
            label10.Text = "Страна a:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 52, 92);
            panel1.Controls.Add(panelInfo);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(CalculateButton);
            panel1.Controls.Add(SideABox);
            panel1.Controls.Add(SideBBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(SideCBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(HeightBox);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(367, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 450);
            panel1.TabIndex = 20;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 144);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 1;
            label3.Text = "Формули:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 231);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(36, 177);
            label7.Name = "label7";
            label7.Size = new Size(102, 40);
            label7.TabIndex = 1;
            label7.Text = "S = (a × h) / 2\r\nP = a + b + c\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(40, 63);
            label8.Name = "label8";
            label8.Size = new Size(292, 15);
            label8.TabIndex = 23;
            label8.Text = "Въведете дължините на трите страни и височината";
            // 
            // TriangleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 99);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "TriangleForm";
            Size = new Size(725, 450);
            Load += TriangleForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label10;
        private Panel panel1;
        private Panel panelInfo;
        private Label InformationalLabel;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
    }
}
