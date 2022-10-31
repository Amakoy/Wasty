
namespace wasty
{
    partial class HomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnAddWaste = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.btnRecords);
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.btnAddWaste);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Location = new System.Drawing.Point(-3, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 555);
            this.panel1.TabIndex = 0;
            // 
            // btnRecords
            // 
            this.btnRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.ForeColor = System.Drawing.Color.White;
            this.btnRecords.Image = global::wasty.Properties.Resources.records;
            this.btnRecords.Location = new System.Drawing.Point(4, 396);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(89, 70);
            this.btnRecords.TabIndex = 3;
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Image = global::wasty.Properties.Resources.add_transcation;
            this.btnTransaction.Location = new System.Drawing.Point(4, 168);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(89, 70);
            this.btnTransaction.TabIndex = 6;
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click_1);
            // 
            // btnAddWaste
            // 
            this.btnAddWaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddWaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWaste.ForeColor = System.Drawing.Color.White;
            this.btnAddWaste.Image = global::wasty.Properties.Resources.add_waste;
            this.btnAddWaste.Location = new System.Drawing.Point(4, 320);
            this.btnAddWaste.Name = "btnAddWaste";
            this.btnAddWaste.Size = new System.Drawing.Size(89, 70);
            this.btnAddWaste.TabIndex = 4;
            this.btnAddWaste.UseVisualStyleBackColor = true;
            this.btnAddWaste.Click += new System.EventHandler(this.btnAddWaste_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::wasty.Properties.Resources.homepage;
            this.btnHome.Location = new System.Drawing.Point(4, 92);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(89, 70);
            this.btnHome.TabIndex = 7;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Image = global::wasty.Properties.Resources.add_customers;
            this.btnCustomers.Location = new System.Drawing.Point(4, 244);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(89, 70);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(346, 75);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(332, 67);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Wasty Bestie";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(608, 300);
            this.dataGridView1.TabIndex = 2;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(962, 542);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnAddWaste;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCustomers;
    }
}