namespace KlinikGigi.Views.antrean
{
    partial class antrean
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwDaftarAntrean = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelAntrean = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Antrean";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwDaftarAntrean);
            this.groupBox1.Location = new System.Drawing.Point(5, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 351);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "-";
            // 
            // lvwDaftarAntrean
            // 
            this.lvwDaftarAntrean.HideSelection = false;
            this.lvwDaftarAntrean.Location = new System.Drawing.Point(7, 21);
            this.lvwDaftarAntrean.Name = "lvwDaftarAntrean";
            this.lvwDaftarAntrean.Size = new System.Drawing.Size(700, 324);
            this.lvwDaftarAntrean.TabIndex = 0;
            this.lvwDaftarAntrean.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelAntrean
            // 
            this.btnDelAntrean.Location = new System.Drawing.Point(12, 451);
            this.btnDelAntrean.Name = "btnDelAntrean";
            this.btnDelAntrean.Size = new System.Drawing.Size(90, 37);
            this.btnDelAntrean.TabIndex = 6;
            this.btnDelAntrean.Text = "Delete";
            this.btnDelAntrean.UseVisualStyleBackColor = true;
            this.btnDelAntrean.Click += new System.EventHandler(this.btnDelAntrean_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(622, 451);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(90, 37);
            this.btnTambah.TabIndex = 8;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // antrean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 494);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnDelAntrean);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "antrean";
            this.Text = "antrean";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListView lvwDaftarAntrean;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelAntrean;
        private System.Windows.Forms.Button btnTambah;
    }
}