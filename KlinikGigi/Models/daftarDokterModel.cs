using System;
using KlinikGigi.Models.rekamMedis;
using System.Data;
using MySqlConnector;

namespace KlinikGigi.Models.pasien
{
    public class daftarDokterModel
    {
        private string connectionString = "Server=127.0.0.1;Database=klinikGigi;User Id=root;Password=1234;";
        private rekamMedisModel rekamMedisModel;

        public daftarDokterModel()
        {
            this.rekamMedisModel = new rekamMedisModel();
        }
        public DataTable GetDaftarDokter()
        {
            string query = "SELECT dokter_id, nama_dokter, hari_praktek, jam_praktek, jam_selesai FROM Dokter";
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw new Exception("Terjadi Kesalahan: " + ex.Message);
                }
            }

            return dataTable;
        }

       
        /*public DataTable getDataByName(string nama)
        {
            string query = "SELECT pasien_id, nama, nik, alamat, umur FROM Pasien WHERE nama LIKE @nama";
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nama", $"%{nama.ToLower()}%");
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Terjadi Kesalahan: " + ex.Message);
                }
            }

            return dataTable;
        }*/
    }
}
