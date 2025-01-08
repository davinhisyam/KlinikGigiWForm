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
using KlinikGigi.Controllers;

namespace KlinikGigi
{

    public partial class home : Form
    {
        private homeController controller;
       
        public home()
        {
            InitializeComponent();
            setUpListView();
            controller = new homeController(this);
            controller.ShowData();
        }

        private void setUpListView()
        {
            listViewJadwalDokter.View = View.Details;
            //listViewJadwalDokter = new ListView(); //INI BUAT LIST BARU TONG. PANTES GA MAU MASOK. GG DAVIN.

            listViewJadwalDokter.Columns.Clear();
            listViewJadwalDokter.Columns.Add("...", 75);
            listViewJadwalDokter.Columns.Add("Dokter", 100);
            listViewJadwalDokter.Columns.Add("Hari Jaga", 250);
            listViewJadwalDokter.Columns.Add("Jam Praktek", 100);
            listViewJadwalDokter.Columns.Add("Jam Selesai", 100);
            listViewJadwalDokter.FullRowSelect = true;
            listViewJadwalDokter.SetBounds(100, 50, 400, 200);


            listViewJenisTindakan.View = View.Details;
            //listViewJadwalDokter = new ListView(); //INI BUAT LIST BARU TONG. PANTES GA MAU MASOK. GG DAVIN.

            listViewJenisTindakan.Columns.Clear();
            listViewJenisTindakan.Columns.Add("Nama Tindakan", 310);
            listViewJenisTindakan.FullRowSelect = true;

            rtbDate.Text = DateTime.Now.ToString();
            rtbDate.SelectAll(); // Pilih seluruh teks dalam RichTextBox
            rtbDate.SelectionAlignment = HorizontalAlignment.Center; // Atur teks ke tengah
            rtbDate.DeselectAll(); // Hapus seleksi teks
        }



        private void btnJenisTindakan_Click(object sender, EventArgs e)
        {
            controller.Openlayanan();
        }

        

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            controller.OpenPembayaran();
        }

        private void btnAntrean_Click(object sender, EventArgs e)
        {
            controller.OpenAntrean();
        }

        private void btnRekamMedis_Click(object sender, EventArgs e)
        {
            controller.OpenRekamMedis();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            controller.OpenRiwayat();
        }

        private void btnDaftarPasien_Click(object sender, EventArgs e)
        {
            controller.OpenDaftarPasien();
        }
    }
}
