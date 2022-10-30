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
    }
}
