using System;
using PROJEKKKK_PBOO.Models;

namespace PROJEKKKK_PBOO.Controller
{
    public class PrediksiTelurController
    {
        public string HitungPrediksi(
            int ayamProduktif,
            int telur,
            double sebelumnya,
            bool dataAwal,
            out double persentase)
        {
            // Mengambil data dari Model
            DataPanen data = new DataPanen
            {
                AyamProduktif = ayamProduktif,
                Telur = telur
            };

            // Menghitung persentase produktivitas
            persentase = data.Persentase;

            // Menentukan status
            if (dataAwal)
                return "Data Awal";

            if (persentase > sebelumnya)
                return "Meningkat";

            if (persentase < sebelumnya)
                return "Menurun";

            return "Stabil";
        }
    }
}
