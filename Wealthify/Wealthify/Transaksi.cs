using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wealthify
{
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=wealthify";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void Transaksi_Load(object sender, EventArgs e)
        {
            LihatTransaksi();
            conn.Open();
            cbKantong.DataSource = null;
            sql = @"select nama_kantong from kantong";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader rd = cmd.ExecuteReader();
            List<string> cbKantongItems = new List<string>();
            while (rd.Read())
            {
                string kantong = rd["nama_kantong"].ToString();
                cbKantongItems.Add(kantong);
            }
            cbKantong.DataSource = cbKantongItems;
            conn.Close();
        }

        public void LihatTransaksi()
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            dgvTransaksi.DataSource = null;
            sql = "select * from lihat_keuangan()";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dgvTransaksi.DataSource = dt;
            dgvTransaksi.AutoResizeColumns();
            conn.Close();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Laporan lp = new Laporan();
            lp.Show();
            this.Hide();
        }

        private void btnTambahTransaksi_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from tambah_keuangan(:_nama_kantong,:_jenis_transaksi,:_kategori_transaksi,:_nominal,:_catatan )";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama_kantong", cbKantong.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("_jenis_transaksi", cbJenisTransaksi.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("_kategori_transaksi", cbKategoriTransaksi.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("_nominal", Convert.ToInt32(tbNominal.Text));
                cmd.Parameters.AddWithValue("_catatan", tbCatatan.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Kantong telah berhasil ditambahkan", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    cbKantong.SelectedItem = tbNominal.Text = tbCatatan.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnTampilTransaksi_Click(object sender, EventArgs e)
        {
            LihatTransaksi();
        }

        private void cbJenisTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKategoriTransaksi.SelectedItem = null;
            cbKategoriTransaksi.Items.Clear();
            if (cbJenisTransaksi.SelectedItem.ToString() == "Pemasukan")
            {
                cbKategoriTransaksi.Items.Add("Gaji");
                cbKategoriTransaksi.Items.Add("Bonus");
                cbKategoriTransaksi.Items.Add("Hadiah");
                cbKategoriTransaksi.Items.Add("Lainnya");
            }
            else if (cbJenisTransaksi.SelectedItem.ToString() == "Pengeluaran")
            {
                cbKategoriTransaksi.Items.Add("Makan & Minum");
                cbKategoriTransaksi.Items.Add("Transportasi");
                cbKategoriTransaksi.Items.Add("Belanja");
                cbKategoriTransaksi.Items.Add("Hiburan");
                cbKategoriTransaksi.Items.Add("Kesehatan");
                cbKategoriTransaksi.Items.Add("Lainnya");
            }
        }
    }
}
