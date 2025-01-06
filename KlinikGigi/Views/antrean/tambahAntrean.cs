using KlinikGigi.Controllers;
using KlinikGigi.Views.antrean;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KlinikGigi.Views.antrean
{
    public partial class tambahAntrean : Form
    {
        private antreanController controller;
        public tambahAntrean(antrean view)
        {
            InitializeComponent();
            this.controller = new antreanController(view);
        }
        
        private void richTextBox1_Click(object sender, EventArgs e)
        {
            controller.OpenSelectPasien(this);
        }

        public void showPasien(int id, string namaPasien)
        {
            richTextBox1.Text = id.ToString();
            richTextBox1.BackColor = Color.FromArgb(255, 0, 255, 0); // Warna hijau terang penuh (tanpa transparansi)
            richTextBox1.Refresh();
            CenterText(richTextBox1);
        }

        public void showDokter(int id, string namaDokter)
        {
            richTextBoxDokter.Text = id.ToString();
            richTextBoxDokter.BackColor = Color.FromArgb(255, 0, 255, 0); // Warna hijau terang penuh (tanpa transparansi)
            richTextBoxDokter.Refresh();
            CenterText(richTextBoxDokter);
        }

        private void CenterText(RichTextBox rtb)
        {
            rtb.SelectAll(); // Pilih semua teks
            rtb.SelectionAlignment = HorizontalAlignment.Center; // Atur perataan ke tengah
            rtb.DeselectAll(); // Hilangkan seleksi
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // INi dion ganti
            // Validasi dan parsing input untuk idPasien
            if (!int.TryParse(richTextBox1.Text.Trim(), out int idPasien))
            {
                MessageBox.Show("ID Pasien tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi dan parsing input untuk idDokter
            if (!int.TryParse(richTextBoxDokter.Text.Trim(), out int idDokter))
            {
                MessageBox.Show("ID Dokter tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Panggil method AddDataAntrean pada controller
            try
            {
                controller.AddDataAntrean(idPasien, idDokter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Setelah menyimpan data, tutup form
            this.Close();
        }

        private void richTextBoxDokter_DoubleClick(object sender, EventArgs e)
        {
            controller.OpenSelectDokter(this);
        }

    }
}
