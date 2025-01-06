namespace KlinikGigi
{
    partial class home
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewJenisTindakan = new System.Windows.Forms.ListView();
            this.btnAntrean = new System.Windows.Forms.Button();
            this.btnPembayaran = new System.Windows.Forms.Button();
            this.btnRekamMedis = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnJenisTindakan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewJadwalDokter = new System.Windows.Forms.ListView();
            this.btnDaftarPasien = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewJenisTindakan);
            this.groupBox1.Location = new System.Drawing.Point(325, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jenis Tindakan";
            // 
            // listViewJenisTindakan
            // 
            this.listViewJenisTindakan.HideSelection = false;
            this.listViewJenisTindakan.Location = new System.Drawing.Point(6, 21);
            this.listViewJenisTindakan.Name = "listViewJenisTindakan";
            this.listViewJenisTindakan.Size = new System.Drawing.Size(441, 165);
            this.listViewJenisTindakan.TabIndex = 0;
            this.listViewJenisTindakan.UseCompatibleStateImageBehavior = false;
            // 
            // btnAntrean
            // 
            this.btnAntrean.Location = new System.Drawing.Point(54, 178);
            this.btnAntrean.Name = "btnAntrean";
            this.btnAntrean.Size = new System.Drawing.Size(192, 42);
            this.btnAntrean.TabIndex = 8;
            this.btnAntrean.Text = "Antrean";
            this.btnAntrean.UseVisualStyleBackColor = true;
            this.btnAntrean.Click += new System.EventHandler(this.btnAntrean_Click);
            // 
            // btnPembayaran
            // 
            this.btnPembayaran.Location = new System.Drawing.Point(54, 243);
            this.btnPembayaran.Name = "btnPembayaran";
            this.btnPembayaran.Size = new System.Drawing.Size(192, 42);
            this.btnPembayaran.TabIndex = 9;
            this.btnPembayaran.Text = "Pembayaran";
            this.btnPembayaran.UseVisualStyleBackColor = true;
            this.btnPembayaran.Click += new System.EventHandler(this.btnPembayaran_Click);
            // 
            // btnRekamMedis
            // 
            this.btnRekamMedis.Location = new System.Drawing.Point(54, 314);
            this.btnRekamMedis.Name = "btnRekamMedis";
            this.btnRekamMedis.Size = new System.Drawing.Size(192, 42);
            this.btnRekamMedis.TabIndex = 11;
            this.btnRekamMedis.Text = "Rekam Medis";
            this.btnRekamMedis.UseVisualStyleBackColor = true;
            this.btnRekamMedis.Click += new System.EventHandler(this.btnRekamMedis_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.Location = new System.Drawing.Point(54, 387);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(192, 42);
            this.btnRiwayat.TabIndex = 12;
            this.btnRiwayat.Text = "RIwayat";
            this.btnRiwayat.UseVisualStyleBackColor = true;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(331, 54);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(210, 27);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dokter yang Sedang Berjaga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Waktu/Tanggal";
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(580, 54);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(192, 27);
            this.listView3.TabIndex = 16;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnJenisTindakan
            // 
            this.btnJenisTindakan.Location = new System.Drawing.Point(54, 42);
            this.btnJenisTindakan.Name = "btnJenisTindakan";
            this.btnJenisTindakan.Size = new System.Drawing.Size(192, 43);
            this.btnJenisTindakan.TabIndex = 18;
            this.btnJenisTindakan.Text = "Jenis Tindakan";
            this.btnJenisTindakan.UseVisualStyleBackColor = true;
            this.btnJenisTindakan.Click += new System.EventHandler(this.btnJenisTindakan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewJadwalDokter);
            this.groupBox2.Location = new System.Drawing.Point(325, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 136);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jadwal Dokter";
            // 
            // listViewJadwalDokter
            // 
            this.listViewJadwalDokter.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewJadwalDokter.HideSelection = false;
            this.listViewJadwalDokter.Location = new System.Drawing.Point(9, 18);
            this.listViewJadwalDokter.Name = "listViewJadwalDokter";
            this.listViewJadwalDokter.Size = new System.Drawing.Size(434, 115);
            this.listViewJadwalDokter.TabIndex = 0;
            this.listViewJadwalDokter.UseCompatibleStateImageBehavior = false;
            // 
            // btnDaftarPasien
            // 
            this.btnDaftarPasien.Location = new System.Drawing.Point(54, 110);
            this.btnDaftarPasien.Name = "btnDaftarPasien";
            this.btnDaftarPasien.Size = new System.Drawing.Size(192, 42);
            this.btnDaftarPasien.TabIndex = 20;
            this.btnDaftarPasien.Text = "Daftar Pasien";
            this.btnDaftarPasien.UseVisualStyleBackColor = true;
            this.btnDaftarPasien.Click += new System.EventHandler(this.btnDaftarPasien_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 496);
            this.Controls.Add(this.btnDaftarPasien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnJenisTindakan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnRiwayat);
            this.Controls.Add(this.btnRekamMedis);
            this.Controls.Add(this.btnPembayaran);
            this.Controls.Add(this.btnAntrean);
            this.Controls.Add(this.groupBox1);
            this.Name = "home";
            this.Text = "home";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListView listViewJenisTindakan;
        private System.Windows.Forms.Button btnAntrean;
        private System.Windows.Forms.Button btnPembayaran;
        private System.Windows.Forms.Button btnRekamMedis;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnJenisTindakan;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListView listViewJadwalDokter;
        private System.Windows.Forms.Button btnDaftarPasien;
    }
}