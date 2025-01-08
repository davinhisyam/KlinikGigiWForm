using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikGigi.Views.layanan;
using MySqlConnector;

namespace KlinikGigi.Models
{
    public class pembayaranModel
    {
        private string connectionString = "Server=127.0.0.1;Database=klinikGigi;User Id=root;Password=1234;";

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
        public string AddPembayaran(string namaPasien, string metode, int total)
        {
            string getIdQuery = "SELECT pasien_id FROM Pasien WHERE nama = @namaPasien LIMIT 1";
            string query = "INSERT INTO Pembayaran (pasien_id, metode_pembayaran, total_biaya, tanggal_pembayaran) VALUES (@namaPasien, @method, @total, @date)";
            int idPasien;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Ambil ID Pasien berdasarkan nama
                    using (MySqlCommand getIdCmd = new MySqlCommand(getIdQuery, connection))
                    {
                        getIdCmd.Parameters.AddWithValue("@namaPasien", namaPasien);
                        object result = getIdCmd.ExecuteScalar();

                        if (result != null)
                        {
                            idPasien = Convert.ToInt32(result);
                        }
                        else
                        {
                            return "Error: Nama pasien tidak ditemukan.";
                        }
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@namaPasien", idPasien);
                        cmd.Parameters.AddWithValue("@method", metode);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
            return "Data Pembayaran Berhasil Ditambah";
        }
    }
}
