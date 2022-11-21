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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        // database connection 
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=raisa10112001;Database=wasty";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            ShowCustDgv();
        }
        private void ShowCustDgv()
        {
            try
            {
                conn.Open();
                dgvCustomer.DataSource = null;
                sql = "select * from  select_cust()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvCustomer.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from st_insert(:_customer_name, :_customer_phone, :_customer_address)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_customer_name", tbNama.Text);
                cmd.Parameters.AddWithValue("_customer_phone", tbHp.Text);
                cmd.Parameters.AddWithValue("_customer_address", tbAlamat.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Nasabah Berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    ShowCustDgv();
                    tbNama.Text = tbHp.Text = tbAlamat.Text = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Add FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from st_update(:_customer_id, :_customer_name, :_customer_phone, :_customer_address)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_customer_id", r.Cells["_customer_id"].Value.ToString());
                cmd.Parameters.AddWithValue("_customer_name", tbNama.Text);
                cmd.Parameters.AddWithValue("_customer_phone", tbHp.Text);
                cmd.Parameters.AddWithValue("_customer_address", tbAlamat.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Nasabah Berhasil Diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    ShowCustDgv();
                    tbNama.Text = tbHp.Text = tbAlamat.Text = null;
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

            if (MessageBox.Show("Apakah benar anda ingin menghapsus data " + r.Cells["_customer_name"].Value.ToString() + " ?", "Hapus data terkonfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                try
                {
                    conn.Open();
                    sql = @"select * from delete_cust(:_customer_id)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_customer_id", r.Cells["_customer_id"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Nasabah Berhasil Dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        ShowCustDgv();
                        tbNama.Text = tbHp.Text = tbAlamat.Text = null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Delete FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvCustomer.Rows[e.RowIndex];
                tbNama.Text = r.Cells["_customer_name"].Value.ToString();
                tbHp.Text = r.Cells["_customer_phone"].Value.ToString();
                tbAlamat.Text = r.Cells["_customer_address"].Value.ToString();
            }
        }

        // sidebar navigation
        private void AddCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowRecords ShowRec = new ShowRecords();
            ShowRec.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddWaste addWaste = new AddWaste();
            addWaste.Show();
            this.Hide();
        }

        //panel border
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // panel border
            ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
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
    }
}