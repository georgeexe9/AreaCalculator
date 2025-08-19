namespace AreaCalculator
{
    partial class HomeControlcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControlcs));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panelInfo = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 52, 92);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panelInfo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(725, 453);
            panel1.TabIndex = 24;
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(177, 218);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(382, 21);
            label3.TabIndex = 26;
            label3.Text = "Просто решение за изчисляване на площ и периметър.\r\n                                 Кликни върху \"Избери\" един път за 3D фигури и два пъти за 2D.";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(233, 178);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(259, 40);
            label2.TabIndex = 23;
            label2.Text = "Shaper Calculator\r\n";
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(33, 47, 83);
            panelInfo.Controls.Add(pictureBox1);
            panelInfo.Location = new Point(0, 369);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(725, 81);
            panelInfo.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(725, 81);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // HomeControlcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 99);
            Controls.Add(panel1);
            Name = "HomeControlcs";
            Size = new Size(725, 450);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panelInfo;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}
