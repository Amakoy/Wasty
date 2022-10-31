
namespace wasty
{
    partial class AddCustomer
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
            System.Windows.Forms.Button btnTambah;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnAddWaste = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.tbJenis = new System.Windows.Forms.TextBox();
            this.tbHp = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            btnTambah = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.btnRecords);
            this.panel1.Controls.Add(this.btnAddWaste);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(-2, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 555);
            this.panel1.TabIndex = 1;
            // 
            // btnRecords
            // 
            this.btnRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.ForeColor = System.Drawing.Color.White;
            this.btnRecords.Image = global::wasty.Properties.Resources.records;
            this.btnRecords.Location = new System.Drawing.Point(3, 386);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(90, 70);
            this.btnRecords.TabIndex = 0;
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnAddWaste
            // 
            this.btnAddWaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddWaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWaste.ForeColor = System.Drawing.Color.White;
            this.btnAddWaste.Image = global::wasty.Properties.Resources.add_waste;
            this.btnAddWaste.Location = new System.Drawing.Point(3, 310);
            this.btnAddWaste.Name = "btnAddWaste";
            this.btnAddWaste.Size = new System.Drawing.Size(90, 70);
            this.btnAddWaste.TabIndex = 0;
            this.btnAddWaste.UseVisualStyleBackColor = true;
            this.btnAddWaste.Click += new System.EventHandler(this.btnAddWaste_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Image = global::wasty.Properties.Resources.add_customers;
            this.btnCustomers.Location = new System.Drawing.Point(3, 234);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(90, 70);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Image = global::wasty.Properties.Resources.add_transcation;
            this.btnTransaction.Location = new System.Drawing.Point(3, 158);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(90, 70);
            this.btnTransaction.TabIndex = 0;
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::wasty.Properties.Resources.homepage;
            this.btnHome.Location = new System.Drawing.Point(3, 82);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(90, 70);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJudul.Location = new System.Drawing.Point(342, 57);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(337, 50);
            this.lblJudul.TabIndex = 2;
            this.lblJudul.Text = "Tambah Customer";
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHp.Location = new System.Drawing.Point(145, 209);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(88, 20);
            this.lblHp.TabIndex = 13;
            this.lblHp.Text = "Nomor HP";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJenis.Location = new System.Drawing.Point(145, 273);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(115, 20);
            this.lblJenis.TabIndex = 12;
            this.lblJenis.Text = "Jenis Sampah";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNama.Location = new System.Drawing.Point(145, 149);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(121, 20);
            this.lblNama.TabIndex = 11;
            this.lblNama.Text = "Nama Lengkap";
            this.lblNama.Click += new System.EventHandler(this.lblNama_Click);
            // 
            // tbJenis
            // 
            this.tbJenis.Location = new System.Drawing.Point(145, 300);
            this.tbJenis.Margin = new System.Windows.Forms.Padding(2);
            this.tbJenis.Name = "tbJenis";
            this.tbJenis.Size = new System.Drawing.Size(281, 27);
            this.tbJenis.TabIndex = 18;
            // 
            // tbHp
            // 
            this.tbHp.Location = new System.Drawing.Point(145, 236);
            this.tbHp.Margin = new System.Windows.Forms.Padding(2);
            this.tbHp.Name = "tbHp";
            this.tbHp.Size = new System.Drawing.Size(281, 27);
            this.tbHp.TabIndex = 16;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(145, 175);
            this.tbNama.Margin = new System.Windows.Forms.Padding(2);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(281, 27);
            this.tbNama.TabIndex = 15;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTambah.ForeColor = System.Drawing.Color.White;
            btnTambah.Location = new System.Drawing.Point(199, 346);
            btnTambah.Margin = new System.Windows.Forms.Padding(2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new System.Drawing.Size(162, 33);
            btnTambah.TabIndex = 19;
            btnTambah.Text = "Tambah Customer";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(479, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(430, 336);
            this.dataGridView1.TabIndex = 20;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(962, 542);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(btnTambah);
            this.Controls.Add(this.tbJenis);
            this.Controls.Add(this.tbHp);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lblHp);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.panel1);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCustomer_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnAddWaste;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox tbJenis;
        private System.Windows.Forms.TextBox tbHp;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}