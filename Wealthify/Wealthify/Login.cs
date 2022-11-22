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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addParameters()
        {
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("email", tbEmail.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("password", tbPassword.Text.Trim());
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void checkValidation(string mySQL)
        {
            CRUD.cmd = new NpgsqlCommand(mySQL, CRUD.con);
            addParameters();
            var dt = CRUD.PerformCrud(CRUD.cmd);
            if (dt.Rows.Count > 0)
            {
                Pengguna.Email = (string)dt.Rows[0]["email"];
                Pengguna.Name = (string)dt.Rows[0]["username"];
                Pengguna.UserID = (int)dt.Rows[0]["user_id"];
                Pengguna.IsAdmin = (bool)dt.Rows[0]["isAdmin"];
                MessageBox.Show("Berhasil Login", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Laporan flaporan = new Laporan();
                flaporan.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Email atau password salah", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text.Trim()) || string.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                MessageBox.Show("Masukkan email dan password", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                CRUD.sql = "SELECT * FROM pengguna WHERE email = @email AND password = @password";
                checkValidation(CRUD.sql);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Gagal Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp fregister = new SignUp();
            fregister.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
