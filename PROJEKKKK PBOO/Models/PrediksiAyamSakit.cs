using System;

namespace PROJEKKKK_PBOO.Models
{
    // Inharitance 
    public class PrediksiAyamModel : Prediksi
    {
        public PrediksiAyamModel(int jumlahAyam, int ayamSakit)
            : base(jumlahAyam, ayamSakit) { }

        // Override
        public override double HitungPersentase()
        {
            return Math.Round(base.HitungPersentase(), 2);
        }

        // OVERRIDE: istilah status khusus ayam
        public  string TentukanStatus(double sebelumnya, double sekarang)
        {
            if (sekarang > sebelumnya) return "Meningkat";
            if (sekarang < sebelumnya) return "Menurun";
            return "Stabil";
        }
    }
}

