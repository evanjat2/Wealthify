using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wealthify
{
    internal class Keuangan
    {
        private int _nomor_transaksi;
        private string _nama_kantong;
        private string _jenis_transaksi;
        private string _kategori_transaksi;
        private string _tanggal;
        private int _nominal;
        private string _catatan;
        public int PerubahanSaldo = 0;
        private NpgsqlConnection conn;
        string connstring = CRUD.getConnectionString().ToString();
        public DataTable dt;
        private static NpgsqlCommand cmd;
        private string sql = null;
        public DataGridViewRow r;
        private NpgsqlDataReader rd;

        public int Nomor
        {
            get { return _nomor_transaksi; }
        }

        public string Jenis
        {
            get { return _jenis_transaksi; }
            set { _jenis_transaksi = value; }
        }

        public string Kategori
        {
            get { return _kategori_transaksi; }
            set { _kategori_transaksi = value; }
        }

        public string Tanggal
        {
            get { return _tanggal; }
            set { _tanggal = value; }
        }

        public int Nominal
        {
            get { return _nominal; }
            set { _nominal = value; }
        }

        public string Catatan
        {
            get { return _catatan; }
            set { _catatan = value; }
        }

        public Keuangan() { }
        public Keuangan(int NomorTransaksi)
        {
            _nomor_transaksi = NomorTransaksi;
        }
        public Keuangan(string NamaKantong, int Nominal)
        {
            _nama_kantong = NamaKantong;
            _nominal = Nominal;
        }
        public Keuangan(string NamaKantong, string JenisTransaksi, string KategoriTransaksi, string Tanggal, int Nominal, string Catatan)
        {
            _nama_kantong = NamaKantong;
            _jenis_transaksi = JenisTransaksi;
            _kategori_transaksi = KategoriTransaksi;
            _tanggal = Tanggal;
            _nominal = Nominal;
            _catatan = Catatan;
        }
        public Keuangan(int NomorTransaksi, string NamaKantong, string JenisTransaksi, string KategoriTransaksi, string Tanggal, int Nominal, string Catatan)
        {
            _nomor_transaksi = NomorTransaksi;
            _nama_kantong = NamaKantong;
            _jenis_transaksi = JenisTransaksi;
            _kategori_transaksi = KategoriTransaksi;
            _tanggal = Tanggal;
            _nominal = Nominal;
            _catatan = Catatan;
        }

        public void TambahKeuangan(Keuangan keuangan)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = @"select * from tambah_keuangan(:_nama_kantong,:_jenis_transaksi,:_kategori_transaksi,:_tanggal,:_nominal,:_catatan )";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama_kantong", _nama_kantong);
                cmd.Parameters.AddWithValue("_jenis_transaksi", _jenis_transaksi);
                cmd.Parameters.AddWithValue("_kategori_transaksi", _kategori_transaksi);
                cmd.Parameters.AddWithValue("_tanggal", _tanggal);
                cmd.Parameters.AddWithValue("_nominal", _nominal);
                cmd.Parameters.AddWithValue("_catatan", _catatan);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Transaksi telah berhasil ditambahkan", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        public void UbahKeuangan(Keuangan keuangan)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = @"select * from ubah_keuangan(:_nomor_transaksi,:_nama_kantong,:_jenis_transaksi,:_kategori_transaksi,:_tanggal,:_nominal,:_catatan )";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nomor_transaksi", _nomor_transaksi);
                cmd.Parameters.AddWithValue("_nama_kantong", _nama_kantong);
                cmd.Parameters.AddWithValue("_jenis_transaksi", _jenis_transaksi);
                cmd.Parameters.AddWithValue("_kategori_transaksi", _kategori_transaksi);
                cmd.Parameters.AddWithValue("_tanggal", _tanggal);
                cmd.Parameters.AddWithValue("_nominal", _nominal);
                cmd.Parameters.AddWithValue("_catatan", _catatan);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Transaksi telah berhasil diubah", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        public void HapusKeuangan(Keuangan keuangan)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = @"select * from hapus_keuangan(:_nomor_transaksi)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nomor_transaksi", _nomor_transaksi);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Transaksi telah berhasil dihapus", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void UbahSaldoKantong(string NamaKantong, int Saldo)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = @"select * from ubah_saldo_kantong(:_nama_kantong, :_saldo)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("_nama_kantong", NpgsqlDbType.Varchar).Value = NamaKantong;
                cmd.Parameters.Add("_saldo", NpgsqlDbType.Integer).Value = Saldo;

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        public void TotalSaldoKantong(string NamaKantong)
        {
            int Pemasukan = 0;
            int Pengeluaran = 0;
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = "select sum(nominal) as perubahan_saldo from keuangan where nama_kantong = '"
                    + NamaKantong + "' " + "and jenis_transaksi = 'Pemasukan'";
                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Pemasukan = int.Parse(rd["nominal"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn = new NpgsqlConnection(connstring);
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

            try
            {
                conn.Open();
                sql = "select sum(nominal) as perubahan_saldo from keuangan where nama_kantong = '"
                    + NamaKantong + "' " + "and jenis_transaksi = 'Pengeluaran'";
                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Pengeluaran = int.Parse(rd["nominal"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            PerubahanSaldo = Pemasukan - Pengeluaran;
        }
    }
}
