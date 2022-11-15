using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wealthify
{
    internal class Transaksi
    {
        private int nomorTransaksi;
        private string jenisTransaksi;
        private string kategoriTransaksi;
        private string namaKantong;
        private float nominal;
        private string catatan;

        public int NomorTransaksi
        {
            get { return nomorTransaksi; }
        }

        public string JenisTransaksi
        {
            get { return jenisTransaksi; }
            set { jenisTransaksi = value; }
        }

        public string KategoriTransaksi
        {
            get { return kategoriTransaksi; }
            set { kategoriTransaksi = value; }
        }

        public string NamaKantong
        {
            get { return namaKantong; }
            set { namaKantong = value; }
        }

        public float Nominal
        {
            get { return nominal; }
            set { nominal = value; }
        }

        public string Catatan
        {
            get { return catatan; }
            set { catatan = value; }
        }

        public void LaporanTransaksi(string jenisTransaksi, string kategoriTransaksi, string namaKantong, float nominal, string catatan)
        {
            return;
        }
    }
}
