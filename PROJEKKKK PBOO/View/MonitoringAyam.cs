
using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using PROJEKKKK_PBOO.Controller;

namespace PROJEKKKK_PBOO.View
{
    public partial class desain_monitoring : Form
    {
        monitoringAyamController controller =
            new monitoringAyamController();

        public desain_monitoring()
        {
            InitializeComponent();

            // Menghubungkan tombol
            button2.Click += button2_Click;
            button3.Click += button3_Click;

            // Pengaturan tabel
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Form dibuka
        private void desain_monitoring_Load(
            object sender, EventArgs e)
        {
            TampilkanData();
        }

        // Mengambil data dari database
        private void TampilkanData()
        {
            try
            {
                dataGridView1.DataSource = controller.AmbilData();

                SembunyikanKolom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data: " + ex.Message);
            }
        }

        // Menyembunyikan kolom yang tidak diperlukan
        private void SembunyikanKolom()
        {
            string[] kolom =
            {
                "id",
                "kondisi",
                "jumlah_ayam_sakit"
            };

            foreach (string namaKolom in kolom)
            {
                if (dataGridView1.Columns.Contains(namaKolom))
                {
                    dataGridView1.Columns[namaKolom].Visible = false;
                }
            }
        }

        // TOMBOL SIMPAN
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tanggal;
                int totalAyam;
                int jumlahSakit;

                // Validasi tanggal
                string[] formatTanggal =
                {
                    "dd-MM-yyyy",
                    "dd/MM/yyyy",
                    "yyyy-MM-dd"
                };

                if (!DateTime.TryParseExact(
                    textBox1.Text.Trim(),
                    formatTanggal,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out tanggal))
                {
                    MessageBox.Show(
                        "Tanggal tidak valid!\nContoh: 21-11-2026");
                    return;
                }

                // Validasi total ayam
                if (!int.TryParse(textBox2.Text, out totalAyam))
                {
                    MessageBox.Show(
                        "Total jumlah ayam harus berupa angka!");
                    return;
                }

                // Validasi jumlah ayam sakit
                if (!int.TryParse(textBox3.Text, out jumlahSakit))
                {
                    MessageBox.Show(
                        "Jumlah ayam sakit harus berupa angka!");
                    return;
                }

                // Memastikan jumlah ayam benar
                if (totalAyam <= 0 ||
                    jumlahSakit < 0 ||
                    jumlahSakit > totalAyam)
                {
                    MessageBox.Show("Jumlah ayam tidak valid!");
                    return;
                }

                // Menyimpan data ke database
                controller.Simpan(
                    tanggal,
                    totalAyam,
                    jumlahSakit,
                    textBox4.Text,
                    textBox5.Text
                );

                MessageBox.Show("Data berhasil disimpan!");

                // Memperbarui tabel
                TampilkanData();

                // Mengosongkan input
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Data gagal disimpan: " + ex.Message);
            }
        }

        // TOMBOL HAPUS
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null ||
                    dataGridView1.CurrentRow.IsNewRow)
                {
                    MessageBox.Show(
                        "Pilih data yang ingin dihapus!");
                    return;
                }

                int id = Convert.ToInt32(
                    dataGridView1.CurrentRow.Cells["id"].Value
                );

                DialogResult hasil = MessageBox.Show(
                    "Yakin ingin menghapus data ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (hasil == DialogResult.Yes)
                {
                    controller.Hapus(id);

                    MessageBox.Show("Data berhasil dihapus!");

                    TampilkanData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menghapus data: " + ex.Message);
            }
        }

        // TOMBOL RESET
        private void button3_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // Mengosongkan semua input
        private void ResetForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}
