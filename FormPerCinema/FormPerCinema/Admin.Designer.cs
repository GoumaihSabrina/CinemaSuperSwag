namespace FormPerCinema
{
    partial class Admin
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            bindingSource1 = new BindingSource(components);
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(308, 426);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(338, 276);
            button1.Name = "button1";
            button1.Size = new Size(87, 29);
            button1.TabIndex = 2;
            button1.Text = "Aggiungi";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(432, 276);
            button2.Name = "button2";
            button2.Size = new Size(87, 30);
            button2.TabIndex = 3;
            button2.Text = "Rimuovi";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(339, 150);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 23);
            textBox4.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 195);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 8;
            label1.Text = "Prezzo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 132);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 9;
            label2.Text = "Titolo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 194);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 11;
            label4.Text = "Tipo";
            label4.Click += label4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(561, 150);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 23);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(561, 132);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 13;
            label3.Text = "Data";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(339, 213);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(86, 23);
            numericUpDown1.TabIndex = 14;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2D", "3D", "4D" });
            comboBox1.Location = new Point(431, 213);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(88, 23);
            comboBox1.TabIndex = 15;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(339, 44);
            label5.Name = "label5";
            label5.Size = new Size(328, 74);
            label5.TabIndex = 16;
            label5.Text = "Admin Mode";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private BindingSource bindingSource1;
        private Label label5;
    }
}