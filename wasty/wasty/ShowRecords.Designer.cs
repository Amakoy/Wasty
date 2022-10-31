
namespace wasty
{
    partial class ShowRecords
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnAddWaste = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.lblAddSampah = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.sidePanel.Controls.Add(this.btnRecords);
            this.sidePanel.Controls.Add(this.btnAddWaste);
            this.sidePanel.Controls.Add(this.btnCustomers);
            this.sidePanel.Controls.Add(this.btnTransaksi);
            this.sidePanel.Controls.Add(this.btnHome);
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(68, 542);
            this.sidePanel.TabIndex = 3;
            // 
            // btnRecords
            // 
            this.btnRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.btnRecords.Image = global::wasty.Properties.Resources.records;
            this.btnRecords.Location = new System.Drawing.Point(0, 315);
            this.btnRecords.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(68, 60);
            this.btnRecords.TabIndex = 14;
            this.btnRecords.UseVisualStyleBackColor = false;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnAddWaste
            // 
            this.btnAddWaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.btnAddWaste.Image = global::wasty.Properties.Resources.add_waste;
            this.btnAddWaste.Location = new System.Drawing.Point(0, 258);
            this.btnAddWaste.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddWaste.Name = "btnAddWaste";
            this.btnAddWaste.Size = new System.Drawing.Size(68, 60);
            this.btnAddWaste.TabIndex = 14;
            this.btnAddWaste.UseVisualStyleBackColor = false;
            this.btnAddWaste.Click += new System.EventHandler(this.btnAddWaste_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.btnCustomers.Image = global::wasty.Properties.Resources.add_customers;
            this.btnCustomers.Location = new System.Drawing.Point(0, 202);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(68, 60);
            this.btnCustomers.TabIndex = 14;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.btnTransaksi.Image = global::wasty.Properties.Resources.add_transcation;
            this.btnTransaksi.Location = new System.Drawing.Point(0, 145);
            this.btnTransaksi.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(68, 60);
            this.btnTransaksi.TabIndex = 14;
            this.btnTransaksi.UseVisualStyleBackColor = false;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
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
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
            this.mainPanel.Controls.Add(this.dgvRecords);
            this.mainPanel.Controls.Add(this.lblAddSampah);
            this.mainPanel.Location = new System.Drawing.Point(68, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(894, 542);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // dgvRecords
            // 
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Location = new System.Drawing.Point(42, 88);
            this.dgvRecords.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.RowHeadersWidth = 62;
            this.dgvRecords.RowTemplate.Height = 33;
            this.dgvRecords.Size = new System.Drawing.Size(813, 412);
            this.dgvRecords.TabIndex = 13;
            // 
            // lblAddSampah
            // 
            this.lblAddSampah.AutoSize = true;
            this.lblAddSampah.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddSampah.Location = new System.Drawing.Point(298, 38);
            this.lblAddSampah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddSampah.Name = "lblAddSampah";
            this.lblAddSampah.Size = new System.Drawing.Size(314, 50);
            this.lblAddSampah.TabIndex = 12;
            this.lblAddSampah.Text = "Record Transaksi";
            // 
            // ShowRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 542);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowRecords";
            this.Text = "ShowRecords";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowRecords_FormClosed);
            this.sidePanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblAddSampah;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnAddWaste;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button btnHome;
    }
}