using PROJEKKKK_PBOO.Models;
using System;
using System.Collections.Generic;

namespace PROJEKKKK_PBOO.Services
{
    // Prediksi sederhana:
    // 1. Produktivitas harian = telur / ayam produktif.
    // 2. Ambil rata-rata produktivitas maksimal 3 hari terakhir.
    // 3. Prediksi telur besok = rata-rata produktivitas x ayam produktif hari ini.
    // Jadi kalau ayam produktif berkurang, prediksi telur ikut turun.
    public class PrediksiService
    {
        // prediksi telur untuk hari setelah data ke-i
        public double PrediksiTelur(List<DataPanen> data, int i)
        {
            int awal = Math.Max(0, i - 2);
            double total = 0;
            for (int k = awal; k <= i; k++)
            {
                total += data[k].Produktivitas;
            }

            double rata = total / (i - awal + 1);
            return rata * data[i].AyamProduktif;
        }

        public string Status(List<DataPanen> data, int i, double prediksi)
        {
            double persen = data[i].Persentase;
            string status = "Rendah";
            if (persen >= 80) status = "Baik";
            else if (persen >= 60) status = "Cukup";

            // ayam produktif turun lebih dari 5% dari hari sebelumnya
            if (i > 0 && data[i].AyamProduktif < data[i - 1].AyamProduktif * 0.95)
                status += " (ayam produktif turun)";

            // prediksi besok turun lebih dari 5% dari telur hari ini
            if (prediksi < data[i].Telur * 0.95)
                status += " (diprediksi turun)";

            return status;
        }
    }
}