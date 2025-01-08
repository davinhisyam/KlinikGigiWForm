using KlinikGigi.Models;
using KlinikGigi.Views;
using KlinikGigi.Views.layanan;
using System;
using System.Data;
using System.Windows.Forms;

namespace KlinikGigi.Controllers
{
    public class layananController
    {
        private layananModel model;
        private layanan view;

        public layananController(layanan view)
        {
            this.model = new layananModel(); // Instantiate the model
            this.view = view; // Reference to the view (form)
        }

        public void ShowData()
        {
            try
            {
                // Get data from the model
                DataTable data = model.GetLayananData();

                // Clear the ListView before adding new data

                view.lvwLayanan.Items.Clear(); // ini yang saya maksud

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

                    view.lvwLayanan.Items.Add(item); // ini yang saya maksud
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddLayanan(string namaLayanan, int harga)
        {
            try
            {
                // Panggil fungsi Add dari model
                string result = model.AddLayananData(namaLayanan, harga);

                // Tampilkan pesan sukses
                MessageBox.Show(result, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh ListView setelah menambahkan data
                ShowData();
            }
            catch (Exception ex)
            {
                // Tampilkan pesan error
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteLayanan(int idLayanan)
        {
            try
            {
                // Panggil fungsi Add dari model
                string result = model.DelLayananData(idLayanan);

                // Tampilkan pesan sukses
                MessageBox.Show(result, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh ListView setelah menambahkan data
                ShowData();
            }
            catch (Exception ex)
            {
                // Tampilkan pesan error
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OpenTambahLayanan()
        {
            try
            {
                tambahLayanan tambahLayanan = new tambahLayanan(view);
                tambahLayanan.ShowDialog(); // Menampilkan form tambahLayanan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void OpenDeleteLayanan(int idLayanan)
        {
            try
            {
                deleteLayanan DeleteLayanan = new deleteLayanan(view, idLayanan);
                DeleteLayanan.ShowDialog(); // Menampilkan form tambahLayanan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateLayanan(int idLayanan, string namaLayanan, int harga)
        {
            try
            {
                string result = model.UpLayananData(idLayanan, namaLayanan, harga); //Models.UpdateLayanan itu dari mana dan untulk apa?

                // Tampilkan pesan sukses
                MessageBox.Show(result, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh ListView setelah memperbarui data
                ShowData(); // ini juga dari mana dan untuk apa?
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void OpenUpdateLayanan(int idLayanan, string namaLayanan, int harga)
        {
            try
            {
                updateLayanan updateLayananForm = new updateLayanan(view, idLayanan, namaLayanan, harga);
                updateLayananForm.ShowDialog(); // Menampilkan form updateLayanan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
