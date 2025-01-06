using KlinikGigi.Models.rekamMedis;
using KlinikGigi.Views.layanan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikGigi.Controllers
{
    public class rekamMedisController
    {
        private rekamMedisModel model;
        private rekamMedis view;

        public rekamMedisController(rekamMedis view)
        {
            this.model = new rekamMedisModel(); // Instantiate the model
            this.view = view; // Reference to the view (form)
        }

        public void ShowData()
        {
            try
            {
                // Get data from the model
                DataTable data = model.GetRekamMedis();

                // Clear the ListView before adding new data

                view.lvwRekamMedis.Items.Clear(); // ini yang saya maksud

                // Populate the ListView with data
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["pasien_id"].ToString());
                    item.SubItems.Add(row["nama"].ToString());

                    view.lvwRekamMedis.Items.Add(item); // ini yang saya maksud
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private rekamMedis view;
        public void showDataByName(string nama)
        {
            try
            {
                DataTable data = model.getDataByName(nama);
                view.lvwRekamMedis.Items.Clear();

                // Populate the ListView with filtered data
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["pasien_id"].ToString());
                    item.SubItems.Add(row["nama"].ToString());

                    view.lvwRekamMedis.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
