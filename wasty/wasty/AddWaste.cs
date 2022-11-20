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
    public partial class AddWaste : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
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

        public AddWaste()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=raisa10112001;Database=wasty";
        //public static NpgsqlConnection conn = new NpgsqlConnection(connectionString: connstring);
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void AddWaste_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            ShowDgvWaste();

            // text box Type Style
            tbType.BorderStyle = BorderStyle.None;
            tbType.AutoSize = false;

            // text box Price Style
            tbPrice.BorderStyle = BorderStyle.None;
            tbPrice.AutoSize = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbType_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        // Close page
        private void lblClose_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin keluar?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            // panel border
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // panel border
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // panel border
            ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // panel border
            ControlPaint.DrawBorder(e.Graphics, this.panel4.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void tbType_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage Home = new HomePage();
            Home.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddTransaction AddTrans = new AddTransaction();
            AddTrans.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddCustomer AddCust = new AddCustomer();
            AddCust.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowRecords ShowRec = new ShowRecords();
            ShowRec.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void ShowDgvWaste()
        {
            try
            {
                conn.Open();
                dgvWaste.DataSource = null;
                sql = "select * from  select_waste()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvWaste.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from insert_waste(:_waste_type, :_waste_price, :_waste_unit)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_waste_type", tbType.Text);
                cmd.Parameters.AddWithValue("_waste_price", tbPrice.Text);
                cmd.Parameters.AddWithValue("_waste_unit", cbUnit.SelectedItem.ToString());
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Nasabah Berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    ShowDgvWaste();
                    tbType.Text = tbType.Text = cbUnit.Text = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Add FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvWaste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvWaste.Rows[e.RowIndex];
                tbType.Text = r.Cells["_waste_type"].Value.ToString();
                tbPrice.Text = r.Cells["_waste_price"].Value.ToString();
                cbUnit.Text = r.Cells["_waste_unit"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from update_waste(:_waste_id, :_waste_type, :_waste_price, :_waste_unit)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_waste_id", r.Cells["_waste_id"].Value.ToString());
                cmd.Parameters.AddWithValue("_waste_type", tbType.Text);
                cmd.Parameters.AddWithValue("_waste_price", tbPrice.Text);
                cmd.Parameters.AddWithValue("_waste_unit", cbUnit.SelectedItem.ToString());
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Nasabah Berhasil Diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    ShowDgvWaste();
                    tbType.Text = tbPrice.Text = cbUnit.Text = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Update FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Apakah benar anda ingin menghapsus data " + r.Cells["_waste_type"].Value.ToString() + " ?", "Hapus data terkonfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                try
                {
                    conn.Open();
                    sql = @"select * from delete_waste(:_waste_id)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_waste_id", r.Cells["_waste_id"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Nasabah Berhasil Dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        ShowDgvWaste();
                        tbType.Text = tbPrice.Text = null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Delete FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void dgvWaste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}