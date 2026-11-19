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
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // judul
            // 
            judul.AutoSize = true;
            judul.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            judul.Location = new Point(366, 149);
            judul.Name = "judul";
            judul.Size = new Size(95, 35);
            judul.TabIndex = 0;
            judul.Text = "Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Gainsboro;
            lblUsername.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(252, 210);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 24);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(252, 247);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(310, 27);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Gainsboro;
            lblPassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(254, 325);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 24);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(252, 362);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(310, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lime;
            btnLogin.Location = new Point(162, 250);
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
            picLogo.Location = new Point(357, 36);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(140, 87);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 6;
            picLogo.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.Gainsboro;
            panelLogin.Controls.Add(chkLihatPassword);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Location = new Point(90, 187);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(677, 384);
            panelLogin.TabIndex = 7;
            // 
            // chkLihatPassword
            // 
            chkLihatPassword.AutoSize = true;
            chkLihatPassword.Location = new Point(162, 208);
            chkLihatPassword.Name = "chkLihatPassword";
            chkLihatPassword.Size = new Size(128, 24);
            chkLihatPassword.TabIndex = 0;
            chkLihatPassword.Text = "Lihat Password";
            chkLihatPassword.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 609);
            Controls.Add(picLogo);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(judul);
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
    }
}