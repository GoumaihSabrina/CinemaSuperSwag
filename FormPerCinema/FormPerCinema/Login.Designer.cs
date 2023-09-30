namespace FormPerCinema
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            label9 = new Label();
            textBox8 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(515, 48);
            label1.Name = "label1";
            label1.Size = new Size(158, 73);
            label1.TabIndex = 5;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(95, 47);
            label2.Name = "label2";
            label2.Size = new Size(213, 74);
            label2.TabIndex = 6;
            label2.Text = "Register";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 148);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 8;
            label3.Text = "Nome Utente";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 206);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 9;
            label4.Text = "Conferma Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 148);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Eamil";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 206);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 12;
            label6.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(31, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(209, 224);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(162, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(515, 224);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(162, 23);
            textBox6.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(515, 206);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 19;
            label7.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(515, 148);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 16;
            label9.Text = "Nome Utente";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(515, 166);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(162, 23);
            textBox8.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(170, 268);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Conferma";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(515, 268);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "Conferma";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(596, 268);
            button3.Name = "button3";
            button3.Size = new Size(133, 23);
            button3.TabIndex = 23;
            button3.Text = "password dimenticata";
            button3.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 337);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private Label label7;
        private Label label9;
        private TextBox textBox8;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}