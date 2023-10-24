namespace practica_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 9);
            label1.Name = "label1";
            label1.Size = new Size(465, 24);
            label1.TabIndex = 0;
            label1.Text = "INTRODUCE LAS DIMENSIONES DEL CILINDRO ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 89);
            label2.Name = "label2";
            label2.Size = new Size(72, 24);
            label2.TabIndex = 1;
            label2.Text = "RADIO";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 138);
            label3.Name = "label3";
            label3.Size = new Size(93, 24);
            label3.TabIndex = 2;
            label3.Text = "ALTURA ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 292);
            label4.Name = "label4";
            label4.Size = new Size(121, 24);
            label4.TabIndex = 3;
            label4.Text = "BASE AREA";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 342);
            label5.Name = "label5";
            label5.Size = new Size(157, 24);
            label5.TabIndex = 4;
            label5.Text = "LATERAL AREA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 402);
            label6.Name = "label6";
            label6.Size = new Size(134, 24);
            label6.TabIndex = 5;
            label6.Text = "TOTAL AREA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 451);
            label7.Name = "label7";
            label7.Size = new Size(109, 24);
            label7.TabIndex = 6;
            label7.Text = "VOLUMEN";
            // 
            // button1
            // 
            button1.Location = new Point(96, 205);
            button1.Name = "button1";
            button1.Size = new Size(161, 42);
            button1.TabIndex = 7;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(315, 206);
            button2.Name = "button2";
            button2.Size = new Size(160, 41);
            button2.TabIndex = 8;
            button2.Text = "BORRAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(540, 206);
            button3.Name = "button3";
            button3.Size = new Size(155, 42);
            button3.TabIndex = 9;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(962, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 30);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 30);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(292, 286);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 30);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(292, 339);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 30);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(292, 396);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(188, 30);
            textBox5.TabIndex = 15;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(294, 445);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(186, 30);
            textBox6.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1200, 540);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "CALCULOS ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}