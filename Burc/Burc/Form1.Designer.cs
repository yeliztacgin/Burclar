namespace Burc
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(191, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 1;
            label1.Text = "DOĞUM TARİHİNİZİ GİRİNİZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 109);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 2;
            label2.Text = "BU GÜNE KADAR";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 88);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 49);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(281, 88);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 49);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(419, 88);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 49);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 109);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "GÜN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 109);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 7;
            label4.Text = "AY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(525, 109);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 8;
            label5.Text = "YIL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(176, 314);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 15;
            label7.Text = "BURCUNUZ";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(268, 197);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.Location = new Point(621, 240);
            button1.Name = "button1";
            button1.Size = new Size(114, 65);
            button1.TabIndex = 13;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(697, 37);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 14;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(697, 64);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 15;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(697, 88);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 16;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(697, 122);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 17;
            label11.Text = "label11";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(478, 37);
            dateTimePicker2.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            dateTimePicker2.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(183, 23);
            dateTimePicker2.TabIndex = 18;
            dateTimePicker2.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(478, 13);
            label12.Name = "label12";
            label12.Size = new Size(191, 15);
            label12.TabIndex = 19;
            label12.Text = "DOĞUM GÜNÜNE KAÇ GÜN KALDI";
            label12.Click += label12_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label12);
            Controls.Add(dateTimePicker2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePicker2;
        private Label label12;
    }
}