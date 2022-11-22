﻿using Npgsql;
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

        private void lblKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTambahKantong_Click(object sender, EventArgs e)
        {
            TambahKantong tk = new TambahKantong();
            tk.Show();
        }

        private void btnTampilKantong_Click(object sender, EventArgs e)
        {
            LihatKantong();
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
    }
}
