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

namespace KlinikGigi
{
    public partial class riwayat : Form
    {
        private riwayatController controller;
        public riwayat()
        {
            InitializeComponent();
            controller = new riwayatController(this);
            this.Load += new System.EventHandler(this.riwayat_Load);
        }

        private void SetupListView() {
            lvwRiwayat.Columns.Add("ID Pembayaran", 100);
            lvwRiwayat.Columns.Add("Nama Pasien", 220);
            lvwRiwayat.Columns.Add("Total Biaya", 200);
            lvwRiwayat.Columns.Add("Metode Pembayaran", 200);
            lvwRiwayat.Columns.Add("Tanggal Pembayaran", 200);

            lvwRiwayat.View = View.Details;
            lvwRiwayat.FullRowSelect = true;
        }

        public void ShowData()
        {
            controller.ShowData();
        }

        private void riwayat_Load(object sender, EventArgs e) { 
            SetupListView();
            ShowData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
