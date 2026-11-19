
using System;
using System.Globalization;
using System.Windows.Forms;
using PROJEKKKK_PBOO.Controller;

namespace PROJEKKKK_PBOO.PrediksiAyam
{
    public partial class PrediksiAyamSakit : Form
    {
        // Menghubungkan View dengan Controller
        private readonly PrediksiAyamController controller =
            new PrediksiAyamController();

        public PrediksiAyamSakit()
        {
            InitializeComponent();
            AturTabel();

            btnSimpan.Click += btnSimpan_Click;
            btnReset.Click += btnReset_Click;
            btnHapus.Click += btnHapus_Click;
        }

        // MENGATUR TABEL
        private void AturTabel()
        {
            dgvHasil.Columns.Clear();

            dgvHasil.Columns.Add("Tanggal", "Tanggal");
            dgvHasil.Columns.Add("JumlahAyam", "Jumlah Ayam");
            dgvHasil.Columns.Add("AyamSakit", "Ayam Sakit");
            dgvHasil.Columns.Add("Persentase", "Persentase (%)");
            dgvHasil.Columns.Add("Status", "Status");

            dgvHasil.AllowUserToAddRows = false;
            dgvHasil.ReadOnly = true;

            dgvHasil.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvHasil.MultiSelect = true;

            dgvHasil.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvHasil.Columns["Persentase"]
                .DefaultCellStyle.Format = "F2";
        }

        // TOMBOL SIMPAN
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DateTime tanggal;
            int jumlahAyam, ayamSakit;

            if (!DateTime.TryParseExact(
                txtTanggal.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out tanggal))
            {
                MessageBox.Show(
                    "Format tanggal harus dd/MM/yyyy!");
                return;
            }

            if (!int.TryParse(
                    txtJumlahAyam.Text, out jumlahAyam) ||
                !int.TryParse(
                    txtAyamSakit.Text, out ayamSakit))
            {
                MessageBox.Show(
                    "Masukkan jumlah ayam dengan benar!");
                return;
            }

            try
            {
                // Mengambil data persentase sebelumnya
                bool dataAwal = dgvHasil.Rows.Count == 0;

                double sebelumnya = 0;

                if (!dataAwal)
                {
                    sebelumnya = Convert.ToDouble(
                        dgvHasil.Rows[
                            dgvHasil.Rows.Count - 1
                        ].Cells[3].Value);
                }

                // Memanggil Controller
                double persentase;

                string status = controller.HitungPrediksi(
                    jumlahAyam,
                    ayamSakit,
                    sebelumnya,
                    dataAwal,
                    out persentase
                );

                // Menampilkan hasil ke tabel
                dgvHasil.Rows.Add(
                    tanggal.ToString("dd/MM/yyyy"),
                    jumlahAyam,
                    ayamSakit,
                    persentase,
                    status
                );

                MessageBox.Show("Data berhasil disimpan!");

                txtTanggal.Clear();
                txtJumlahAyam.Clear();
                txtAyamSakit.Clear();
                txtTanggal.Focus();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // TOMBOL RESET
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTanggal.Clear();
            txtJumlahAyam.Clear();
            txtAyamSakit.Clear();
            txtTanggal.Focus();
        }

        // TOMBOL HAPUS
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvHasil.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Pilih data yang ingin dihapus!");
                return;
            }

            foreach (DataGridViewRow row
                in dgvHasil.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dgvHasil.Rows.Remove(row);
                }
            }

            MessageBox.Show("Data berhasil dihapus!");
        }

        private void pictureBox1_Click(
            object sender, EventArgs e)
        {
        }

        private void txtTanggal_TextChanged(
            object sender, EventArgs e)
        {
        }
    }
}
