namespace PROJEKKKK_PBOO.View
{
    partial class desain_monitoring
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(352, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 22);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Tanggal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 55);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 3;
            label2.Text = "Total Jumlah Ayam";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(352, 27);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 88);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 5;
            label3.Text = "Jumlah Ayam Sakit";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(192, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(352, 27);
            textBox3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 121);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 7;
            label4.Text = "Gejala";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(192, 118);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(352, 27);
            textBox4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 154);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 9;
            label5.Text = "Keterangan";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(192, 151);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(352, 27);
            textBox5.TabIndex = 8;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(450, 184);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(339, 184);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Hapus";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(229, 184);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 258);
            label6.Name = "label6";
            label6.Size = new Size(175, 20);
            label6.TabIndex = 13;
            label6.Text = "Riwayat Kesehatan Ayam";
            label6.Click += label6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(965, 188);
            dataGridView1.TabIndex = 14;
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // desain_monitoring
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1057, 491);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "desain_monitoring";
            Text = "desain_monitoring";
            Load += desain_monitoring_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label6;
        private DataGridView dataGridView1;
    }
}