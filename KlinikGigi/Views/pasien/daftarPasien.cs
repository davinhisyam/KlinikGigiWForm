using KlinikGigi.Controllers;
using System;
using System.Windows.Forms;

namespace KlinikGigi.Views.pasien
{
    public partial class daftarPasien : Form
    {
        private daftarPasienController controller;
        public daftarPasien()
        {
            InitializeComponent();
            setUpListView();
            controller = new daftarPasienController(this);
            controller.ShowData();
        }
        private void setUpListView()
        {
            lvwPasien.View = View.Details;
            //listViewJadwalDokter = new ListView(); //INI BUAT LIST BARU TONG. PANTES GA MAU MASOK. GG DAVIN.

            lvwPasien.Columns.Clear();
            lvwPasien.Columns.Add("id", 50);
            lvwPasien.Columns.Add("Nama", 150);
            lvwPasien.Columns.Add("NIK", 200);
            lvwPasien.Columns.Add("Alamat", 100);
            lvwPasien.Columns.Add("Umur", 50);
            lvwPasien.FullRowSelect = true;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambahPasien_Click(object sender, EventArgs e)
        {
             controller.OpenTambahPasien();   
        }

        private void btnHidePasien_Click(object sender, EventArgs e)
        {
            
            if (lvwPasien.SelectedItems.Count > 0)
            {
                // Ambil ID layanan atau data lain dari kolom yang dipilih
                int idPasien = int.Parse(lvwPasien.SelectedItems[0].SubItems[0].Text);
                controller.OpenHapusPasien(idPasien);

                // Buka form baru untuk konfirmasi atau penghapusan
                //HapusLayanan hapusLayananForm = new HapusLayanan(layananId);
                // hapusLayananForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pilih Pasien yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditPasien_Click(object sender, EventArgs e)
        {
            if (lvwPasien.SelectedItems.Count > 0)
            {
                int idPasien = int.Parse(lvwPasien.SelectedItems[0].SubItems[0].Text);
                string nama = lvwPasien.SelectedItems[0].SubItems[1].Text;
                long nik = long.Parse(lvwPasien.SelectedItems[0].SubItems[2].Text);
                string alamat = lvwPasien.SelectedItems[0].SubItems[3].Text;
                int umur = int.Parse(lvwPasien.SelectedItems[0].SubItems[4].Text);

                controller.OpenEditPasien(idPasien, nama, nik, alamat, umur);
            }
            else
            {
                MessageBox.Show("Pilih layanan yang ingin diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string cariNama = txtBoxSearch.Text;
            if (string.IsNullOrEmpty(cariNama))
            {
                controller.ShowData();
            }
            else
            {
                controller.showDataByName(cariNama);
            }
        }
    }
}
