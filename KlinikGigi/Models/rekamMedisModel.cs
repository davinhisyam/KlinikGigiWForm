using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace KlinikGigi.Models.rekamMedis
{
    public class rekamMedisModel
    {
        private string connectionString = "Server=127.0.0.1;Database=klinikGigi;User Id=root;Password=1234;";

        public DataTable GetRekamMedis()
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

        public void AutoAddRekamMedis(int idPasien)
        {
            string query = "INSERT INTO rekam_medis (pasien_id) VALUES (@id_pasien)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id_pasien", idPasien);
                        cmd.ExecuteNonQuery();
                    }
                }
                //error insert data
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Data Rekam Medis berhasil ditambahkan otomatis", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DataTable getDataByName(string nama)
        {
            string query = @"SELECT r.id, r.pasien_id, p.nama 
        FROM rekam_medis AS r 
        JOIN pasien AS p ON r.pasien_id = p.pasien_id
        WHERE LOWER(p.nama) LIKE @nama";
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
        }
    }
}
