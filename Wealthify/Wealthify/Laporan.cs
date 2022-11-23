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
        Kantong kantong;
        private NpgsqlConnection conn;
        string connstring = CRUD.getConnectionString().ToString();
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
            Transaksi fTransaksi = new Transaksi();
            fTransaksi.Show();
            this.Hide();
        }

        private void btnArtikel_Click(object sender, EventArgs e)
        {
            ArtikelForm fArtikel = new ArtikelForm();
            fArtikel.Show();
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
                if (cbJenisKantong.SelectedItem == null || tbNamaKantong.Text == "")
                {
                    MessageBox.Show("Isi data kantong dengan benar", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    kantong = new Kantong(cbJenisKantong.SelectedItem.ToString(), tbNamaKantong.Text, Convert.ToInt32(tbSaldo.Text));
                    kantong.TambahKantong(kantong);
                    LihatKantong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbahKantong_Click(object sender, EventArgs e)
        {
            try
            {
                if (r == null)
                {
                    MessageBox.Show("Pilih baris kantong yang ingin diedit", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    kantong = new Kantong(Convert.ToInt32(r.Cells["_nomor_kantong"].Value), cbJenisKantong.SelectedItem.ToString(),
                        tbNamaKantong.Text, Convert.ToInt32(tbSaldo.Text));
                    kantong.UbahKantong(kantong);
                    cbJenisKantong.SelectedItem = tbNamaKantong.Text = tbSaldo.Text = null;
                    LihatKantong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnHapusKantong_Click(object sender, EventArgs e)
        {
            try
            {
                if (r == null)
                {
                    MessageBox.Show("Pilih baris kantong yang ingin dihapus", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Apakah anda ingin menghapus kantong " + r.Cells["_nomor_kantong"].Value.ToString() + "?", "Hapus kantong",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    kantong = new Kantong(Convert.ToInt32(r.Cells["_nomor_kantong"].Value));
                    kantong.HapusKantong(kantong);
                    cbJenisKantong.SelectedItem = tbNamaKantong.Text = tbSaldo.Text = null;
                    LihatKantong();
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
