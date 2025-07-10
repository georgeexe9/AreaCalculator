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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SideABox
            // 
            SideABox.Location = new Point(120, 161);
            SideABox.Multiline = true;
            SideABox.Name = "SideABox";
            SideABox.Size = new Size(100, 23);
            SideABox.TabIndex = 0;
            // 
            // SideBBox
            // 
            SideBBox.Location = new Point(120, 200);
            SideBBox.Name = "SideBBox";
            SideBBox.Size = new Size(100, 23);
            SideBBox.TabIndex = 1;
            // 
            // SideCBox
            // 
            SideCBox.Location = new Point(120, 242);
            SideCBox.Name = "SideCBox";
            SideCBox.Size = new Size(100, 23);
            SideCBox.TabIndex = 2;
            // 
            // HeightBox
            // 
            HeightBox.Location = new Point(120, 283);
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(100, 23);
            HeightBox.TabIndex = 3;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.White;
            CalculateButton.FlatStyle = FlatStyle.Flat;
            CalculateButton.ForeColor = Color.Black;
            CalculateButton.Location = new Point(40, 376);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(105, 30);
            CalculateButton.TabIndex = 4;
            CalculateButton.Text = "Изчисли";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 332);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 5;
            label1.Text = ":Резултат:";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(151, 376);
            button1.Name = "button1";
            button1.Size = new Size(94, 30);
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
            label2.Location = new Point(31, 26);
            label2.Name = "label2";
            label2.Size = new Size(125, 30);
            label2.TabIndex = 7;
            label2.Text = "Триъгълник";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 164);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 8;
            label3.Text = "Основа a:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 203);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 9;
            label4.Text = "Страна b:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(40, 245);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 10;
            label5.Text = "Страна c:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, 286);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 11;
            label6.Text = "Височина h:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(40, 66);
            label7.Name = "label7";
            label7.Size = new Size(411, 60);
            label7.TabIndex = 14;
            label7.Text = resources.GetString("label7.Text");
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(239, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(289, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(546, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // TriangleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 99);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(CalculateButton);
            Controls.Add(HeightBox);
            Controls.Add(SideCBox);
            Controls.Add(SideBBox);
            Controls.Add(SideABox);
            Name = "TriangleForm";
            Size = new Size(725, 450);
            Load += TriangleForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
