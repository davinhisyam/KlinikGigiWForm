namespace KlinikGigi.Views.antrean
{
    partial class deleteAntrean
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteAntrean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Location = new System.Drawing.Point(65, 103);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 45);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Batal";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteAntrean
            // 
            this.btnDeleteAntrean.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteAntrean.Location = new System.Drawing.Point(271, 103);
            this.btnDeleteAntrean.Name = "btnDeleteAntrean";
            this.btnDeleteAntrean.Size = new System.Drawing.Size(135, 45);
            this.btnDeleteAntrean.TabIndex = 1;
            this.btnDeleteAntrean.Text = "Hapus";
            this.btnDeleteAntrean.UseVisualStyleBackColor = true;
            this.btnDeleteAntrean.Click += new System.EventHandler(this.btnDeleteAntrean_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yakin Hapus Antrean?";
            // 
            // deleteAntrean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 198);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteAntrean);
            this.Controls.Add(this.btnBack);
            this.MinimumSize = new System.Drawing.Size(495, 245);
            this.Name = "deleteAntrean";
            this.Text = "deleteAntrean";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteAntrean;
        private System.Windows.Forms.Label label1;
    }
}