using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Npgsql;
using System.Globalization;

namespace wasty
{
    public partial class AddTransaction : Form
    {
        Transaction trans = new Transaction();
        public AddTransaction()
        {
            InitializeComponent(); 
        }

        //database connection
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=raisa10112001;Database=wasty";
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void AddTransaction_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            FillCbHP();
            FillCbWasteType();
        }
        private void btnTotal_Click(object sender, EventArgs e)
        {
            string wasteUnit = lblUnit.Text;
            float unitPrice = float.Parse(lblUnitPrice.Text, CultureInfo.InvariantCulture);

            if (wasteUnit == "Berat")
            {
                //call method hitung dengan berat  
                float weight = float.Parse(tbBerat.Text, CultureInfo.InvariantCulture);
                trans.CalcPrice(unitPrice, weight);

                tbTotal.Text = trans.TotalPrice.ToString();
            }
            else if (wasteUnit == "Buah")
            {
                // call method hitung dengan unit buah
                float num = int.Parse(tbBerat.Text, CultureInfo.InvariantCulture);
                trans.CalcPrice(unitPrice, num);

                tbTotal.Text = trans.TotalPrice.ToString();
            }
            else
            {
                MessageBox.Show("Masukkan unit sampah yang benar");
            }
                
        }
        private void FillCbHP()
        {
            conn.Open();

            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbCustomer.Items.Add(dr["customer_name"].ToString());
            }
            conn.Close();
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
            foreach (DataRow dr in dt.Rows)
            {
                cbWasteType.Items.Add(dr["waste_type"].ToString());
            }
            conn.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                if (tbTanggal.Text == "")
                {
                    sql = @"select * from st_insert_record(:_weight_of_goods, :_total_price, :_customer_name)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_weight_of_goods", float.Parse(tbBerat.Text, CultureInfo.InvariantCulture.NumberFormat));
                    cmd.Parameters.AddWithValue("_total_price", float.Parse(tbTotal.Text, CultureInfo.InvariantCulture.NumberFormat));
                    cmd.Parameters.AddWithValue("_customer_name", cbCustomer.Text);
                }

                else
                {
                    sql = @"select * from st_insert_record(:_record_date, :_weight_of_goods, :_total_price, :_customer_name)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_record_date", tbTanggal.Text);
                    cmd.Parameters.AddWithValue("_weight_of_goods", float.Parse(tbBerat.Text, CultureInfo.InvariantCulture.NumberFormat));
                    cmd.Parameters.AddWithValue("_total_price", float.Parse(tbTotal.Text, CultureInfo.InvariantCulture.NumberFormat));
                    cmd.Parameters.AddWithValue("_customer_name", cbCustomer.Text);
                }

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Transaksi telah berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    tbBerat.Text = tbTotal.Text = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Add FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                lblUnit.Text = dr["waste_unit"].ToString();
            }
            conn.Close();
        }
        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customer where customer_name='" + cbCustomer.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();
        }

        // sidebar navigation
        private void AddTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void lblBerat_Click(object sender, EventArgs e)
        {

        }
        //panel border
        private void panel1_Paint(object sender, PaintEventArgs e)
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
    }
    
}
