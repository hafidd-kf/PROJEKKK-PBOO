namespace PROJEKKKK_PBOO.PrediksiAyam
{
    partial class PrediksiAyamSakit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrediksiAyamSakit));
            txtTanggal = new TextBox();
            txtJumlahAyam = new TextBox();
            txtAyamSakit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvHasil = new DataGridView();
            btnSimpan = new Button();
            btnReset = new Button();
            btnHapus = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvHasil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(339, 54);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(197, 27);
            txtTanggal.TabIndex = 0;
            txtTanggal.TextChanged += txtTanggal_TextChanged;
            // 
            // txtJumlahAyam
            // 
            txtJumlahAyam.Location = new Point(339, 119);
            txtJumlahAyam.Name = "txtJumlahAyam";
            txtJumlahAyam.Size = new Size(197, 27);
            txtJumlahAyam.TabIndex = 1;
            // 
            // txtAyamSakit
            // 
            txtAyamSakit.Location = new Point(339, 196);
            txtAyamSakit.Name = "txtAyamSakit";
            txtAyamSakit.Size = new Size(197, 27);
            txtAyamSakit.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 53);
            label1.Name = "label1";
            label1.Size = new Size(94, 26);
            label1.TabIndex = 3;
            label1.Text = "Tanggal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 118);
            label2.Name = "label2";
            label2.Size = new Size(150, 26);
            label2.TabIndex = 4;
            label2.Text = "Jumlah Ayam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 197);
            label3.Name = "label3";
            label3.Size = new Size(209, 26);
            label3.TabIndex = 5;
            label3.Text = "Jumlah Ayam Sakit";
            // 
            // dgvHasil
            // 
            dgvHasil.BackgroundColor = Color.Aquamarine;
            dgvHasil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHasil.Location = new Point(53, 319);
            dgvHasil.Name = "dgvHasil";
            dgvHasil.RowHeadersWidth = 51;
            dgvHasil.Size = new Size(929, 233);
            dgvHasil.TabIndex = 6;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Lime;
            btnSimpan.Location = new Point(85, 259);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Yellow;
            btnReset.Location = new Point(199, 259);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.Location = new Point(318, 259);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 9;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(598, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 244);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PrediksiAyamSakit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1033, 592);
            Controls.Add(pictureBox1);
            Controls.Add(btnHapus);
            Controls.Add(btnReset);
            Controls.Add(btnSimpan);
            Controls.Add(dgvHasil);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAyamSakit);
            Controls.Add(txtJumlahAyam);
            Controls.Add(txtTanggal);
            Name = "PrediksiAyamSakit";
            Text = "PrediksiAyamSakit";
            ((System.ComponentModel.ISupportInitialize)dgvHasil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTanggal;
        private TextBox txtJumlahAyam;
        private TextBox txtAyamSakit;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvHasil;
        private Button btnSimpan;
        private Button btnReset;
        private Button btnHapus;
        private PictureBox pictureBox1;
    }
}