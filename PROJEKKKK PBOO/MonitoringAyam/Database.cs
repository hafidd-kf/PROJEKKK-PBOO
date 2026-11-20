using System;
using System.Data;
using Npgsql;

namespace MonitoringKesehatanAyam;

public class Database
{
    private static string koneksi = "Host=localhost;Port=5432;Database=fixPBO;Username=postgres;Password=zerarich";

    public static DataTable AmbilData()
    {
        using NpgsqlConnection con = new NpgsqlConnection(koneksi);
        con.Open();
        string sql = "SELECT * FROM monitoring ORDER BY id DESC";
        using NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
        using NpgsqlDataReader reader = cmd.ExecuteReader();
        DataTable tabel = new DataTable();
        tabel.Load(reader);
        return tabel;
    }

    public static void Simpan(DateTime tanggal, int totalAyam, int jumlahSakit, string gejala, string keterangan)
    {
        using NpgsqlConnection con = new NpgsqlConnection(koneksi);
        con.Open();
        string sql = "INSERT INTO monitoring\r\n        (tanggal, total_ayam, jumlah_sakit, gejala, keterangan)\r\n        VALUES (@tanggal, @total, @sakit, @gejala, @keterangan)";
        using NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@tanggal", tanggal.Date);
        cmd.Parameters.AddWithValue("@total", totalAyam);
        cmd.Parameters.AddWithValue("@sakit", jumlahSakit);
        cmd.Parameters.AddWithValue("@gejala", gejala);
        cmd.Parameters.AddWithValue("@keterangan", keterangan);
        cmd.ExecuteNonQuery();
    }

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
