using KlinikGigi.Controllers;
using KlinikGigi.Views.layanan;
using KlinikGigi.Views.pasien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikGigi.Views.antrean
{
    public partial class deleteAntrean : Form
    {
        private int idAntrean;
        private antrean view;

        
        public deleteAntrean(antrean view, int idAntrean)
        {
            InitializeComponent();
            this.idAntrean = idAntrean;
            this.view = view;
        }

        private void btnDeleteAntrean_Click(object sender, EventArgs e)
        {
            try
            {
                // Panggil controller untuk menghapus layanan berdasarkan ID
                antreanController controller = new antreanController(view); // Kamu bisa sesuaikan dengan controller yang ada
                controller.DeleteAntrean(idAntrean);


                this.Close(); // Tutup form setelah penghapusan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
