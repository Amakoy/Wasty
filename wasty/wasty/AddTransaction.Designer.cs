
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
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
            btnTotal.Location = new System.Drawing.Point(156, 477);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new System.Drawing.Size(202, 41);
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
            this.mainPanel.Location = new System.Drawing.Point(83, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1119, 678);
            this.mainPanel.TabIndex = 0;
            // 
            // lblAddSampah
            // 
            this.lblAddSampah.AutoSize = true;
            this.lblAddSampah.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddSampah.Location = new System.Drawing.Point(282, 62);
            this.lblAddSampah.Name = "lblAddSampah";
            this.lblAddSampah.Size = new System.Drawing.Size(492, 60);
            this.lblAddSampah.TabIndex = 12;
            this.lblAddSampah.Text = "Add Transaksi Sampah";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(89, 546);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(114, 25);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total Harga";
            // 
            // lblBerat
            // 
            this.lblBerat.AutoSize = true;
            this.lblBerat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBerat.Location = new System.Drawing.Point(89, 399);
            this.lblBerat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBerat.Name = "lblBerat";
            this.lblBerat.Size = new System.Drawing.Size(137, 25);
            this.lblBerat.TabIndex = 10;
            this.lblBerat.Text = "Berat Sampah";
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHp.Location = new System.Drawing.Point(89, 237);
            this.lblHp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(102, 25);
            this.lblHp.TabIndex = 9;
            this.lblHp.Text = "Nomor HP";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJenis.Location = new System.Drawing.Point(89, 318);
            this.lblJenis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(138, 25);
            this.lblJenis.TabIndex = 8;
            this.lblJenis.Text = "Jenis Sampah";
            // 
            // lbTanggal
            // 
            this.lbTanggal.AutoSize = true;
            this.lbTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTanggal.Location = new System.Drawing.Point(89, 162);
            this.lbTanggal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.Size = new System.Drawing.Size(84, 25);
            this.lbTanggal.TabIndex = 7;
            this.lbTanggal.Text = "Tanggal";
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Location = new System.Drawing.Point(575, 168);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.RowHeadersWidth = 62;
            this.dgvTransaksi.RowTemplate.Height = 33;
            this.dgvTransaksi.Size = new System.Drawing.Size(482, 437);
            this.dgvTransaksi.TabIndex = 6;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(89, 574);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(350, 31);
            this.tbTotal.TabIndex = 4;
            // 
            // tbJenis
            // 
            this.tbJenis.Location = new System.Drawing.Point(89, 346);
            this.tbJenis.Name = "tbJenis";
            this.tbJenis.Size = new System.Drawing.Size(350, 31);
            this.tbJenis.TabIndex = 3;
            // 
            // tbBerat
            // 
            this.tbBerat.Location = new System.Drawing.Point(89, 427);
            this.tbBerat.Name = "tbBerat";
            this.tbBerat.Size = new System.Drawing.Size(350, 31);
            this.tbBerat.TabIndex = 2;
            // 
            // tbHp
            // 
            this.tbHp.Location = new System.Drawing.Point(89, 266);
            this.tbHp.Name = "tbHp";
            this.tbHp.Size = new System.Drawing.Size(350, 31);
            this.tbHp.TabIndex = 1;
            // 
            // tbTanggal
            // 
            this.tbTanggal.Location = new System.Drawing.Point(89, 190);
            this.tbTanggal.Name = "tbTanggal";
            this.tbTanggal.Size = new System.Drawing.Size(350, 31);
            this.tbTanggal.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.sidePanel.Controls.Add(this.button3);
            this.sidePanel.Controls.Add(this.btnHome);
            this.sidePanel.Controls.Add(this.button2);
            this.sidePanel.Controls.Add(this.btnTransaksi);
            this.sidePanel.Controls.Add(this.button1);
            this.sidePanel.Location = new System.Drawing.Point(-1, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(85, 678);
            this.sidePanel.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.button3.Image = global::wasty.Properties.Resources.records;
            this.button3.Location = new System.Drawing.Point(0, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 75);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.button2.Image = global::wasty.Properties.Resources.add_waste;
            this.button2.Location = new System.Drawing.Point(0, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 75);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.button1.Image = global::wasty.Properties.Resources.add_customers;
            this.button1.Location = new System.Drawing.Point(0, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 75);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.btnTransaksi.Image = global::wasty.Properties.Resources.add_transcation;
            this.btnTransaksi.Location = new System.Drawing.Point(0, 181);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(85, 75);
            this.btnTransaksi.TabIndex = 19;
            this.btnTransaksi.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Image = global::wasty.Properties.Resources.homepage;
            this.btnHome.Location = new System.Drawing.Point(0, 110);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(85, 75);
            this.btnHome.TabIndex = 15;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 678);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "AddTransaction";
            this.Text = "AddTransaction";
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTransaksi;
    }
}