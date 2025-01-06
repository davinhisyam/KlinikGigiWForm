namespace KlinikGigi.Views.antrean
{
    partial class selectDokter
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
            this.lvwDokter = new System.Windows.Forms.ListView();
            this.btnTambahPasien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwDokter
            // 
            this.lvwDokter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvwDokter.HideSelection = false;
            this.lvwDokter.Location = new System.Drawing.Point(33, 79);
            this.lvwDokter.Name = "lvwDokter";
            this.lvwDokter.Size = new System.Drawing.Size(732, 372);
            this.lvwDokter.TabIndex = 0;
            this.lvwDokter.UseCompatibleStateImageBehavior = false;
            // 
            // btnTambahPasien
            // 
            this.btnTambahPasien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTambahPasien.BackColor = System.Drawing.Color.LightGreen;
            this.btnTambahPasien.Location = new System.Drawing.Point(540, 467);
            this.btnTambahPasien.Name = "btnTambahPasien";
            this.btnTambahPasien.Size = new System.Drawing.Size(225, 40);
            this.btnTambahPasien.TabIndex = 3;
            this.btnTambahPasien.Text = "Pilih";
            this.btnTambahPasien.UseVisualStyleBackColor = false;
            this.btnTambahPasien.Click += new System.EventHandler(this.btnPilih_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pilih Dokter";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Location = new System.Drawing.Point(35, 467);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(225, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // selectDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTambahPasien);
            this.Controls.Add(this.lvwDokter);
            this.MinimumSize = new System.Drawing.Size(818, 566);
            this.Name = "selectDokter";
            this.Text = "daftarPasien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lvwDokter;
        private System.Windows.Forms.Button btnTambahPasien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}