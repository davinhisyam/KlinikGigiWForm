using KlinikGigi.Models;
using KlinikGigi.Views.antrean;
using KlinikGigi.Views.pembayaran;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikGigi.Controllers
{
    public class pembayaranController
    {
        private pembayaran view;
        private pembayaranModel model;
        private antreanController antrean;
        private antrean antreanview;

        public pembayaranController(pembayaran view)
        {
            this.view = view;
            model = new pembayaranModel();
            antrean = new antreanController(antreanview);
        }
        public void ShowData()
        {
            try
            {
                // Get data from the model
                DataTable data = model.GetPasDok();

                // Clear the ListView before adding new data

                view.listViewAntrean.Items.Clear(); // ini yang saya maksud

                // Populate the ListView with data
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem(row["antrean_id"].ToString());
                    item.SubItems.Add(row["pasien_nama"].ToString());
                    item.SubItems.Add(row["dokter_nama"].ToString());
                    item.SubItems.Add(row["date"].ToString());
                    item.SubItems.Add(row["status"].ToString());


                    view.listViewAntrean.Items.Add(item); // ini yang saya maksud

                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void OpenSelectTindakan()
        {
            try
            {
                selectTindakan selectTindakan = new selectTindakan();
                selectTindakan.ShowDialog(); // Menampilkan form tambahLayanan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddPembayaran(string namaPasien,int idAntrean, string metode, int total)
        {
            try
            {
                string result = model.AddPembayaran(namaPasien, metode, total);
                antrean.AntreanSelesai(idAntrean);
                MessageBox.Show(result, "Suksesss", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
