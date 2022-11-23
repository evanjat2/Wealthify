using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Wealthify
{
    internal class Kantong
    {
        private int _nomor_kantong;
        private string _jenis_kantong;
        private string _nama_kantong;
        private int _saldo;
        private NpgsqlConnection conn;
        string connstring = CRUD.getConnectionString().ToString();
        public DataTable dt;
        private static NpgsqlCommand cmd;
        private string sql = null;
        public DataGridViewRow r;
        private NpgsqlDataReader rd;

        public int Nomor
        {
            get { return _nomor_kantong; }
        }

        public string Jenis
        {
            get { return _jenis_kantong; }
            set { _jenis_kantong = value; }
        }

        public string Nama
        {
            get { return _nama_kantong; }
            set { _nama_kantong = value; }
        }

        public int Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public Kantong() { }
        public Kantong(int NomorKantong)
        {
            _nomor_kantong = NomorKantong;
        }
        public Kantong(string JenisKantong, string NamaKantong, int Saldo)
        {
            _jenis_kantong = JenisKantong;
            _nama_kantong = NamaKantong;
            _saldo = Saldo;
        }
        public Kantong(int NomorKantong, string JenisKantong, string NamaKantong, int Saldo)
        {
            _nomor_kantong = NomorKantong;
            _jenis_kantong = JenisKantong;
            _nama_kantong = NamaKantong;
            _saldo = Saldo;
        }

        public void TambahKantong(Kantong kantong)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = @"select * from tambah_kantong(:_jenis_kantong,:_nama_kantong,:_saldo )";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_jenis_kantong", _jenis_kantong);
                cmd.Parameters.AddWithValue("_nama_kantong", _nama_kantong);
                cmd.Parameters.AddWithValue("_saldo", _saldo);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Kantong telah berhasil ditambahkan", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        public void UbahKantong (Kantong kantong)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = @"select * from ubah_kantong(:_nomor_kantong,:_jenis_kantong,:_nama_kantong,:_saldo)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nomor_kantong", _nomor_kantong);
                cmd.Parameters.AddWithValue("_jenis_kantong", _jenis_kantong);
                cmd.Parameters.AddWithValue("_nama_kantong", _nama_kantong);
                cmd.Parameters.AddWithValue("_saldo", _saldo);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Kantong telah berhasil diubah", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        public void HapusKantong(Kantong kantong)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = @"select * from hapus_kantong(:_nomor_kantong)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nomor_kantong", _nomor_kantong);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Kantong telah berhasil dihapus", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
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
