using System;

namespace PROJEKKKK_PBOO.Models
{
    // Data panen untuk satu hari
    public class DataPanen
    {
        public DateTime Tanggal { get; set; }
        public int AyamProduktif { get; set; }
        public int Telur { get; set; }

        // telur per ayam, contoh 0,83
        public double Produktivitas
        {
            get { return (double)Telur / AyamProduktif; }
        }

        // dalam persen, contoh 83
        public double Persentase
        {
            get { return Produktivitas * 100; }
        }
    }
}