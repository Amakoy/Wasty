using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.Runtime.InteropServices; // library untuk border radius

namespace wasty
{
    public partial class HomePage : Form
    {
        private static string pgPassword;
        private NpgsqlConnection conn;
        string connstring;
        //public static NpgsqlConnection conn = new NpgsqlConnection(connectionString: connstring);
        public DataTable dt;
        public static NpgsqlCommand cmd;

        Admin admin = new Admin();
        private static string username;

        public HomePage(string user, string pgPass)
        {
            username = user;
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // border radius
            pgPassword = pgPass;
            connstring = "Host=localhost;Port=5432;Username=postgres;Password=" + pgPassword + ";Database=wasty";
        }
        public HomePage()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // border radius
            connstring = "Host=localhost;Port=5432;Username=postgres;Password=" + pgPassword + ";Database=wasty";
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] // import untuk border radius
        private static extern IntPtr CreateRoundRectRgn
        (
            // untuk membuat border radius
            int nLeftRect,          // x-coordinate of upper-left corner
            int nTopRect,           // y-coordinate of upper-left corner
            int nRightRect,         // x-coordinate of lower-right corner
            int nBottonRect,        // y-coordinate of lower-right corner
            int nWidthEllipse,       // width of ellipse
            int nHeightEllipse       // height of ellipse
        );
        private void HomePage_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            lblAdmEmail.Text = username;
            FillAdminInfo();

            // style
            adminPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, adminPanel.Width, adminPanel.Height, 45, 45));
            pbLogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbLogo.Width, pbLogo.Height, 45, 45));
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

        //sidebar navigation
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowRecords showRecords = new ShowRecords(pgPassword);
            showRecords.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            // panel border
            ControlPaint.DrawBorder(e.Graphics, this.panel9.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // panel border
            ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }
    }
}
