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
using System.Xml.Linq;

namespace Wealthify
{
    public partial class ArtikelListForm : Form
    {
        public ArtikelListForm()
        {
            InitializeComponent();
        }

        private DataGridViewRow r;
        private DataTable dt;

        private void ArtikelListForm_Load(object sender, EventArgs e)
        {
            CRUD.sql = "SELECT * FROM artikel";
            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            dt = CRUD.PerformCrud(CRUD.cmd);
            dgvArtikel.DataSource = dt;
        }

        private void dgvArtikel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvArtikel.Rows[e.RowIndex];
                Artikel.SelectedID = r.Cells["artikel_id"].Value.ToString();
                UpdateArtikelForm fupdate = new UpdateArtikelForm();
                this.Hide();
                fupdate.Show();
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            ArtikelForm fartikel = new ArtikelForm();
            fartikel.Show();
            this.Hide();
        }
    }
}
