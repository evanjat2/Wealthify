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
        Keuangan keuangan;
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=wealthify";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Transaksi_Load(object sender, EventArgs e)
        {
            LihatKeuangan();
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

        public void LihatKeuangan()
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
            Laporan fLaporan = new Laporan();
            fLaporan.Show();
            this.Hide();
        }

        private void lblKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTambahTransaksi_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbKantong.SelectedItem == null || cbJenisTransaksi.SelectedItem == null ||
                    cbKategoriTransaksi.SelectedItem == null || dtpTanggalTransaksi.Text == "" || tbNominal.Text == "")
                {
                    MessageBox.Show("Isi data transaksi dengan benar", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    keuangan = new Keuangan(cbKantong.SelectedItem.ToString(), cbJenisTransaksi.SelectedItem.ToString(),
                        cbKategoriTransaksi.SelectedItem.ToString(), dtpTanggalTransaksi.Text, Convert.ToInt32(tbNominal.Text), tbCatatan.Text);
                    keuangan.TambahKeuangan(keuangan);
                    LihatKeuangan();
                    /*keuangan = new Keuangan(cbKantong.SelectedItem.ToString(), Convert.ToInt32(tbNominal.Text));
                    keuangan.UbahSaldoKantong(keuangan);*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbahTransaksi_Click(object sender, EventArgs e)
        {
            try
            {
                if (r == null)
                {
                    MessageBox.Show("Pilih baris transaksi yang ingin diedit", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    keuangan = new Keuangan(Convert.ToInt32(r.Cells["_nomor_transaksi"].Value), cbKantong.SelectedItem.ToString(),
                        cbJenisTransaksi.SelectedItem.ToString(), cbKategoriTransaksi.SelectedItem.ToString(), dtpTanggalTransaksi.Text,
                        Convert.ToInt32(tbNominal.Text), tbCatatan.Text);
                    keuangan.UbahKeuangan(keuangan);
                    cbKantong.SelectedItem = tbNominal.Text = tbCatatan.Text = null;
                    LihatKeuangan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnHapusTransaksi_Click(object sender, EventArgs e)
        {
            try
            {
                if (r == null)
                {
                    MessageBox.Show("Pilih baris transaksi yang ingin dihapus", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Apakah anda ingin menghapus transaksi " + r.Cells["_nomor_transaksi"].Value.ToString() + "?", "Hapus transaksi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    keuangan = new Keuangan(Convert.ToInt32(r.Cells["_nomor_transaksi"].Value));
                    keuangan.HapusKeuangan(keuangan);
                    cbKantong.SelectedItem = tbNominal.Text = tbCatatan.Text = null;
                    LihatKeuangan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();            }
        }

        private void btnTampilTransaksi_Click(object sender, EventArgs e)
        {
            LihatKeuangan();
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

        private void dgvTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvTransaksi.Rows[e.RowIndex];
                cbKantong.SelectedItem = r.Cells["_nama_kantong"].Value.ToString();
                cbJenisTransaksi.SelectedItem = r.Cells["_jenis_transaksi"].Value.ToString();
                cbKategoriTransaksi.SelectedItem = r.Cells["_kategori_transaksi"].Value.ToString();
                dtpTanggalTransaksi.Text = r.Cells["_tanggal"].Value.ToString();
                tbNominal.Text = r.Cells["_nominal"].Value.ToString();
                tbCatatan.Text = r.Cells["_catatan"].Value.ToString();
            }
        }

        private void btnArtikel_Click(object sender, EventArgs e)
        {
            ArtikelForm fArtikel = new ArtikelForm();
            fArtikel.Show();
            this.Hide();
        }
    }
}
