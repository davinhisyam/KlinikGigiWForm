using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace KlinikGigi.Models
{
    public class antreanModel
    {
        private string connectionString = "Server=127.0.0.1;Database=klinikGigi;User Id=root;Password=1234;";

        // INi dion ganti
        public string AddAntreanData(int idPasien, int idDokter)
        {
            string query = "INSERT INTO Antrean (pasien_id, dokter_id, tanggal_antrean, status_antrean) VALUES (@pasien_id, @dokter_id, @date, @status)";
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
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@status", "Antri");

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

        public DataTable GetPasDok()
        {
            string query = "SELECT a.antrean_id, a.tanggal_antrean AS date, a.status_antrean AS status, p.nama AS pasien_nama, d.nama_dokter AS dokter_nama FROM antrean AS a JOIN pasien AS p ON a.pasien_id = p.pasien_id JOIN dokter AS d ON a.dokter_id = d.dokter_id WHERE visible = true;";
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
        public string DelAntreanData(int idAntrean)
        {
            string query = "DELETE FROM Antrean WHERE antrean_id = @idAntrean";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idAntrean", idAntrean);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
            return "Data berhasil dihapus";
        }

        public String AntreanSelesai(int id)
        {
            string query = "UPDATE Antrean SET visible = false, status_antrean = 'Selesai' where antrean_id = @id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
            return "Antrean Masuk ke Riwayat";
        }
    }
}
