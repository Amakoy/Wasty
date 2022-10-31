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
    public partial class AddTransaction : Form
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

        public AddTransaction()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            /*AddTransaction addTransaction = new AddTransaction();
            addTransaction.Show();
            this.Hide();*/
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
    }
}
