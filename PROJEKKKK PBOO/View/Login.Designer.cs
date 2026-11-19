namespace PROJEKKKK_PBOO.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            folderBrowserDialog1 = new FolderBrowserDialog();
            judul = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            picLogo = new PictureBox();
            panelLogin = new Panel();
            chkLihatPassword = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // judul
            // 
            judul.AutoSize = true;
            judul.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            judul.Location = new Point(262, 41);
            judul.Name = "judul";
            judul.Size = new Size(141, 27);
            judul.TabIndex = 0;
            judul.Text = "Login Akun";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(162, 112);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 24);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(162, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(310, 27);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.White;
            lblPassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(162, 190);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 24);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(162, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(310, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lime;
            btnLogin.Location = new Point(162, 291);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(310, 31);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Location = new Point(374, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(140, 87);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 6;
            picLogo.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.Controls.Add(chkLihatPassword);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(judul);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Location = new Point(90, 201);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(677, 335);
            panelLogin.TabIndex = 7;
            // 
            // chkLihatPassword
            // 
            chkLihatPassword.AutoSize = true;
            chkLihatPassword.Location = new Point(162, 250);
            chkLihatPassword.Name = "chkLihatPassword";
            chkLihatPassword.Size = new Size(128, 24);
            chkLihatPassword.TabIndex = 0;
            chkLihatPassword.Text = "Lihat Password";
            chkLihatPassword.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 138);
            label1.Name = "label1";
            label1.Size = new Size(423, 48);
            label1.TabIndex = 8;
            label1.Text = "Sistem Monitoring dan Prediksi Persentase \r\n\r\n";
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(882, 609);
            Controls.Add(label1);
            Controls.Add(picLogo);
            Controls.Add(panelLogin);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Label judul;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox picLogo;
        private Panel panelLogin;
        private CheckBox chkLihatPassword;
        private Label label1;
    }
}