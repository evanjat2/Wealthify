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
    public partial class AddArticleForm : Form
    {
        public AddArticleForm()
        {
            InitializeComponent();
        }
        private void execute(string mySQL)
        {
            CRUD.cmd = new NpgsqlCommand(mySQL, CRUD.con);
            addParameters();
            CRUD.PerformCrud(CRUD.cmd);
        }

        private void addParameters()
        {
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("kategori", tbKategori.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("judul", tbJudul.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("konten", tbContent.Text.Trim());
        }

        private void addArticle(string mySQL)
        {
            CRUD.cmd = new NpgsqlCommand(mySQL, CRUD.con);
            try
            {
                execute(CRUD.sql);
                MessageBox.Show("Artikel berhasil ditambahkan", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Gagal menambah artikel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKategori.Text.Trim()) || string.IsNullOrEmpty(tbJudul.Text.Trim()) || string.IsNullOrEmpty(tbContent.Text.Trim()))
            {
                MessageBox.Show("Mohon diisi semua", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                CRUD.sql = "INSERT INTO artikel(kategori,judul,konten) VALUES(@kategori,@judul,@konten)";
                addArticle(CRUD.sql);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Gagal Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddArticleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            ArtikelForm fartikel = new ArtikelForm();
            fartikel.Show();
            this.Hide();
        }
    }
}
