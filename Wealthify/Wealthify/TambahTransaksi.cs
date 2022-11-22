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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wealthify
{
    public partial class TambahTransaksi : Form
    {
        public TambahTransaksi()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=wealthify;";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void TambahTransaksi_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
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
            else
            {

            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
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
    }
}
