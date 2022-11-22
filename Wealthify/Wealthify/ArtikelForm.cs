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
    public partial class ArtikelForm : Form
    {
        public ArtikelForm()
        {
            InitializeComponent();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Laporan flaporan = new Laporan();
            flaporan.Show();
            this.Hide();
        }

        private void lblLaporan_Click(object sender, EventArgs e)
        {
            Laporan flaporan = new Laporan();
            flaporan.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void getArticle(string mySQL)
        {
            CRUD.cmd = new NpgsqlCommand(mySQL, CRUD.con);
            var dt = CRUD.PerformCrud(CRUD.cmd);
            var index = Artikel.Index;
            int length = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                lblKategori1.Text = (string)dt.Rows[index][1];
                lblJudul1.Text = (string)dt.Rows[index][2];
                lblKonten1.Text = (string)dt.Rows[index][3];
                if (index + 1 == length)
                {
                    int afterIndex = 0;
                    lblKategori2.Text = (string)dt.Rows[afterIndex][1];
                    lblJudul2.Text = (string)dt.Rows[afterIndex][2];
                    lblKonten2.Text = (string)dt.Rows[afterIndex][3];
                }
                else
                {
                    int afterIndex = index + 1;
                    lblKategori2.Text = (string)dt.Rows[afterIndex][1];
                    lblJudul2.Text = (string)dt.Rows[afterIndex][2];
                    lblKonten2.Text = (string)dt.Rows[afterIndex][3];
                    if (afterIndex + 1 == length)
                    {
                        int secondAfterIndex = 0;
                        lblKategori3.Text = (string)dt.Rows[secondAfterIndex][1];
                        lblJudul3.Text = (string)dt.Rows[secondAfterIndex][2];
                        lblKonten3.Text = (string)dt.Rows[secondAfterIndex][3];
                    }
                    else
                    {
                        int secondAfterIndex = afterIndex + 1;
                        lblKategori3.Text = (string)dt.Rows[secondAfterIndex][1];
                        lblJudul3.Text = (string)dt.Rows[secondAfterIndex][2];
                        lblKonten3.Text = (string)dt.Rows[secondAfterIndex][3];
                    }
                }
            }
        }

        private void ArtikelForm_Load(object sender, EventArgs e)
        {
            CRUD.sql = "SELECT * FROM artikel";
            getArticle(CRUD.sql);
            Artikel.Index = 0;
            btnAdd.Visible = Pengguna.IsAdmin;
            btnUpdate.Visible = Pengguna.IsAdmin;
        }

        private void pbPrevious_Click(object sender, EventArgs e)
        {
            CRUD.sql = "SELECT * FROM artikel";
            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            var dt = CRUD.PerformCrud(CRUD.cmd);
            int index = Artikel.Index;
            int length = dt.Rows.Count;
            if (index - 1 == -1){
                Artikel.Index = length-1;
                getArticle(CRUD.sql);
            } else
            {
                Artikel.Index -= 1;
                getArticle(CRUD.sql);
            }
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            CRUD.sql = "SELECT * FROM artikel";
            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            var dt = CRUD.PerformCrud(CRUD.cmd);
            int index = Artikel.Index;
            int length = dt.Rows.Count;
            if (index + 1 == length)
            {
                Artikel.Index = 0;
                getArticle(CRUD.sql);
            }
            else
            {
                Artikel.Index += 1;
                getArticle(CRUD.sql);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddArticleForm fadd = new AddArticleForm();
            fadd.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ArtikelListForm flist = new ArtikelListForm();
            flist.Show();
            this.Hide();
        }
    }
}
