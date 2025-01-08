using System;
using System.Windows.Forms;
using KlinikGigi.Controllers;

namespace KlinikGigi.Views.layanan
{
    public partial class layanan : Form
    {
        private layananController controller;
        public layanan()
        {
            InitializeComponent();
            controller = new layananController(this);
            this.Load += new System.EventHandler(this.layanan_Load);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add button functionality here, if needed.
        }

        private void SetupListView()
        {
            // Configure columns for the ListView
            lvwLayanan.Columns.Add("ID Layanan", 100);
            lvwLayanan.Columns.Add("Nama Layanan", 220);
            lvwLayanan.Columns.Add("Harga", 200);

            lvwLayanan.View = View.Details;
            lvwLayanan.FullRowSelect = true;
        }

        public void ShowDataInListView()
        {
            controller.ShowData();
        }

        private void layanan_Load(object sender, EventArgs e)
        {
            // Setup ListView and load data when the form loads
            SetupListView();
            ShowDataInListView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            controller.OpenTambahLayanan();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwLayanan.SelectedItems.Count > 0)
            {
                // Ambil ID layanan atau data lain dari kolom yang dipilih
                int idLayanan = int.Parse(lvwLayanan.SelectedItems[0].SubItems[0].Text);
                controller.OpenDeleteLayanan(idLayanan);

                // Buka form baru untuk konfirmasi atau penghapusan
                //HapusLayanan hapusLayananForm = new HapusLayanan(layananId);
               // hapusLayananForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pilih layanan yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(lvwLayanan.SelectedItems.Count > 0)
            {
                int idLayanan = int.Parse(lvwLayanan.SelectedItems[0].SubItems[0].Text);
                string namaLayanan = lvwLayanan.SelectedItems[0].SubItems[1].Text;
                int harga = int.Parse(lvwLayanan.SelectedItems[0].SubItems[2].Text, System.Globalization.NumberStyles.Currency);


                controller.OpenUpdateLayanan(idLayanan, namaLayanan, harga);
            }
            else
            {
                MessageBox.Show("Pilih layanan yang ingin diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}