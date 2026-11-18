using System;
using System.Collections.Generic;
using System.Text;

namespace PROJEKKKK_PBOO.Models
{
    public class PrediksiAyamModel : Prediksi
    {
        public PrediksiAyamModel(int jumlahAyam, int ayamSakit)
            : base(jumlahAyam, ayamSakit) { }

        public string Status(double sebelumnya, double sekarang)
        {
            if (sekarang > sebelumnya)
                return "Meningkat";

            if (sekarang < sebelumnya)
                return "Menurun";

            return "Stabil";
        }
    }
}