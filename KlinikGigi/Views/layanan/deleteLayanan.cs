using KlinikGigi.Controllers;
using System;
using System.Windows.Forms;

namespace KlinikGigi.Views.layanan
{
    public partial class deleteLayanan : Form
    {
        private int idLayanan;
        private layanan parentView;
        public deleteLayanan(layanan parentView, int idLayanan)
        {
            InitializeComponent();
            this.idLayanan = idLayanan;
            this.parentView = parentView;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                // Panggil controller untuk menghapus layanan berdasarkan ID
                layananController controller = new layananController(parentView); // Kamu bisa sesuaikan dengan controller yang ada
                controller.DeleteLayanan(idLayanan);


                this.Close(); // Tutup form setelah penghapusan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
