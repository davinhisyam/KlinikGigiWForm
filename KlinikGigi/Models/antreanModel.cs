using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace KlinikGigi.Models
{
    public class antreanModel
    {
        private string connectionString = "Server=127.0.0.1;Database=klinikGigi;User Id=root;Password=1234;";

        // INi dion ganti
        public string AddAntreanData(int idPasien, int idDokter)
        {
            string query = "INSERT INTO Antrean (pasien_id, dokter_id) VALUES (@pasien_id, @dokter_id)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Pastikan parameter sesuai dengan tipe data di database
                        cmd.Parameters.AddWithValue("@pasien_id", idPasien);
                        cmd.Parameters.AddWithValue("@dokter_id", idDokter);

                        // Eksekusi perintah
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (MySqlException sqlEx)
                {
                    // Tangkap error database
                    return "Kesalahan database: " + sqlEx.Message;
                }
                catch (Exception ex)
                {
                    // Tangkap error lainnya
                    return "Kesalahan umum: " + ex.Message;
                }
            }
            return "Data berhasil ditambahkan";
        }
        public DataTable GetPasien()
        {
            string query = "SELECT r.id, r.pasien_id, p.nama FROM rekam_medis AS r JOIN pasien AS p ON r.pasien_id = p.pasien_id";
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
        /*public string AddDataAntrean(int idPasien, int idDokter)
        {
            string query = "INSERT INTO Layanan (nama_layanan, harga) VALUES (@namaLayanan, @harga)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@namaLayanan", idPasien);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
            return "Data berhasil ditambahkan";
        }*/
    }
}
