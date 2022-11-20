﻿using System;
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
    public partial class LoginPage : Form
    {
        private string username;
        public LoginPage()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // border radius
            this.username = username;
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=raisa10112001;Database=wasty";
        private NpgsqlCommand cmd;
        private string sql = null;


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

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // btnAdd Style
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 45, 45));
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;

            // text box Type Style
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.AutoSize = false;
         
            // text box Price Style
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.AutoSize = false;

            //Login
            //lblUser.Text = lblUser.Text + username;
            conn = new NpgsqlConnection(connstring);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin keluar?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from adm_login(:_adm_email, :_adm_pass)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_adm_email", tbUsername.Text);
                cmd.Parameters.AddWithValue("_adm_pass", tbPassword.Text);

                int result = (int)cmd.ExecuteScalar();

                conn.Close();

                if (result == 1) // login sukses
                {
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cek kembali email dan password Anda!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        /*private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Masukkan Username and Password");
            }
            else
            {
                if (tbUsername.Text == "admin" && tbPassword.Text == "admin")
                {
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah");
                }
            }
        }*/
    }
}
