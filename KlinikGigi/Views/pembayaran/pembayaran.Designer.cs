namespace KlinikGigi
{
    partial class pembayaran
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLunas = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.listViewAntrean = new System.Windows.Forms.ListView();
            this.listViewTindakan = new System.Windows.Forms.ListView();
            this.btnPilihTindakan = new System.Windows.Forms.Button();
            this.rtbTotal = new System.Windows.Forms.RichTextBox();
            this.cmbJenisBayar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pembayaran";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "jenis Pembayaran";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total";
            // 
            // btnLunas
            // 
            this.btnLunas.Location = new System.Drawing.Point(403, 464);
            this.btnLunas.Name = "btnLunas";
            this.btnLunas.Size = new System.Drawing.Size(161, 27);
            this.btnLunas.TabIndex = 17;
            this.btnLunas.Text = "Lunas";
            this.btnLunas.UseVisualStyleBackColor = true;
            this.btnLunas.Click += new System.EventHandler(this.btnLunas_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(50, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listViewAntrean
            // 
            this.listViewAntrean.HideSelection = false;
            this.listViewAntrean.Location = new System.Drawing.Point(50, 58);
            this.listViewAntrean.Name = "listViewAntrean";
            this.listViewAntrean.Size = new System.Drawing.Size(862, 160);
            this.listViewAntrean.TabIndex = 19;
            this.listViewAntrean.UseCompatibleStateImageBehavior = false;
            // 
            // listViewTindakan
            // 
            this.listViewTindakan.FullRowSelect = true;
            this.listViewTindakan.HideSelection = false;
            this.listViewTindakan.Location = new System.Drawing.Point(50, 224);
            this.listViewTindakan.Name = "listViewTindakan";
            this.listViewTindakan.Size = new System.Drawing.Size(739, 128);
            this.listViewTindakan.TabIndex = 22;
            this.listViewTindakan.UseCompatibleStateImageBehavior = false;
            // 
            // btnPilihTindakan
            // 
            this.btnPilihTindakan.Location = new System.Drawing.Point(807, 224);
            this.btnPilihTindakan.Name = "btnPilihTindakan";
            this.btnPilihTindakan.Size = new System.Drawing.Size(105, 128);
            this.btnPilihTindakan.TabIndex = 23;
            this.btnPilihTindakan.Text = "Pilih \r\nTindakan";
            this.btnPilihTindakan.UseVisualStyleBackColor = true;
            this.btnPilihTindakan.Click += new System.EventHandler(this.btnPilihTindakan_Click);
            // 
            // rtbTotal
            // 
            this.rtbTotal.Location = new System.Drawing.Point(372, 374);
            this.rtbTotal.Name = "rtbTotal";
            this.rtbTotal.Size = new System.Drawing.Size(223, 32);
            this.rtbTotal.TabIndex = 24;
            this.rtbTotal.Text = "";
            // 
            // cmbJenisBayar
            // 
            this.cmbJenisBayar.FormattingEnabled = true;
            this.cmbJenisBayar.Items.AddRange(new object[] {
            "Transfer",
            "Cash"});
            this.cmbJenisBayar.Location = new System.Drawing.Point(356, 434);
            this.cmbJenisBayar.Name = "cmbJenisBayar";
            this.cmbJenisBayar.Size = new System.Drawing.Size(254, 24);
            this.cmbJenisBayar.TabIndex = 25;
            // 
            // pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 499);
            this.Controls.Add(this.cmbJenisBayar);
            this.Controls.Add(this.rtbTotal);
            this.Controls.Add(this.btnPilihTindakan);
            this.Controls.Add(this.listViewTindakan);
            this.Controls.Add(this.listViewAntrean);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLunas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "pembayaran";
            this.Text = "pembayaran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLunas;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.ListView listViewAntrean;
        private System.Windows.Forms.ListView listViewTindakan;
        private System.Windows.Forms.Button btnPilihTindakan;
        private System.Windows.Forms.RichTextBox rtbTotal;
        private System.Windows.Forms.ComboBox cmbJenisBayar;
    }
}