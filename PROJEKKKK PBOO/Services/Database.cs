using System;
using System.Data;
using Npgsql;

namespace PROJEKKKK_PBOO.Services
{
    public class Database
    {
        private static string koneksi =
            "Host=localhost;Port=5432;Database=fixPBO;Username=postgres;Password=zerarich";

        // Mengambil seluruh data
        public static DataTable AmbilData()
        {
            using NpgsqlConnection con = new NpgsqlConnection(koneksi);
            con.Open();

            string sql = @"
                SELECT id, tanggal, gejala, total_ayam,
                       jumlah_sakit, keterangan
                FROM monitoring
                ORDER BY id DESC";

            using NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            using NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);

            DataTable tabel = new DataTable();
            adapter.Fill(tabel);

            return tabel;
        }

        // Menyimpan data
        public static void Simpan(
            DateTime tanggal,
            int totalAyam,
            int jumlahSakit,
            string gejala,
            string keterangan)
        {
            using NpgsqlConnection con = new NpgsqlConnection(koneksi);
            con.Open();

            string sql = @"
                INSERT INTO monitoring
                (tanggal, gejala, total_ayam, jumlah_sakit, keterangan)
                VALUES
                (@tanggal, @gejala, @total, @sakit, @keterangan)";

            using NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@tanggal", tanggal.Date);
            cmd.Parameters.AddWithValue("@gejala", gejala ?? "");
            cmd.Parameters.AddWithValue("@total", totalAyam);
            cmd.Parameters.AddWithValue("@sakit", jumlahSakit);
            cmd.Parameters.AddWithValue("@keterangan", keterangan ?? "");

            cmd.ExecuteNonQuery();
        }

        // Menghapus data berdasarkan ID
        public static void Hapus(int id)
        {
            using NpgsqlConnection con = new NpgsqlConnection(koneksi);
            con.Open();

            string sql = "DELETE FROM monitoring WHERE id = @id";

            using NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
