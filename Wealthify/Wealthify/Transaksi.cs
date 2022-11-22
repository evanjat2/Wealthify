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
            TambahTransaksi tt = new TambahTransaksi();
            tt.Show();
        }

        private void btnTampilTransaksi_Click(object sender, EventArgs e)
        {
            LihatTransaksi();
        }
    }
}
