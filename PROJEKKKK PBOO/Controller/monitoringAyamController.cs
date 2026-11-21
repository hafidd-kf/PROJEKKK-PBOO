using System;
using System.Data;
using PROJEKKKK_PBOO.Services;

namespace PROJEKKKK_PBOO.Controller
{
    public class monitoringAyamController
    {
        public DataTable AmbilData()
        {
            return Database.AmbilData();
        }

        public void Simpan(
            DateTime tanggal,
            int totalAyam,
            int jumlahSakit,
            string gejala,
            string keterangan)
        {
            Database.Simpan(
                tanggal,
                totalAyam,
                jumlahSakit,
                gejala,
                keterangan
            );
        }

        public void Hapus(int id)
        {
            Database.Hapus(id);
        }
    }
}
