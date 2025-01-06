using System;
using KlinikGigi.Models;
using System.Data;
using System.Windows.Forms;
using KlinikGigi.Views.layanan;
using KlinikGigi.Views.pasien;
using KlinikGigi.Views.antrean;


namespace KlinikGigi.Controllers
{
    public class homeController
    {
        private homeModel homemodel; //model
        private home homes; //view

        public homeController(home homes)
        {
            this.homemodel = new homeModel();
            this.homes = homes;
        }

        /*public void loadData()
        {
            try
            {
                DataTable jadwalDokter = homemodel.GetJadwalDokter();
                populateListView(homes.listViewJadwalDokter /*error, jadwalDokter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateListView(ListView listView, DataTable data)
        {
            listView.Items.Clear();

            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listView.Items.Add(item);
            }
        }*/

        public void ShowData()
        {
            try
            {
                // Get data from the model
                DataTable data = homemodel.GetJadwalDokter();
                DataTable dataJT = homemodel.GetJenisTindakan();

                // Clear the ListView before adding new data
                homes.listViewJadwalDokter.Items.Clear();
                homes.listViewJenisTindakan.Items.Clear();
                // Populate the ListView with data
                foreach (DataRow row in data.Rows)
                {

                    ListViewItem item = new ListViewItem(row["dokter_id"].ToString());
                    item.SubItems.Add(row["nama_dokter"].ToString());
                    item.SubItems.Add(row["hari_praktek"].ToString());
                    item.SubItems.Add(row["jam_praktek"].ToString());
                    item.SubItems.Add(row["jam_selesai"].ToString());


                   
                    /*if (decimal.TryParse(row["harga"].ToString(), out decimal harga))
                    {
                        item.SubItems.Add(harga.ToString("C")); // Format as currency
                    }
                    else
                    {
                        item.SubItems.Add("Invalid Harga");
                    }*/

                    homes.listViewJadwalDokter.Items.Add(item);
                    

                }
                foreach (DataRow row in dataJT.Rows)
                {
                    ListViewItem itemJT = new ListViewItem(row["nama_layanan"].ToString());
                    //itemJT.SubItems.Add(row["nama_layanan"].ToString());
                    homes.listViewJenisTindakan.Items.Add(itemJT);
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Openlayanan()
        {
            layanan jenisTindakan = new layanan();
            jenisTindakan.Show();
        }

        

        public void OpenPembayaran()
        {
            pembayaran pembayaran = new pembayaran();
            pembayaran.ShowDialog();
        }

        public void OpenAntrean()
        {
            antrean antrean = new antrean();
            antrean.ShowDialog();
        }

        public void OpenRekamMedis()
        {
            rekamMedis rekamMedis = new rekamMedis();
            rekamMedis.ShowDialog();
        }

        public void OpenRiwayat()
        {
            riwayat riwayat = new riwayat();
            riwayat.ShowDialog();
        }

        public void OpenDaftarPasien()
        {
            daftarPasien daftarPasien = new daftarPasien();
            daftarPasien.ShowDialog();
        }
    }
}
