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

namespace KlinikGigi.Views.layanan
{
    public partial class updateLayanan : Form
    {
        private layananController controller;
        private int idLayanan;
        public updateLayanan(layanan view, int idLayanan, string namaLayanan, int harga)
        {
            InitializeComponent();
            this.idLayanan = idLayanan;
            controller = new layananController(view); //tandain

            txtNamaLayanan.Text = namaLayanan;
            txtHargaLayanan.Text= harga.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string namaLayanan = txtNamaLayanan.Text;
            int harga;

            if (int.TryParse(txtHargaLayanan.Text, out harga))
            {
                controller.UpdateLayanan(idLayanan, namaLayanan, harga);

                this.Close();
            }
            else
            {
                MessageBox.Show("Harga tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
