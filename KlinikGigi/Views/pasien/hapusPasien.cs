using KlinikGigi.Controllers;
using KlinikGigi.Views.layanan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikGigi.Views.pasien
{
    public partial class hapusPasien : Form
    {
        private int idPasien;
        private daftarPasien parentView;
        
        public hapusPasien(daftarPasien parentView, int idPasien)
        {
            InitializeComponent();
            this.idPasien = idPasien;
            this.parentView = parentView;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                // Panggil controller untuk menghapus layanan berdasarkan ID
                daftarPasienController controller = new daftarPasienController(parentView); // Kamu bisa sesuaikan dengan controller yang ada
                controller.DeletePasien(idPasien);


                this.Close(); // Tutup form setelah penghapusan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
