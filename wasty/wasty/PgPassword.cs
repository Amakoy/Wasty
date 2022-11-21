using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace wasty
{
    public partial class PgPassword : Form
    {
        private NpgsqlConnection conn;
        string connstring;

        public PgPassword()
        {
            InitializeComponent();
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            connstring =  "Host=localhost;Port=5432;Username=postgres;Password=" + tbPgPassword.Text + ";Database=wasty";
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                conn.Close();
                LoginPage loginPage = new LoginPage(tbPgPassword.Text);
                loginPage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

        }

        private void PgPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PgPassword_Load(object sender, EventArgs e)
        {
        }
    }
}
