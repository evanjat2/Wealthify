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
        public DataGridViewRow r;

        private void Laporan_Load(object sender, EventArgs e)
        {
            lblAdmin.Visible = Pengguna.IsAdmin;
            lblName.Text = Pengguna.Name;
            lblEmail.Text = Pengguna.Email;
            LihatKantong();
        }

        public void LihatKantong()
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            dgvKantong.DataSource = null;
            sql = "select * from lihat_kantong()";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dgvKantong.DataSource = dt;
            dgvKantong.AutoResizeColumns();
            conn.Close();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Transaksi tr = new Transaksi();
            tr.Show();
            this.Hide();
        }

        private void btnArtikel_Click(object sender, EventArgs e)
        {
            ArtikelForm fartikel = new ArtikelForm();
            fartikel.Show();
            this.Hide();
        }

        private void lblKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTambahKantong_Click(object sender, EventArgs e)
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

        private void btnTampilKantong_Click(object sender, EventArgs e)
        {
            LihatKantong();
        }

        private void btnUbahKantong_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris kantong yang ingin diedit", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from ubah_kantong(:_nomor_kantong,:_jenis_kantong,:_nama_kantong,:_saldo)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nomor_kantong", r.Cells["_nomor_kantong"].Value);
                cmd.Parameters.AddWithValue("_jenis_kantong", cbJenisKantong.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("_nama_kantong", tbNamaKantong.Text);
                cmd.Parameters.AddWithValue("_saldo", Convert.ToInt32(tbSaldo.Text));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Kantong telah berhasil diubah", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvKantong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvKantong.Rows[e.RowIndex];
                cbJenisKantong.SelectedItem = r.Cells["_jenis_kantong"].Value.ToString();
                tbNamaKantong.Text = r.Cells["_nama_kantong"].Value.ToString();
                tbSaldo.Text = r.Cells["_saldo"].Value.ToString();
            }
        }
    }
}
