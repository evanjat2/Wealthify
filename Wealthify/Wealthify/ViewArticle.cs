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
    public partial class ViewArticle : Form
    {
        public ViewArticle()
        {
            InitializeComponent();
        }

        private void lblJudul1_Click(object sender, EventArgs e)
        {

        }

        private void addParameters(string param)
        {
            if (param == "load")
            {
                CRUD.cmd.Parameters.Clear();
                CRUD.cmd.Parameters.AddWithValue("artikel_id", int.Parse(Artikel.SelectedID));
            }
        }
        private void ViewArticle_Load(object sender, EventArgs e)
        {
            CRUD.sql = "SELECT * FROM artikel WHERE artikel_id = @artikel_id";
            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            addParameters("load");
            DataTable dt = CRUD.PerformCrud(CRUD.cmd);
            lblKategori.Text = (string)dt.Rows[0][1];
            lblJudul.Text = (string)dt.Rows[0][2];
            lblKonten.Text = (string)dt.Rows[0][3];
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            ArtikelForm fartikel = new ArtikelForm();
            fartikel.Show();
            this.Close();
        }
    }
}
