using KlinikGigi.Controllers;
using KlinikGigi.Views;
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

namespace KlinikGigi.Views.pasien
{
    public partial class tambahPasien : Form
    {
        private daftarPasienController controller;
        private daftarPasien view;

        public tambahPasien(daftarPasien view)
        {
            InitializeComponent();
            //this.Load += new System.EventHandler(this.tambahPasien_Load);
            this.view = view;
            controller = new daftarPasienController(view); // Kamu bisa menambahkan reference view jika diperlukan
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void tambahPasien_Load(object sender, EventArgs e)
        {
            // Setup ListView and load data when the form loads
            // SetupListView();
            // ShowDataInListView();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            long nik = long.Parse(txtNik.Text); 
            string alamat = txtAlamat.Text;  
            int umur;

            // Cek apakah harga valid
            if (int.TryParse(txtUmur.Text, out umur))
            {
                // Panggil method AddLayanan pada controller
                controller.AddPasien(nama, nik, alamat, umur);

                // Setelah menyimpan data, tutup form tambahLayanan
                this.Close();
            }
            else
            {
                MessageBox.Show("Harga tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
