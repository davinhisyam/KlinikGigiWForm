using KlinikGigi.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikGigi.Views.pembayaran
{
    public partial class selectTindakan : Form
    {
        private selectTindakanController controller;
        public event Action<int, string, int> TindakanDipilih; // Event untuk mengirim data
        public selectTindakan()
        {
            InitializeComponent();
            controller = new selectTindakanController(this);
            this.Load += new System.EventHandler(this.layanan_Load);
        }

        private void SetupListView()
        {
            // Configure columns for the ListView
            
            lvwTindakan.Columns.Add("     ID Layanan", 100);
            lvwTindakan.Columns.Add("Nama Layanan", 220);
            lvwTindakan.Columns.Add("Harga", 200);

            lvwTindakan.View = View.Details;
            lvwTindakan.FullRowSelect = true;
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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
             if (lvwTindakan.CheckedItems.Count > 0)
             {
                foreach (ListViewItem checkedItem in lvwTindakan.CheckedItems)
                {
                    int id = int.Parse(checkedItem.SubItems[0].Text);
                    string namaLayanan = checkedItem.SubItems[1].Text;
                    int harga = int.Parse(checkedItem.SubItems[2].Text, System.Globalization.NumberStyles.Currency);

                    // Memicu event untuk setiap item yang dicentang
                    TindakanDipilih?.Invoke(id, namaLayanan, harga);
                }
                this.Close(); // Menutup form setelah memilih

             }
             else
             {
                MessageBox.Show("Pilih satu tindakan terlebih dahulu.");
             }
        }
    }
}
