namespace WinFormsApp4
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(254, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 320);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 2;
            label1.Text = "Номер поезда";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 95);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 3;
            label2.Text = "Пункт назначения";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Location = new Point(26, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 320);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Location = new Point(566, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 320);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 95);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 6;
            label3.Text = "Номер поезда";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(590, 95);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 7;
            label4.Text = "Время отправления";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(204, 60);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 8;
            label5.Text = "Пункт назначения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(496, 60);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 9;
            label6.Text = "Время отправления";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(379, 60);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(663, 60);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(431, 9);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(218, 30);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
