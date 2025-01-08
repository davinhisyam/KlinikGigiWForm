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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KlinikGigi
{
    public partial class rekamMedis : Form
    {
        private rekamMedisController controller;
        public rekamMedis()
        {
            InitializeComponent();
            controller = new rekamMedisController(this);
            this.Load += new System.EventHandler(this.layanan_Load);
        }
        private void SetupListView()
        {
            // Configure columns for the ListView
            lvwRekamMedis.Columns.Add("NO", 50);
            lvwRekamMedis.Columns.Add("ID Pasien", 50);
            lvwRekamMedis.Columns.Add("Nama Pasien", 100);
            lvwRekamMedis.Columns.Add("Tindakan", 100);

            lvwRekamMedis.View = View.Details;
            lvwRekamMedis.FullRowSelect = true;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string cariNama = txtBoxSearch.Text;
            if (string.IsNullOrEmpty(cariNama))
            {
                controller.ShowData();
            }
            else
            {
                controller.showDataByName(cariNama);
            }
        }
    }
}
