using KlinikGigi.Controllers;
using System;
using System.Windows.Forms;

namespace KlinikGigi.Views.layanan
{
    public partial class tambahLayanan : Form
    {
        private layananController controller;
        private layanan view;

        public tambahLayanan(layanan view)
        {
            InitializeComponent();
            this.view = view;
            controller = new layananController(view); // Kamu bisa menambahkan reference view jika diperlukan
        }

        

        private void simpan_Click(object sender, EventArgs e)
        {
            // Ambil data dari textbox
            string namaLayanan = textBoxNama.Text;
            int harga;

            // Cek apakah harga valid
            if (int.TryParse(textBoxHarga.Text, out harga))
            {
                // Panggil method AddLayanan pada controller
                controller.AddLayanan(namaLayanan, harga);

                // Setelah menyimpan data, tutup form tambahLayanan
                this.Close();
            }
            else
            {
                MessageBox.Show("Harga tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
