using KlinikGigi.Models.pasien;
using KlinikGigi.Views.pasien;
using System;
using System.Data;
using System.Windows.Forms;

namespace KlinikGigi.Controllers
{
    public class daftarPasienController
    {
        private daftarPasienModel model;
        private daftarPasien view;

        public daftarPasienController(daftarPasien view)
        {
            this.model = new daftarPasienModel(); // Instantiate the model
            this.view = view; // Reference to the view (form)
        }

        public void AddPasien(string nama, long nik, string alamat, int umur)
        {
            try
            {
                // Panggil fungsi Add dari model
                string result = model.AddPasien(nama, nik, alamat, umur);

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
        public void UpdateDaftarPasien(int idPasien, string nama, long nik, string alamat, int umur)
        {
            try
            {
                string result = model.UpdatePasien(idPasien, nama, nik, alamat, umur); //Models.UpdateLayanan itu dari mana dan untulk apa?

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
        public void OpenTambahPasien()
        {
            tambahPasien TambahPasien = new tambahPasien(view); //new tambah pasien error
            TambahPasien.ShowDialog();
        }

        public void OpenHapusPasien(int idPasien)
        {
            try
            {
                hapusPasien hapusPasien = new hapusPasien(view, idPasien);
                hapusPasien.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void OpenEditPasien(int idPasien, string nama, long nik, string alamat, int umur)
        {
            EditPasien editPasien = new EditPasien(view, idPasien, nama, nik, alamat, umur);
            editPasien.ShowDialog();
        }

        public void ShowData()
        {
            try
            {
                // Get data from the model
                DataTable data = model.GetDaftarPasien();

                // Clear the ListView before adding new data

                view.lvwPasien.Items.Clear(); // ini yang saya maksud

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
        public void DeletePasien(int idPasien)
        {
            try
            {
                // Panggil fungsi Add dari model
                string result = model.DelPasienData(idPasien);

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
    }
}
