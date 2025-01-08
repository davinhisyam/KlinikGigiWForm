using KlinikGigi.Models.pasien;
using KlinikGigi.Views.antrean;
using System;
using System.Data;
using System.Windows.Forms;

namespace KlinikGigi.Controllers
{
    public class selectPasienController
    {
        private daftarPasienModel model;
        private selectPasien view;

        public selectPasienController(selectPasien view)
        {
            this.model = new daftarPasienModel(); // Instantiate the model
            this.view = view; // Reference to the view (form)
        }

        public void ShowData()
        {
            try
            {
                // Get data from the model
                DataTable data = model.GetDaftarPasien();

                // Clear the ListView before adding new data

                view.lvwPasien.Items.Clear(); 

                // Populate the ListView with data
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem(row["pasien_id"].ToString());
                    item.SubItems.Add(row["nama"].ToString());
                    item.SubItems.Add(row["nik"].ToString());
                    item.SubItems.Add(row["alamat"].ToString());
                    item.SubItems.Add(row["umur"].ToString());


                    view.lvwPasien.Items.Add(item); // ini yang saya maksud
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void showDataByName(string nama)
        {
            try
            {
                DataTable data = model.getDataByName(nama);
                view.lvwPasien.Items.Clear();

                // Populate the ListView with filtered data
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem(row["pasien_id"].ToString());
                    item.SubItems.Add(row["nama"].ToString());
                    item.SubItems.Add(row["nik"].ToString());
                    item.SubItems.Add(row["alamat"].ToString());
                    item.SubItems.Add(row["umur"].ToString());

                    view.lvwPasien.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        //   public void openTambahAntrean(antrean view, int idPasien)
        //   {
        //       tambahAntrean.showPasien(idPasien);
        //   }
    }
}
