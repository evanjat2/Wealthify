using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Wealthify
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void execute(string mySQL, string param)
        {
            CRUD.cmd = new NpgsqlCommand(mySQL, CRUD.con);
            addParameters(param);
            CRUD.PerformCrud(CRUD.cmd);
        }
        private void checkEmail(string mySQL, string param)
        {
            CRUD.cmd = new NpgsqlCommand(mySQL, CRUD.con);
            addParameters(param);
            var dt = CRUD.PerformCrud(CRUD.cmd);
            if (dt.Rows.Count > 0 )
            {
                MessageBox.Show("Email telah dipakai", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CRUD.sql = "INSERT INTO pengguna(username,email,password) VALUES(@nama,@email,@password)";
                execute(CRUD.sql, "Insert");
                MessageBox.Show("Register Berhasil", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Laporan flaporan = new Laporan();
                flaporan.Show();
                this.Hide();
            }
        }

        private void addParameters(string str)
        {
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("nama", tbName.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("email", tbEmail.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("password", tbPassword.Text.Trim());
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login flogin = new Login();
            flogin.Show();
            this.Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void checkPass()
        {
            if (tbConfirmPassword.Text.Trim() == tbPassword.Text.Trim())
            {
                CRUD.sql = "SELECT * FROM pengguna WHERE email = @email";
                checkEmail(CRUD.sql, "Check");
            }
            else
            {
                MessageBox.Show("Cek kembali password anda", "Different Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbName.Text.Trim()) || string.IsNullOrEmpty(tbEmail.Text.Trim()))
            {
                MessageBox.Show("Please input name, email, and password","Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;            
            }

            try
            {
                checkPass();
                return;
            } catch(Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Gagal Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
