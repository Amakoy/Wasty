﻿
namespace wasty
{
    partial class AddTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnTotal;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransaction));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblAddSampah = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBerat = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lbTanggal = new System.Windows.Forms.Label();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbJenis = new System.Windows.Forms.TextBox();
            this.tbBerat = new System.Windows.Forms.TextBox();
            this.tbHp = new System.Windows.Forms.TextBox();
            this.tbTanggal = new System.Windows.Forms.TextBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btnTotal = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTotal
            // 
            btnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTotal.ForeColor = System.Drawing.Color.White;
            btnTotal.Location = new System.Drawing.Point(94, 379);
            btnTotal.Margin = new System.Windows.Forms.Padding(2);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new System.Drawing.Size(162, 33);
            btnTotal.TabIndex = 5;
            btnTotal.Text = "Hitung total";
            btnTotal.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
            this.mainPanel.Controls.Add(this.lblAddSampah);
            this.mainPanel.Controls.Add(this.lblTotal);
            this.mainPanel.Controls.Add(this.lblBerat);
            this.mainPanel.Controls.Add(this.lblHp);
            this.mainPanel.Controls.Add(this.lblJenis);
            this.mainPanel.Controls.Add(this.lbTanggal);
            this.mainPanel.Controls.Add(this.dgvTransaksi);
            this.mainPanel.Controls.Add(btnTotal);
            this.mainPanel.Controls.Add(this.tbTotal);
            this.mainPanel.Controls.Add(this.tbJenis);
            this.mainPanel.Controls.Add(this.tbBerat);
            this.mainPanel.Controls.Add(this.tbHp);
            this.mainPanel.Controls.Add(this.tbTanggal);
            this.mainPanel.Location = new System.Drawing.Point(106, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1053, 610);
            this.mainPanel.TabIndex = 0;
            // 
            // lblAddSampah
            // 
            this.lblAddSampah.AutoSize = true;
            this.lblAddSampah.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddSampah.Location = new System.Drawing.Point(347, 34);
            this.lblAddSampah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddSampah.Name = "lblAddSampah";
            this.lblAddSampah.Size = new System.Drawing.Size(303, 46);
            this.lblAddSampah.TabIndex = 12;
            this.lblAddSampah.Text = "Transaksi Sampah";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(40, 434);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 20);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total Harga";
            // 
            // lblBerat
            // 
            this.lblBerat.AutoSize = true;
            this.lblBerat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBerat.Location = new System.Drawing.Point(40, 316);
            this.lblBerat.Name = "lblBerat";
            this.lblBerat.Size = new System.Drawing.Size(116, 20);
            this.lblBerat.TabIndex = 10;
            this.lblBerat.Text = "Berat Sampah";
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHp.Location = new System.Drawing.Point(40, 187);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(88, 20);
            this.lblHp.TabIndex = 9;
            this.lblHp.Text = "Nomor HP";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJenis.Location = new System.Drawing.Point(40, 251);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(115, 20);
            this.lblJenis.TabIndex = 8;
            this.lblJenis.Text = "Jenis Sampah";
            // 
            // lbTanggal
            // 
            this.lbTanggal.AutoSize = true;
            this.lbTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTanggal.Location = new System.Drawing.Point(40, 127);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.Size = new System.Drawing.Size(68, 20);
            this.lbTanggal.TabIndex = 7;
            this.lbTanggal.Text = "Tanggal";
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Location = new System.Drawing.Point(404, 134);
            this.dgvTransaksi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.RowHeadersWidth = 62;
            this.dgvTransaksi.RowTemplate.Height = 33;
            this.dgvTransaksi.Size = new System.Drawing.Size(611, 438);
            this.dgvTransaksi.TabIndex = 6;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(40, 456);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(310, 27);
            this.tbTotal.TabIndex = 4;
            // 
            // tbJenis
            // 
            this.tbJenis.Location = new System.Drawing.Point(40, 274);
            this.tbJenis.Margin = new System.Windows.Forms.Padding(2);
            this.tbJenis.Name = "tbJenis";
            this.tbJenis.Size = new System.Drawing.Size(310, 27);
            this.tbJenis.TabIndex = 3;
            // 
            // tbBerat
            // 
            this.tbBerat.Location = new System.Drawing.Point(40, 339);
            this.tbBerat.Margin = new System.Windows.Forms.Padding(2);
            this.tbBerat.Name = "tbBerat";
            this.tbBerat.Size = new System.Drawing.Size(310, 27);
            this.tbBerat.TabIndex = 2;
            // 
            // tbHp
            // 
            this.tbHp.Location = new System.Drawing.Point(40, 210);
            this.tbHp.Margin = new System.Windows.Forms.Padding(2);
            this.tbHp.Name = "tbHp";
            this.tbHp.Size = new System.Drawing.Size(310, 27);
            this.tbHp.TabIndex = 1;
            // 
            // tbTanggal
            // 
            this.tbTanggal.Location = new System.Drawing.Point(40, 149);
            this.tbTanggal.Margin = new System.Windows.Forms.Padding(2);
            this.tbTanggal.Name = "tbTanggal";
            this.tbTanggal.Size = new System.Drawing.Size(310, 27);
            this.tbTanggal.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.sidePanel.Controls.Add(this.panel4);
            this.sidePanel.Controls.Add(this.panel3);
            this.sidePanel.Controls.Add(this.panel2);
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Location = new System.Drawing.Point(-1, -5);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(110, 615);
            this.sidePanel.TabIndex = 1;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidePanel_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(-7, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(117, 84);
            this.panel4.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(42, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(-7, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 84);
            this.panel3.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-7, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 84);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(37, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-7, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 84);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 605);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTransaction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTransaction_FormClosed);
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.TextBox tbHp;
        private System.Windows.Forms.TextBox tbTanggal;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbJenis;
        private System.Windows.Forms.TextBox tbBerat;
        private System.Windows.Forms.Label lblBerat;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.Label lbTanggal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAddSampah;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}