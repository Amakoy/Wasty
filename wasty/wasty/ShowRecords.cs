using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
        }
    }
}
