namespace TASK_4
{
    partial class Form1
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
            textBox1 = new TextBox();
            label1 = new Label();
<<<<<<< HEAD
            button1 = new Button();
=======
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
>>>>>>> 49a53fde02f021b1099d862fb2d066d748e3ee70
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
<<<<<<< HEAD
            textBox1.Location = new Point(54, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 27);
=======
            textBox1.Location = new Point(516, 121);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 129);
>>>>>>> 49a53fde02f021b1099d862fb2d066d748e3ee70
            textBox1.TabIndex = 0;
            textBox1.LostFocus += textbox1_LostFocus;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
<<<<<<< HEAD
            label1.Location = new Point(22, 28);
=======
            label1.Location = new Point(516, 73);
>>>>>>> 49a53fde02f021b1099d862fb2d066d748e3ee70
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "Введите текст";
            label1.Click += label1_Click;
            // 
<<<<<<< HEAD
            // button1
            // 
            button1.Location = new Point(81, 94);
            button1.Name = "button1";
            button1.Size = new Size(205, 36);
            button1.TabIndex = 2;
            button1.Text = "Очистить текст";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_click;
=======
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.krasivyi_snimok_lesa_s_vysokimi_zelenymi_derev_ami;
            pictureBox1.Location = new Point(12, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 311);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
>>>>>>> 49a53fde02f021b1099d862fb2d066d748e3ee70
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
<<<<<<< HEAD
            ClientSize = new Size(673, 249);
            Controls.Add(button1);
=======
            ClientSize = new Size(835, 385);
            Controls.Add(pictureBox1);
>>>>>>> 49a53fde02f021b1099d862fb2d066d748e3ee70
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "ШИЛО БЕЗУМЕН";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
<<<<<<< HEAD
        private Button button1;
=======
        private PictureBox pictureBox1;
>>>>>>> 49a53fde02f021b1099d862fb2d066d748e3ee70
    }
}
