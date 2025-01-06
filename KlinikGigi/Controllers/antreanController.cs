using KlinikGigi.Models;
using KlinikGigi.Views.antrean;
using System;
using System.Data;
using System.Windows.Forms;

namespace KlinikGigi.Controllers
{
    public class antreanController
    {
        private antrean view;
        private antreanModel model;

        public antreanController(antrean view)
        {
            this.view = view;
            model = new antreanModel();
        }
        public void OpenTambahAntrean()
        {
            try
            {
                tambahAntrean tambahAntrean = new tambahAntrean(view);
                tambahAntrean.ShowDialog(); // Menampilkan form tambahLayanan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OpenSelectPasien(tambahAntrean tambahAntrean)
        {
            try
            {
                selectPasien selectPasien = new selectPasien(tambahAntrean);
                selectPasien.ShowDialog(); // Menampilkan form tambahLayanan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void OpenSelectDokter(tambahAntrean tambahAntrean)
        {
            try
            {
                selectDokter selectDokter = new selectDokter(tambahAntrean);
                selectDokter.ShowDialog(); // Menampilkan form tambahLayanan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddDataAntrean(int idPasien, int idDokter)
        {
            // Validasi tambahan untuk memastikan ID positif
            if (idPasien <= 0 || idDokter <= 0)
            {
                throw new ArgumentException("ID Pasien atau ID Dokter harus lebih dari nol.");
            }

            try
            {
                // Panggil fungsi Add dari model
                string result = model.AddAntreanData(idPasien, idDokter);

                // Tampilkan pesan sukses
                MessageBox.Show(result, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Tampilkan pesan error
                throw new Exception("Gagal menambahkan antrean: " + ex.Message);
            }
        }
        
        public void ShowData()
        {
            try
            {
                // Get data from the model
                DataTable data = model.GetPasien();

                // Clear the ListView before adding new data

                view.listView2.Items.Clear(); // ini yang saya maksud

                // Populate the ListView with data
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["pasien_id"].ToString());
                    item.SubItems.Add(row["nama"].ToString());

                    view.listView2.Items.Add(item); // ini yang saya maksud
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
