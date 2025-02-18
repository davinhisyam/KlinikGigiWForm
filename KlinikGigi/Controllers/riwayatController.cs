﻿using KlinikGigi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikGigi.Controllers
{
    internal class riwayatController
    {
        private riwayat view;
        private riwayatModel model;

        public riwayatController(riwayat view)
        {
            this.view = view;
            this.model = new riwayatModel();
        }

        public void ShowData()
        {
            try
            {
                // Get data from the model
                DataTable data = model.GetRiwayatData();

                // Clear the ListView before adding new data

                view.lvwRiwayat.Items.Clear(); // ini yang saya maksud

                // Populate the ListView with data
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem(row["pembayaran_id"].ToString());
                    item.SubItems.Add(row["nama_pasien"].ToString());

                    if (decimal.TryParse(row["total_biaya"].ToString(), out decimal harga))
                    {
                        item.SubItems.Add(harga.ToString("C")); // Format as currency
                    }
                    else
                    {
                        item.SubItems.Add("Invalid Harga");
                    }
                    item.SubItems.Add(row["metode_pembayaran"].ToString());
                    item.SubItems.Add(row["tanggal_pembayaran"].ToString());

                    view.lvwRiwayat.Items.Add(item); // ini yang saya maksud
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
