using KlinikGigi.Controllers;
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
    public partial class EditPasien : Form
    {
        private daftarPasienController controller;
        private int idPasien;
        
        public EditPasien(daftarPasien view, int idPasien, string nama, long nik, string alamat, int umur)
        {
            InitializeComponent();
            this.idPasien = idPasien;
            controller = new daftarPasienController(view); //tandain

            txtNama.Text = nama;
            txtNik.Text = nik.ToString();
            txtAlamat.Text = alamat;
            txtUmur.Text = umur.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            long nik = long.Parse(txtNik.Text);
            string alamat = txtAlamat.Text;
            int umur;

            // Cek apakah harga valid
            if (int.TryParse(txtUmur.Text, out umur))
            {
                // Panggil method AddLayanan pada controller
                controller.UpdateDaftarPasien(idPasien, nama, nik, alamat, umur);

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
