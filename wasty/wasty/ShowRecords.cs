using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace wasty
{
    public partial class ShowRecords : Form
    {
        public ShowRecords()
        {
            InitializeComponent();
        }

        private string pgPassword;
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=raisa10112001;Database=wasty";
        public static NpgsqlCommand cmd;
        private string sql = null;
        DataTable dt = null;

        public ShowRecords(string pgPass)
        {
            InitializeComponent();
            pgPassword = pgPass;
            connstring = "Host=localhost;Port=5432;Username=postgres;Password=" + pgPassword + ";Database=wasty";
        }

        private void ShowRecords_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                
                conn.Open();
                sql = @"select * from select_record()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvRecords.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // sidebar navigation
        private void ShowRecords_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction(pgPassword);
            addTransaction.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer(pgPassword);
            addCustomer.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddWaste addWaste = new AddWaste(pgPassword);
            addWaste.Show();
            this.Hide();
        }
        //panelborder
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // panel border
            ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            // panel border
            ControlPaint.DrawBorder(e.Graphics, this.panel8.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            // panel border
            ControlPaint.DrawBorder(e.Graphics, this.panel7.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            // panel border
            ControlPaint.DrawBorder(e.Graphics, this.panel6.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }
    }
}
