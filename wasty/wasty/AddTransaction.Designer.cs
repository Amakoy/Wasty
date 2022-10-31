
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
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAddWaste = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            btnTotal = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTotal
            // 
            btnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTotal.ForeColor = System.Drawing.Color.White;
            btnTotal.Location = new System.Drawing.Point(125, 382);
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
            this.mainPanel.Location = new System.Drawing.Point(66, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(895, 542);
            this.mainPanel.TabIndex = 0;
            // 
            // lblAddSampah
            // 
            this.lblAddSampah.AutoSize = true;
            this.lblAddSampah.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddSampah.Location = new System.Drawing.Point(226, 50);
            this.lblAddSampah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddSampah.Name = "lblAddSampah";
            this.lblAddSampah.Size = new System.Drawing.Size(414, 50);
            this.lblAddSampah.TabIndex = 12;
            this.lblAddSampah.Text = "Add Transaksi Sampah";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(71, 437);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 20);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total Harga";
            // 
            // lblBerat
            // 
            this.lblBerat.AutoSize = true;
            this.lblBerat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBerat.Location = new System.Drawing.Point(71, 319);
            this.lblBerat.Name = "lblBerat";
            this.lblBerat.Size = new System.Drawing.Size(116, 20);
            this.lblBerat.TabIndex = 10;
            this.lblBerat.Text = "Berat Sampah";
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHp.Location = new System.Drawing.Point(71, 190);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(88, 20);
            this.lblHp.TabIndex = 9;
            this.lblHp.Text = "Nomor HP";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJenis.Location = new System.Drawing.Point(71, 254);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(115, 20);
            this.lblJenis.TabIndex = 8;
            this.lblJenis.Text = "Jenis Sampah";
            // 
            // lbTanggal
            // 
            this.lbTanggal.AutoSize = true;
            this.lbTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTanggal.Location = new System.Drawing.Point(71, 130);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.Size = new System.Drawing.Size(68, 20);
            this.lbTanggal.TabIndex = 7;
            this.lbTanggal.Text = "Tanggal";
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Location = new System.Drawing.Point(460, 134);
            this.dgvTransaksi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.RowHeadersWidth = 62;
            this.dgvTransaksi.RowTemplate.Height = 33;
            this.dgvTransaksi.Size = new System.Drawing.Size(386, 350);
            this.dgvTransaksi.TabIndex = 6;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(71, 459);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(281, 27);
            this.tbTotal.TabIndex = 4;
            // 
            // tbJenis
            // 
            this.tbJenis.Location = new System.Drawing.Point(71, 277);
            this.tbJenis.Margin = new System.Windows.Forms.Padding(2);
            this.tbJenis.Name = "tbJenis";
            this.tbJenis.Size = new System.Drawing.Size(281, 27);
            this.tbJenis.TabIndex = 3;
            // 
            // tbBerat
            // 
            this.tbBerat.Location = new System.Drawing.Point(71, 342);
            this.tbBerat.Margin = new System.Windows.Forms.Padding(2);
            this.tbBerat.Name = "tbBerat";
            this.tbBerat.Size = new System.Drawing.Size(281, 27);
            this.tbBerat.TabIndex = 2;
            // 
            // tbHp
            // 
            this.tbHp.Location = new System.Drawing.Point(71, 213);
            this.tbHp.Margin = new System.Windows.Forms.Padding(2);
            this.tbHp.Name = "tbHp";
            this.tbHp.Size = new System.Drawing.Size(281, 27);
            this.tbHp.TabIndex = 1;
            // 
            // tbTanggal
            // 
            this.tbTanggal.Location = new System.Drawing.Point(71, 152);
            this.tbTanggal.Margin = new System.Windows.Forms.Padding(2);
            this.tbTanggal.Name = "tbTanggal";
            this.tbTanggal.Size = new System.Drawing.Size(281, 27);
            this.tbTanggal.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.sidePanel.Controls.Add(this.btnRecords);
            this.sidePanel.Controls.Add(this.btnHome);
            this.sidePanel.Controls.Add(this.btnAddWaste);
            this.sidePanel.Controls.Add(this.btnTransaction);
            this.sidePanel.Controls.Add(this.btnCustomers);
            this.sidePanel.Location = new System.Drawing.Point(-1, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(68, 542);
            this.sidePanel.TabIndex = 1;
            // 
            // btnRecords
            // 
            this.btnRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.btnRecords.Image = global::wasty.Properties.Resources.records;
            this.btnRecords.Location = new System.Drawing.Point(0, 316);
            this.btnRecords.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(68, 60);
            this.btnRecords.TabIndex = 16;
            this.btnRecords.UseVisualStyleBackColor = false;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Image = global::wasty.Properties.Resources.homepage;
            this.btnHome.Location = new System.Drawing.Point(0, 88);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(68, 60);
            this.btnHome.TabIndex = 15;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAddWaste
            // 
            this.btnAddWaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.btnAddWaste.Image = global::wasty.Properties.Resources.add_waste;
            this.btnAddWaste.Location = new System.Drawing.Point(0, 259);
            this.btnAddWaste.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddWaste.Name = "btnAddWaste";
            this.btnAddWaste.Size = new System.Drawing.Size(68, 60);
            this.btnAddWaste.TabIndex = 17;
            this.btnAddWaste.UseVisualStyleBackColor = false;
            this.btnAddWaste.Click += new System.EventHandler(this.btnAddWaste_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.btnTransaction.Image = global::wasty.Properties.Resources.add_transcation;
            this.btnTransaction.Location = new System.Drawing.Point(0, 145);
            this.btnTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(68, 60);
            this.btnTransaction.TabIndex = 19;
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.btnCustomers.Image = global::wasty.Properties.Resources.add_customers;
            this.btnCustomers.Location = new System.Drawing.Point(0, 202);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(68, 60);
            this.btnCustomers.TabIndex = 18;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 542);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddTransaction";
            this.Text = "AddTransaction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTransaction_FormClosed);
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.sidePanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnAddWaste;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnTransaction;
    }
}