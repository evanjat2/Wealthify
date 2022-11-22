using Npgsql;
using Npgsql.Internal.TypeHandlers.LTreeHandlers;
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
    public partial class TambahKantong : Form
    {
        public TambahKantong()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=wealthify;";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void TambahKantong_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from tambah_kantong(:_jenis_kantong,:_nama_kantong,:_saldo )";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_jenis_kantong", cbJenisKantong.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("_nama_kantong", tbNamaKantong.Text);
                cmd.Parameters.AddWithValue("_saldo", Convert.ToInt32(tbSaldo.Text));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Kantong telah berhasil ditambahkan", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    cbJenisKantong.SelectedItem = tbNamaKantong.Text = tbSaldo.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void tbJenisKantong_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbJenisKantong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNamaKantong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
