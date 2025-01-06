using System;
using System.Data;
using System.Windows.Forms;
using KlinikGigi.Views.layanan;
using MySqlConnector;

namespace KlinikGigi.Models
{
    public class layananModel
    {
        private string connectionString = "Server=127.0.0.1;Database=klinikGigi;User Id=root;Password=1234;";

        public DataTable GetLayananData()
        {
            string query = "SELECT layanan_id, nama_layanan, harga FROM Layanan";
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

        /*public string AddLayananData(string namaLayanan, int harga)
        {
            string query = "INSERT INTO Layanan (nama_layanan, harga) VALUES (@namaLayanan, @harga) ";


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nama", namaLayanan);
                    command.Parameters.AddWithValue("@harga", harga);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery(); // Menjalankan query INSERT
                                             
                        return "Data Berhasil di Masukan";

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Terjadi Kesalahan: " + ex.Message);
                    }
                }
               
                
            }

        }*/
        public string AddLayananData(string namaLayanan, int harga)
        {
            string query = "INSERT INTO Layanan (nama_layanan, harga) VALUES (@namaLayanan, @harga)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@namaLayanan", namaLayanan);
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
        }

        public string DelLayananData(int idLayanan)
        {
            string query = "DELETE FROM Layanan WHERE layanan_id = @idLayanan";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idLayanan", idLayanan);
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

        public string UpLayananData(int idLayanan, string namaLayanan, int harga)
        {
            string query = "UPDATE Layanan SET nama_layanan = @nama_layanan, harga = @harga WHERE layanan_id = @idLayanan";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idLayanan", idLayanan);
                        cmd.Parameters.AddWithValue("@nama_layanan", namaLayanan);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
            return "Data berhasil diperbarui";
        }
    }
}
