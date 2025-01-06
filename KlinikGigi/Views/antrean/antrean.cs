using KlinikGigi.Controllers;
using System;
using System.Windows.Forms;

namespace KlinikGigi.Views.antrean
{
    public partial class antrean : Form
    {
        private antreanController controller;
        public antrean()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.antrean_Load);
            this.controller = new antreanController(this);
        }
        
        
        private void SetupListView()
        {
            // Configure columns for the ListView
            listView2.Columns.Add("NO", 50);
            listView2.Columns.Add("Nama Pasien", 100);
            listView2.Columns.Add("Nama Dokter", 100);

            listView2.View = View.Details;
            listView2.FullRowSelect = true;
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
        }
        private void antrean_Load(object sender, EventArgs e)
        {
            SetupListView();
            ShowDataInListView();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            controller.OpenTambahAntrean();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
