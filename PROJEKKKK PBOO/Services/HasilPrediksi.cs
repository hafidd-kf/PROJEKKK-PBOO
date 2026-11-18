using System;
using System.Collections.Generic;
using System.Text;

namespace PROJEKKKK_PBOO.Services
{
    public class HasilPrediksi
    {
        public int Hari { get; private set; }
        public double Persentase { get; private set; }
        public string Status { get; private set; }

        public HasilPrediksi(int hari, double persentase, string status)
        {
            Hari = hari;
            Persentase = persentase;
            Status = status;
        }
    }
}