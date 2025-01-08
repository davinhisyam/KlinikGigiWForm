using KlinikGigi.Controllers;
using System;
using System.Windows.Forms;

namespace KlinikGigi.Views.antrean
{
    public partial class antrean : Form
    {
        private antreanController controller;
        public antrean()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.antrean_Load);
            this.controller = new antreanController(this);
        }
        
        
        private void SetupListView()
        {
            // Configure columns for the ListView
            lvwDaftarAntrean.Columns.Add("No Antrian", 100);
            lvwDaftarAntrean.Columns.Add("Nama Pasien", 200);
            lvwDaftarAntrean.Columns.Add("Nama Dokter", 100);
            lvwDaftarAntrean.Columns.Add("Tanggal", 100);
            lvwDaftarAntrean.Columns.Add("Status", 100);

            lvwDaftarAntrean.View = View.Details;
            lvwDaftarAntrean.FullRowSelect = true;
        }

        public void ShowDataInListView()
        {
            controller.ShowData();
        }

        private void antrean_Load(object sender, EventArgs e)
        {
            ShowDataInListView();
            SetupListView();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            controller.OpenTambahAntrean();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelAntrean_Click(object sender, EventArgs e)
        {
            if (lvwDaftarAntrean.SelectedItems.Count > 0)
            {
                // Ambil ID layanan atau data lain dari kolom yang dipilih
                int idAntrean = int.Parse(lvwDaftarAntrean.SelectedItems[0].SubItems[0].Text);
                controller.OpenDeleteAntrean(idAntrean);

                // Buka form baru untuk konfirmasi atau penghapusan
                //HapusLayanan hapusLayananForm = new HapusLayanan(layananId);
                // hapusLayananForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pilih layanan yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
