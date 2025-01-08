using KlinikGigi.Models;
using KlinikGigi.Views.antrean;
using KlinikGigi.Views.layanan;
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
                ShowData();

                // Tampilkan pesan sukses
                MessageBox.Show(result, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Tampilkan pesan error
                throw new Exception("Gagal menambahkan antrean: " + ex.Message);
            }
        }

        public void OpenDeleteAntrean(int idAntrean)
        {
            try
            {
                deleteAntrean DeleteAntrean = new deleteAntrean(view, idAntrean);
                DeleteAntrean.ShowDialog(); // Menampilkan form tambahLayanan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteAntrean(int idAntrean)
        {
            try
            {
                // Panggil fungsi Add dari model
                string result = model.DelAntreanData(idAntrean);

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

        public void ShowData()
        {
            try
            {
                // Get data from the model
                DataTable data = model.GetPasDok();

                // Clear the ListView before adding new data

                view.lvwDaftarAntrean.Items.Clear(); // ini yang saya maksud

                // Populate the ListView with data
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem(row["antrean_id"].ToString());
                    item.SubItems.Add(row["pasien_nama"].ToString());
                    item.SubItems.Add(row["dokter_nama"].ToString());
                    item.SubItems.Add(row["date"].ToString());
                    item.SubItems.Add(row["status"].ToString());

                    
                    view.lvwDaftarAntrean.Items.Add(item); // ini yang saya maksud

                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AntreanSelesai(int id)
        {
            model.AntreanSelesai(id);
        }
    }
}
