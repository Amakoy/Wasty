using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace wasty
{
    public partial class HomePage : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=raisa10112001;Database=wasty";
        //public static NpgsqlConnection conn = new NpgsqlConnection(connectionString: connstring);
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        Admin admin = new Admin();
        
        public HomePage(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        public HomePage()
        {
            InitializeComponent();
        }
        private string username;

        private void HomePage_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            //lblAdmName.Text = 
            //lblAdmEmail.Text = admin.Email.ToString();
            lblAdmEmail.Text = username;
            FillAdminInfo();
        }
        private void FillAdminInfo()
        {

            conn.Open();

            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select adm_name from admin_tbl where adm_email='"+ username + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblAdmName.Text = dr["adm_name"].ToString();
            }
            conn.Close();
        }
        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnTransaction_Click_1(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction();
            addTransaction.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Hide();
        }

        private void btnAddWaste_Click(object sender, EventArgs e)
        {
            AddWaste addWaste = new AddWaste();
            addWaste.Show();
            this.Hide();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            ShowRecords showRecords = new ShowRecords();
            showRecords.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction();
            addTransaction.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddWaste addWaste = new AddWaste();
            addWaste.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowRecords showRecords = new ShowRecords();
            showRecords.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
