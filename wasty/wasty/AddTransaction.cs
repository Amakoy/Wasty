using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Npgsql;

namespace wasty
{
    public partial class AddTransaction : Form
    {

        public AddTransaction()
        {
            InitializeComponent(); 
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=raisa10112001;Database=wasty";

        private void AddTransaction_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            FillCbWasteType();
        }

        private void FillCbWasteType()
        { 
            conn.Open();

            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from waste";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cbWasteType.Items.Add(dr["waste_type"].ToString());
            }
            conn.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
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

        private void AddTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage Home = new HomePage();
            Home.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void btnLoaddata_Click(object sender, EventArgs e)
        {

        }

        private void cbWasteType_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from waste where waste_type='"+cbWasteType.SelectedItem.ToString()+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblUnitPrice.Text = dr["waste_price"].ToString();
            }
            conn.Close();
        }
    }
    
}
