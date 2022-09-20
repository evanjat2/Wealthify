using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wealthify
{
    internal class Kantong
    {
        private int nomorKantong;
        private string jenisKantong;
        private string namaKantong;
        private float saldo;
        private float targetSaldo;

        public int NomorKantong
        {
            get { return nomorKantong; }
        }

        public string JenisKantong
        {
            get { return jenisKantong; }
            set { jenisKantong = value; }
        }

        public string NamaKantong
        {
            get { return namaKantong; }
            set { namaKantong = value; }
        }

        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public float TargetSaldo
        {
            get { return targetSaldo; }
            set { targetSaldo = value; }
        }

        public float SaldoMasuk(string jenisTransaksi, string namaKantong, float nominal)
        {
            if(jenisTransaksi == "income")
            {
                return nominal;
            }
            else
            {
                return 0;
            }
        }

        public float SaldoKeluar(string jenisTransaksi, string namaKantong, float nominal)
        {
            if (jenisTransaksi == "outcome")
            {
                return nominal;
            }
            else
            {
                return 0;
            }
        }
    }
}
