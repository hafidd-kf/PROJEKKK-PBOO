
using System;
using System.Globalization;
using System.Windows.Forms;

namespace PROJEKKKK_PBOO.PrediksiAyam
{
    public partial class PrediksiAyamSakit : Form
    {
        public PrediksiAyamSakit()
        {
            InitializeComponent();
            AturTabel();

            // Menghubungkan tombol
            btnSimpan.Click += btnSimpan_Click;
            btnReset.Click += btnReset_Click;
            btnHapus.Click += btnHapus_Click;
        }

        // Mengatur tabel
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

            dgvHasil.Columns["Persentase"].DefaultCellStyle.Format = "F2";
        }

        // TOMBOL SIMPAN
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DateTime tanggal;
            int jumlahAyam, ayamSakit;

            // Validasi tanggal dan angka
            if (!DateTime.TryParseExact(
                txtTanggal.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out tanggal))
            {
                MessageBox.Show("Format tanggal harus dd/MM/yyyy!");
                return;
            }

            if (!int.TryParse(txtJumlahAyam.Text, out jumlahAyam) ||
                !int.TryParse(txtAyamSakit.Text, out ayamSakit))
            {
                MessageBox.Show("Masukkan jumlah ayam dengan benar!");
                return;
            }

            // Validasi data
            if (jumlahAyam <= 0 ||
                ayamSakit < 0 ||
                ayamSakit > jumlahAyam)
            {
                MessageBox.Show("Data tidak valid!");
                return;
            }

            // Menghitung persentase ayam sakit
            double persentase =
                (double)ayamSakit / jumlahAyam * 100;

            // Menentukan status
            string status = "Data Awal";

            if (dgvHasil.Rows.Count > 0)
            {
                int barisTerakhir = dgvHasil.Rows.Count - 1;

                double sebelumnya = Convert.ToDouble(
                    dgvHasil.Rows[barisTerakhir].Cells[3].Value
                );

                if (persentase > sebelumnya)
                {
                    status = "Naik";
                }
                else if (persentase < sebelumnya)
                {
                    status = "Turun";
                }
                else
                {
                    status = "Tetap";
                }
            }

            // Menambahkan data ke tabel
            dgvHasil.Rows.Add(
                tanggal.ToString("dd/MM/yyyy"),
                jumlahAyam,
                ayamSakit,
                persentase,
                status
            );

            MessageBox.Show("Data berhasil disimpan!");

            // Mengosongkan input
            txtTanggal.Clear();
            txtJumlahAyam.Clear();
            txtAyamSakit.Clear();
            txtTanggal.Focus();
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
                MessageBox.Show("Pilih data yang ingin dihapus!");
                return;
            }

            foreach (DataGridViewRow row in dgvHasil.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dgvHasil.Rows.Remove(row);
                }
            }

            MessageBox.Show("Data berhasil dihapus!");
        }
    }
}
