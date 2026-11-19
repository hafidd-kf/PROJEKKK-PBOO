
using System;
using System.Windows.Forms;
using PROJEKKKK_PBOO.Controller;

namespace PROJEKKKK_PBOO.View
{
    public partial class Login : Form
    {
        LoginController controller = new LoginController();

        public Login()
        {
            InitializeComponent();

            // Mengatur tampilan
            panelLogin.SendToBack();
            txtPassword.UseSystemPasswordChar = true;

            // Menghubungkan tombol
            btnLogin.Click += btnLogin_Click;

            // Fitur lihat password
            chkLihatPassword.CheckedChanged += chkLihatPassword_CheckedChanged;
        }

        // Tombol Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool berhasil = controller.ProsesLogin(
                txtUsername.Text.Trim(),
                txtPassword.Text
            );

            if (berhasil)
            {
                MessageBox.Show(
                    "Login berhasil. Selamat datang Owner!",
                    "MONTERA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                MenuUtama menu = new MenuUtama();

                menu.FormClosed += (s, args) => this.Close();

                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show(
                    "Username atau password salah!",
                    "Login Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        // Lihat Password
        private void chkLihatPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !chkLihatPassword.Checked;
        }

        // Event bawaan Designer
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
