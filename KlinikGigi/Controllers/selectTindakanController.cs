using KlinikGigi.Models;
using KlinikGigi.Views.layanan;
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
    public class selectTindakanController
    {
        private selectTindakanModel model;
        private selectTindakan view;

        public selectTindakanController(selectTindakan view)
        {
            this.model = new selectTindakanModel(); // Instantiate the model
            this.view = view; // Reference to the view (form)
        }

        public void ShowData()
        {
            try
            {
                // Get data from the model
                DataTable data = model.GetLayananData();

                // Clear the ListView before adding new data

                view.lvwTindakan.Items.Clear(); // ini yang saya maksud

                // Populate the ListView with data
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem(row["layanan_id"].ToString());
                    item.SubItems.Add(row["nama_layanan"].ToString());

                    if (decimal.TryParse(row["harga"].ToString(), out decimal harga))
                    {
                        item.SubItems.Add(harga.ToString("C")); // Format as currency
                    }
                    else
                    {
                        item.SubItems.Add("Invalid Harga");
                    }

                    view.lvwTindakan.Items.Add(item); // ini yang saya maksud
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
