namespace LayoutTelaPI
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(153, 108, 212);
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(44, 36, 85);
            label1.Location = new Point(53, 27);
            label1.Name = "label1";
            label1.Size = new Size(169, 45);
            label1.TabIndex = 0;
            label1.Text = "Microsoft";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(448, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 324);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(254, 40);
            label2.Name = "label2";
            label2.Size = new Size(126, 27);
            label2.TabIndex = 2;
            label2.Text = "Tamandua";
            // 
            // button2
            // 
            button2.Location = new Point(124, 123);
            button2.Name = "button2";
            button2.Size = new Size(186, 63);
            button2.TabIndex = 3;
            button2.Text = "chamar outra tela";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(124, 206);
            button1.Name = "button1";
            button1.Size = new Size(186, 63);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 182, 255);
            ClientSize = new Size(1025, 424);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button2;
        private Button button1;
        //private Button button1;
    }
}
