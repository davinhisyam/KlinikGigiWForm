namespace KlinikGigi.Views.layanan
{
    partial class tambahLayanan
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
            this.labelJudul = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.simpan = new System.Windows.Forms.Button();
            this.batal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelJudul.AutoSize = true;
            this.labelJudul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelJudul.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(84, 27);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(184, 28);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "Tambah Layanan";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNama.Location = new System.Drawing.Point(38, 106);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(264, 22);
            this.textBoxNama.TabIndex = 1;
            // 
            // labelNama
            // 
            this.labelNama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(38, 78);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(55, 21);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "Nama";
            // 
            // labelHarga
            // 
            this.labelHarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(38, 135);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(56, 21);
            this.labelHarga.TabIndex = 3;
            this.labelHarga.Text = "Harga";
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxHarga.Location = new System.Drawing.Point(38, 163);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(263, 22);
            this.textBoxHarga.TabIndex = 4;
            // 
            // simpan
            // 
            this.simpan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpan.Location = new System.Drawing.Point(183, 207);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(119, 36);
            this.simpan.TabIndex = 5;
            this.simpan.Text = "Simpan";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // batal
            // 
            this.batal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batal.Location = new System.Drawing.Point(39, 207);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(119, 36);
            this.batal.TabIndex = 6;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = true;
            this.batal.Click += new System.EventHandler(this.batal_Click);
            // 
            // tambahLayanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 281);
            this.Controls.Add(this.batal);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.labelJudul);
            this.MinimumSize = new System.Drawing.Size(371, 328);
            this.Name = "tambahLayanan";
            this.Text = "tambahLayanan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Button batal;
    }
}