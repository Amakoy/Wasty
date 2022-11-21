namespace wasty
{
    partial class PgPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PgPassword));
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbPgPassword = new System.Windows.Forms.TextBox();
            this.btnLanjut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(-1, -29);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(527, 332);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(76, 89);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(383, 20);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Mohon isi password akun \'postgre\' pgAdmin anda:";
            // 
            // tbPgPassword
            // 
            this.tbPgPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPgPassword.Location = new System.Drawing.Point(125, 124);
            this.tbPgPassword.Name = "tbPgPassword";
            this.tbPgPassword.Size = new System.Drawing.Size(274, 27);
            this.tbPgPassword.TabIndex = 11;
            this.tbPgPassword.UseSystemPasswordChar = true;
            // 
            // btnLanjut
            // 
            this.btnLanjut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.btnLanjut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLanjut.Location = new System.Drawing.Point(195, 163);
            this.btnLanjut.Name = "btnLanjut";
            this.btnLanjut.Size = new System.Drawing.Size(125, 39);
            this.btnLanjut.TabIndex = 12;
            this.btnLanjut.Text = "Lanjut";
            this.btnLanjut.UseVisualStyleBackColor = false;
            this.btnLanjut.Click += new System.EventHandler(this.btnLanjut_Click);
            // 
            // PgPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 292);
            this.Controls.Add(this.btnLanjut);
            this.Controls.Add(this.tbPgPassword);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pictureBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PgPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PgPassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PgPassword_FormClosed);
            this.Load += new System.EventHandler(this.PgPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbPgPassword;
        private System.Windows.Forms.Button btnLanjut;
    }
}