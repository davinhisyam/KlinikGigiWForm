using KlinikGigi.Controllers;
using System;
using System.Windows.Forms;

namespace KlinikGigi.Views.antrean
{
    public partial class selectPasien : Form
    {
        private selectPasienController controller;
        private tambahAntrean tambahAntrean;
        public selectPasien(tambahAntrean tambahAntrean)
        {
            InitializeComponent();
            setUpListView();
            controller = new selectPasienController(this);
            this.tambahAntrean = tambahAntrean;
            controller.ShowData();
        }
        private void setUpListView()
        {
            lvwPasien.View = View.Details;
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

        private void btnPilih_Click(object sender, EventArgs e)
        {
            if (lvwPasien.SelectedItems.Count > 0)
            {
                int idPasien = int.Parse(lvwPasien.SelectedItems[0].SubItems[0].Text);
                string namaPasien = lvwPasien.SelectedItems[0].SubItems[1].Text;
                tambahAntrean.showPasien(idPasien, namaPasien);
                this.Close();
            }
            else
            {
                MessageBox.Show("Pilih layanan yang ingin dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
