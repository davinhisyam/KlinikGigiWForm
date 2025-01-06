using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace KlinikGigi.Models
{
    public class homeModel
    {
        /*public string NamaLayanan { get; set; }
        public decimal Harga { get; set; }*/

        private string connectionString = "Server=127.0.0.1;Database=klinikGigi;User Id=root;Password=1234;";

        public DataTable GetJadwalDokter()
        {
            string query = "SELECT dokter_id, nama_dokter, hari_praktek, jam_praktek, jam_selesai FROM Dokter";
            DataTable dataTableJD = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTableJD);
                }
                catch (Exception ex)
                {
                    throw new Exception("Terjadi Kesalahan: " + ex.Message);
                }
            }

            return dataTableJD;
        }
        public DataTable GetJenisTindakan()
        {
            string query = "SELECT nama_layanan FROM Layanan";
            DataTable dataTableJT = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTableJT);
                }
                catch (Exception ex)
                {
                    throw new Exception("Terjadi Kesalahan: " + ex.Message);
                }
            }

            return dataTableJT;
        }



    }
}
