using KlinikGigi.Controllers;
using System;
using System.Windows.Forms;

namespace KlinikGigi.Views.antrean
{
    public partial class selectDokter : Form
    {
        private selectDokterController controller;
        private tambahAntrean tambahAntrean;
        public selectDokter(tambahAntrean tambahAntrean)
        {
            InitializeComponent();
            setUpListView();
            controller = new selectDokterController(this);
            this.tambahAntrean = tambahAntrean;
            controller.ShowData();
        }
        private void setUpListView()
        {
            lvwDokter.View = View.Details;
            lvwDokter.Columns.Clear();
            lvwDokter.Columns.Add("Dokter", 100);
            lvwDokter.Columns.Add("Hari", 150);
            lvwDokter.Columns.Add("Jam Praktek", 200);
            lvwDokter.Columns.Add("Jam Selesai", 100);
            lvwDokter.FullRowSelect = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            if (lvwDokter.SelectedItems.Count > 0)
            {
                int id = int.Parse(lvwDokter.SelectedItems[0].SubItems[0].Text);
                string namaDokter = lvwDokter.SelectedItems[0].SubItems[1].Text;
                tambahAntrean.showDokter(id, namaDokter);
                this.Close();
            }
            else
            {
                MessageBox.Show("Pilih layanan yang ingin dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*private void txtBoxSearch_TextChanged(object sender, EventArgs e)
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
        }*/
    }
}
