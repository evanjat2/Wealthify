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
    public partial class Laporan : Form
    {
        public Laporan()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=wealthify";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private void Laporan_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void lblKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambahKantong_Click(object sender, EventArgs e)
        {
            TambahKantong tk = new TambahKantong();
            tk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgv.DataSource = null;
                sql = "select * from lihat_kantong()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgv.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
