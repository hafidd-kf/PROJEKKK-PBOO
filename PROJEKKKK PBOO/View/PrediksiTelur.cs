using PROJEKKKK_PBOO.Models;
using PROJEKKKK_PBOO.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace PROJEKKKK_PBOO.Prediksi_Telur
{
    public partial class PrediksiTelur : Form
    {
        private List<DataPanen> data = new List<DataPanen>();
        private PrediksiService service = new PrediksiService();

        public PrediksiTelur()
        {
            InitializeComponent();

            dgvPanen.AllowUserToAddRows = false;
            dgvPanen.ReadOnly = true;
            dgvPanen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPanen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPanen.Columns[4].FillWeight = 300;   // kolom Status dibuat lebih lebar

            // menghubungkan tombol dengan method di bawah
            btnSimpan.Click += btnSimpan_Click;
            btnReset.Click += btnReset_Click;
            btnHapus.Click += btnHapus_Click;

            txtTanggal.Text = DateTime.Today.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            TampilkanData();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DateTime tanggal;
            int ayam, telur;

            if (!DateTime.TryParseExact(txtTanggal.Text, "d/M/yyyy", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out tanggal))
            {
                MessageBox.Show("Format tanggal harus dd/MM/yyyy, contoh 18/11/2026");
                return;
            }

            if (!int.TryParse(txtAyam.Text, out ayam) || !int.TryParse(txtTelur.Text, out telur))
            {
                MessageBox.Show("Jumlah ayam dan jumlah telur harus diisi angka");
                return;
            }

            if (ayam <= 0 || telur < 0 || telur > ayam)
            {
                MessageBox.Show("Jumlah ayam harus lebih dari 0 dan telur tidak boleh melebihi jumlah ayam");
                return;
            }

            foreach (DataPanen d in data)
            {
                if (d.Tanggal == tanggal)
                {
                    MessageBox.Show("Data tanggal ini sudah ada");
                    return;
                }
            }

            DataPanen baru = new DataPanen();
            baru.Tanggal = tanggal;
            baru.AyamProduktif = ayam;
            baru.Telur = telur;
            data.Add(baru);

            // urutkan dari tanggal paling awal
            data.Sort((a, b) => a.Tanggal.CompareTo(b.Tanggal));

            TampilkanData();

            txtAyam.Clear();
            txtTelur.Clear();
            txtTanggal.Text = data[data.Count - 1].Tanggal.AddDays(1).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAyam.Clear();
            txtTelur.Clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPanen.CurrentRow == null)
            {
                MessageBox.Show("Pilih dulu baris yang ingin dihapus");
                return;
            }

            data.RemoveAt(dgvPanen.CurrentRow.Index);
            TampilkanData();
        }

        // mengisi tabel dari list data
        private void TampilkanData()
        {
            dgvPanen.Rows.Clear();

            for (int i = 0; i < data.Count; i++)
            {
                DataPanen d = data[i];
                double prediksi = service.PrediksiTelur(data, i);

                // urutan harus sama dengan urutan kolom di tabel
                dgvPanen.Rows.Add(
                    d.Tanggal.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    d.AyamProduktif,
                    d.Telur,
                    (prediksi / d.AyamProduktif * 100).ToString("0.0") + "%",
                    service.Status(data, i, prediksi));
            }
        }

        // dua method kosong ini sudah terhubung ke Designer, jangan dihapus
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dgvPanen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}