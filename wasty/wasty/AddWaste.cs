using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void AddWaste_Load(object sender, EventArgs e)
        {
            // btnAdd Style
            btnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 45, 45));
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;

            // text box Type Style
            tbType.BorderStyle = BorderStyle.None;
            tbType.AutoSize = false;
            tbType.Size = new Size(450, 40);

            // text box Price Style
            tbPrice.BorderStyle = BorderStyle.None;
            tbPrice.AutoSize = false;
            tbPrice.Size = new Size(450, 40);

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
    }
}