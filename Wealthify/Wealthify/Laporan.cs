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
            lblAdmin.Visible = Pengguna.IsAdmin;
            lblName.Text = Pengguna.Name;
            lblEmail.Text = Pengguna.Email;
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

        private void panelArtikel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelArtikel_Click(object sender, EventArgs e)
        {
            ArtikelForm fartikel = new ArtikelForm();
            fartikel.Show();
            this.Hide();
        }

        private void lblArtikel_Click(object sender, EventArgs e)
        {
            ArtikelForm fartikel = new ArtikelForm();
            fartikel.Show();
            this.Hide();
        }

        private void btnArtikel_Click(object sender, EventArgs e)
        {
            ArtikelForm fartikel = new ArtikelForm();
            fartikel.Show();
            this.Hide();
        }

        private void lblLaporan_Click(object sender, EventArgs e)
        {

        }
    }
}
