using PROJEKKKK_PBOO.Models;
using System;

namespace PROJEKKKK_PBOO.Controller
{
    public class PrediksiAyamController
    {
        public string HitungPrediksi(
            int jumlahAyam,
            int ayamSakit,
            double sebelumnya,
            bool dataAwal,
            out double persentase)
        {
            // Memanggil Model
            PrediksiAyamModel prediksi =
                new PrediksiAyamModel(jumlahAyam, ayamSakit);

            // Menghitung persentase
            persentase = prediksi.HitungPersentase();

            // Menentukan status
            if (dataAwal)
            {
                return "Data Awal";
            }

            return prediksi.TentukanStatus(
                sebelumnya, persentase);
        }
    }
}
