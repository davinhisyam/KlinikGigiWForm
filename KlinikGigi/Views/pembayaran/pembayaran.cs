using KlinikGigi.Controllers;
using KlinikGigi.Models;
using KlinikGigi.Views.pembayaran;
using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KlinikGigi
{
    public partial class pembayaran : Form
    {
        private pembayaranController controller;
        // private pembayaran view;
        public pembayaran()
        {
            InitializeComponent();
            controller = new pembayaranController(this);
            this.Load += new System.EventHandler(this.layanan_Load);
        }
        
        

        private void SetupListView()
        {
            // Configure columns for the ListView
            listViewAntrean.Columns.Add("No Antrean", 100);
            listViewAntrean.Columns.Add("Nama Pasien", 200);
            listViewAntrean.Columns.Add("Nama Dokter", 100);
            listViewAntrean.Columns.Add("Tanggal", 100);
            listViewAntrean.Columns.Add("Status", 100);

            listViewAntrean.View = View.Details;
            listViewAntrean.FullRowSelect = true;
        }

        public void ShowDataInListView()
        {
            controller.ShowData();
        }

        private void layanan_Load(object sender, EventArgs e)
        {
            // Setup ListView and load data when the form loads
            SetupListView();
            ShowDataInListView();
            SetupListViewTindakan();
        }
        

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pembayaran_Load(object sender, EventArgs e)
        {
            // Setup ListView and load data when the form loads
            // SetupListView();
            // ShowDataInListView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
        private void SetupListViewTindakan()
        {
            // Configure columns for the ListView
            listViewTindakan.Columns.Add("Id", 100);
            listViewTindakan.Columns.Add("Nama Tindakan", 200);
            listViewTindakan.Columns.Add("Harga", 100);


            listViewTindakan.View = View.Details;
            listViewTindakan.FullRowSelect = true;
        }

        private void btnPilihTindakan_Click(object sender, EventArgs e)
        {
            //controller.OpenSelectTindakan();
            if (listViewAntrean.SelectedItems.Count > 0)
            {

                var selectTindakanForm = new selectTindakan();
                selectTindakanForm.TindakanDipilih += TambahkanTindakanKeListView;
                selectTindakanForm.ShowDialog();
                totalHarga();
            }
            else MessageBox.Show("Pilih Pasien Terlebih Dahulu!", "Peringatan brou!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            
        }
        private void TambahkanTindakanKeListView(int idLayanan, string namaLayanan, int harga)
        {
            // Menambahkan data ke ListView
            var item = new ListViewItem(idLayanan.ToString());
            item.SubItems.Add(namaLayanan);
            item.SubItems.Add(harga.ToString("C"));

            listViewTindakan.Items.Add(item);
        }

        private void totalHarga()
        {
            
            var totalHarga = 0;
            
            foreach (ListViewItem item in listViewTindakan.Items)
            {
                // Ambil nilai di kolom "Harga" (indeks 2)
                string hargaText = item.SubItems[2].Text;

                // Konversi ke integer (jika perlu, sesuaikan format parsing)
                if (int.TryParse(hargaText, System.Globalization.NumberStyles.Currency, null, out int harga))
                {

                    totalHarga += harga;
                }
                else
                {
                    MessageBox.Show($"Gagal mengonversi nilai '{hargaText}' ke angka.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            rtbTotal.Text = totalHarga.ToString();
            rtbTotal.Refresh();
        }

        private void btnLunas_Click(object sender, EventArgs e)
        {
            var antrean = listViewAntrean.SelectedItems.Count > 0;
            var tindakan = listViewTindakan.Items.Count > 0;
            var bayar = cmbJenisBayar.SelectedIndex >= 0;
            var message = "Harap Pilih ";

            if (antrean && tindakan && bayar)
            {
                MessageBox.Show("Berhasil!");
                //"panggil data ke pembayaran!";
                var data = kirimData();
                controller.AddPembayaran(data[0].ToString(), int.Parse(data[1].ToString()), data[2].ToString(), int.Parse(data[3].ToString()));
            }
            else
            {
                if (!antrean) message += "Pasien, ";
                if (!tindakan) message += "Tindakan, ";
                if (!bayar) message += "Pembayaran";
                MessageBox.Show(message);
            }
        }

        private object[] kirimData()
        {
            var namaPasien = listViewAntrean.SelectedItems[0].SubItems[1].Text;
            var idAntrean = listViewAntrean.SelectedItems[0].SubItems[0].Text;
            var total = rtbTotal.Text;
            var metode = cmbJenisBayar.SelectedItem.ToString();

            return new object[] { namaPasien, idAntrean, metode, total };
        }
    }
}
