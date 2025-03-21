namespace CRUDSederhana
{
    partial class Form1
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
            this.NIM = new System.Windows.Forms.Label();
            this.NAMA = new System.Windows.Forms.Label();
            this.TELEPON = new System.Windows.Forms.Label();
            this.EMAIL = new System.Windows.Forms.Label();
            this.ALAMAT = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNAMA = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtTELEPON = new System.Windows.Forms.TextBox();
            this.txtALAMAT = new System.Windows.Forms.TextBox();
            this.Tambah = new System.Windows.Forms.Button();
            this.Hapus = new System.Windows.Forms.Button();
            this.Ubah = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(51, 37);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(38, 20);
            this.NIM.TabIndex = 0;
            this.NIM.Text = "NIM";
            // 
            // NAMA
            // 
            this.NAMA.AutoSize = true;
            this.NAMA.Location = new System.Drawing.Point(51, 93);
            this.NAMA.Name = "NAMA";
            this.NAMA.Size = new System.Drawing.Size(55, 20);
            this.NAMA.TabIndex = 1;
            this.NAMA.Text = "NAMA";
            // 
            // TELEPON
            // 
            this.TELEPON.AutoSize = true;
            this.TELEPON.Location = new System.Drawing.Point(51, 196);
            this.TELEPON.Name = "TELEPON";
            this.TELEPON.Size = new System.Drawing.Size(82, 20);
            this.TELEPON.TabIndex = 2;
            this.TELEPON.Text = "TELEPON";
            this.TELEPON.Click += new System.EventHandler(this.label1_Click);
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSize = true;
            this.EMAIL.Location = new System.Drawing.Point(51, 147);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(58, 20);
            this.EMAIL.TabIndex = 3;
            this.EMAIL.Text = "EMAIL";
            this.EMAIL.Click += new System.EventHandler(this.label2_Click);
            // 
            // ALAMAT
            // 
            this.ALAMAT.AutoSize = true;
            this.ALAMAT.Location = new System.Drawing.Point(51, 251);
            this.ALAMAT.Name = "ALAMAT";
            this.ALAMAT.Size = new System.Drawing.Size(73, 20);
            this.ALAMAT.TabIndex = 4;
            this.ALAMAT.Text = "ALAMAT";
            this.ALAMAT.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(242, 37);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(163, 26);
            this.txtNIM.TabIndex = 5;
            this.txtNIM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNAMA
            // 
            this.txtNAMA.Location = new System.Drawing.Point(242, 93);
            this.txtNAMA.Name = "txtNAMA";
            this.txtNAMA.Size = new System.Drawing.Size(163, 26);
            this.txtNAMA.TabIndex = 6;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(242, 147);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(163, 26);
            this.txtEMAIL.TabIndex = 8;
            this.txtEMAIL.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtTELEPON
            // 
            this.txtTELEPON.Location = new System.Drawing.Point(242, 193);
            this.txtTELEPON.Name = "txtTELEPON";
            this.txtTELEPON.Size = new System.Drawing.Size(163, 26);
            this.txtTELEPON.TabIndex = 9;
            this.txtTELEPON.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtALAMAT
            // 
            this.txtALAMAT.Location = new System.Drawing.Point(242, 245);
            this.txtALAMAT.Name = "txtALAMAT";
            this.txtALAMAT.Size = new System.Drawing.Size(163, 26);
            this.txtALAMAT.TabIndex = 10;
            // 
            // Tambah
            // 
            this.Tambah.Location = new System.Drawing.Point(474, 37);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(102, 35);
            this.Tambah.TabIndex = 11;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseVisualStyleBackColor = true;
            this.Tambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // Hapus
            // 
            this.Hapus.Location = new System.Drawing.Point(474, 96);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(102, 34);
            this.Hapus.TabIndex = 12;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = true;
            this.Hapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // Ubah
            // 
            this.Ubah.Location = new System.Drawing.Point(474, 147);
            this.Ubah.Name = "Ubah";
            this.Ubah.Size = new System.Drawing.Size(102, 37);
            this.Ubah.TabIndex = 13;
            this.Ubah.Text = "Ubah";
            this.Ubah.UseVisualStyleBackColor = true;
            this.Ubah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(474, 205);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(102, 34);
            this.Refresh.TabIndex = 14;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Location = new System.Drawing.Point(25, 300);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.RowHeadersWidth = 62;
            this.dgvMahasiswa.RowTemplate.Height = 28;
            this.dgvMahasiswa.Size = new System.Drawing.Size(596, 138);
            this.dgvMahasiswa.TabIndex = 15;
            this.dgvMahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMahasiswa);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Ubah);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.txtALAMAT);
            this.Controls.Add(this.txtTELEPON);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtNAMA);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.ALAMAT);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.TELEPON);
            this.Controls.Add(this.NAMA);
            this.Controls.Add(this.NIM);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.Label NAMA;
        private System.Windows.Forms.Label TELEPON;
        private System.Windows.Forms.Label EMAIL;
        private System.Windows.Forms.Label ALAMAT;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNAMA;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtTELEPON;
        private System.Windows.Forms.TextBox txtALAMAT;
        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.Button Ubah;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
    }
}

