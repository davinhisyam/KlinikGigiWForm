namespace KlinikGigi.Views.pasien
{
    partial class daftarPasien
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
            this.lvwPasien = new System.Windows.Forms.ListView();
            this.btnHidePasien = new System.Windows.Forms.Button();
            this.btnEditPasien = new System.Windows.Forms.Button();
            this.btnTambahPasien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwPasien
            // 
            this.lvwPasien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvwPasien.HideSelection = false;
            this.lvwPasien.Location = new System.Drawing.Point(33, 93);
            this.lvwPasien.Name = "lvwPasien";
            this.lvwPasien.Size = new System.Drawing.Size(732, 358);
            this.lvwPasien.TabIndex = 0;
            this.lvwPasien.UseCompatibleStateImageBehavior = false;
            // 
            // btnHidePasien
            // 
            this.btnHidePasien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHidePasien.Location = new System.Drawing.Point(34, 474);
            this.btnHidePasien.Name = "btnHidePasien";
            this.btnHidePasien.Size = new System.Drawing.Size(103, 34);
            this.btnHidePasien.TabIndex = 1;
            this.btnHidePasien.Text = "Hapus";
            this.btnHidePasien.UseVisualStyleBackColor = true;
            this.btnHidePasien.Click += new System.EventHandler(this.btnHidePasien_Click);
            // 
            // btnEditPasien
            // 
            this.btnEditPasien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditPasien.Location = new System.Drawing.Point(348, 474);
            this.btnEditPasien.Name = "btnEditPasien";
            this.btnEditPasien.Size = new System.Drawing.Size(103, 34);
            this.btnEditPasien.TabIndex = 2;
            this.btnEditPasien.Text = "Edit";
            this.btnEditPasien.UseVisualStyleBackColor = true;
            this.btnEditPasien.Click += new System.EventHandler(this.btnEditPasien_Click);
            // 
            // btnTambahPasien
            // 
            this.btnTambahPasien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTambahPasien.Location = new System.Drawing.Point(662, 474);
            this.btnTambahPasien.Name = "btnTambahPasien";
            this.btnTambahPasien.Size = new System.Drawing.Size(103, 34);
            this.btnTambahPasien.TabIndex = 3;
            this.btnTambahPasien.Text = "Tambah";
            this.btnTambahPasien.UseVisualStyleBackColor = true;
            this.btnTambahPasien.Click += new System.EventHandler(this.btnTambahPasien_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Daftar Pasien";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Location = new System.Drawing.Point(35, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 27);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxSearch.Location = new System.Drawing.Point(154, 62);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(611, 22);
            this.txtBoxSearch.TabIndex = 6;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            this.txtBoxSearch.Enter += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cari Nama Pasien";
            // 
            // daftarPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTambahPasien);
            this.Controls.Add(this.btnEditPasien);
            this.Controls.Add(this.btnHidePasien);
            this.Controls.Add(this.lvwPasien);
            this.MinimumSize = new System.Drawing.Size(818, 566);
            this.Name = "daftarPasien";
            this.Text = "daftarPasien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lvwPasien;
        private System.Windows.Forms.Button btnHidePasien;
        private System.Windows.Forms.Button btnEditPasien;
        private System.Windows.Forms.Button btnTambahPasien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label label2;
    }
}