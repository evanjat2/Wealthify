using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wealthify
{
    public partial class UpdateArtikelForm : Form
    {
        public UpdateArtikelForm()
        {
            InitializeComponent();
        }
        private DataTable dt;

        private void addParameters(string param)
        {
            if(param == "load")
            {
                CRUD.cmd.Parameters.Clear();
                CRUD.cmd.Parameters.AddWithValue("artikel_id", int.Parse(Artikel.SelectedID));
            }
            else if (param == "update")
            {
                CRUD.cmd.Parameters.Clear();
                CRUD.cmd.Parameters.AddWithValue("artikel_id", int.Parse(Artikel.SelectedID));
                CRUD.cmd.Parameters.AddWithValue("kategori", tbKategori.Text.Trim());
                CRUD.cmd.Parameters.AddWithValue("judul", tbJudul.Text.Trim());
                CRUD.cmd.Parameters.AddWithValue("konten", tbContent.Text.Trim());
            }

        }

        private void UpdateArtikelForm_Load(object sender, EventArgs e)
        {
            CRUD.sql = "SELECT * FROM artikel WHERE artikel_id = @artikel_id";
            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            addParameters("load");
            dt = CRUD.PerformCrud(CRUD.cmd);
            tbKategori.Text = (string)dt.Rows[0][1];
            tbJudul.Text = (string)dt.Rows[0][2];
            tbContent.Text = (string)dt.Rows[0][3];
            /*lblKategori3.Text = (string)dt.Rows[secondAfterIndex][1];*/
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            ArtikelListForm flistartikel = new ArtikelListForm();
            flistartikel.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            


            try
            {
                CRUD.sql = "UPDATE artikel SET kategori = @kategori , judul=@judul, konten = @konten WHERE artikel_id = @artikel_id";
                CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
                addParameters("update");
                CRUD.PerformCrud(CRUD.cmd);
                MessageBox.Show("Berhasil Update", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
