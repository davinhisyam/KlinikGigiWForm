using System;
using KlinikGigi.Models.rekamMedis;
using System.Data;
using MySqlConnector;

namespace KlinikGigi.Models.pasien
{
    public class daftarPasienModel
    {
        private string connectionString = "Server=127.0.0.1;Database=klinikGigi;User Id=root;Password=1234;";
        private rekamMedisModel rekamMedisModel;

        public daftarPasienModel()
        {
            this.rekamMedisModel = new rekamMedisModel();
        }
        public DataTable GetDaftarPasien()
        {
            string query = "SELECT pasien_id, nama, nik, alamat, umur FROM Pasien";
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

        public string AddPasien(string nama, long nik, string alamat, int umur)
        {
            string query = "INSERT INTO Pasien (nama, nik, alamat, umur) VALUES (@nama, @nik, @alamat, @umur)";
            int lastid;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@nik", nik);
                        cmd.Parameters.AddWithValue("@alamat", alamat);
                        cmd.Parameters.AddWithValue("@umur", umur);
                        cmd.ExecuteNonQuery();
                        
                    }
                    using (MySqlCommand cmd = new MySqlCommand("SELECT max(pasien_id) FROM pasien", connection))
                    {
                        lastid = Convert.ToInt32(cmd.ExecuteScalar());
                        rekamMedisModel.AutoAddRekamMedis(lastid);
                    }
                }
                //error insert data
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
            //TODO, AMBIL ID PASIEN YG BARU DIBUAT, KIRIM KE REKAM MEDIS UNTUK DIBUAT.
            return "Data berhasil ditambahkan";
        }

        public string UpdatePasien(int idPasien, string nama, long nik, string alamat, int umur)
        {
            string query = "UPDATE Pasien SET nama = @nama, nik = @nik, alamat = @alamat, umur = @umur WHERE pasien_id = @idPasien";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idPasien", idPasien);
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@nik", nik);
                        cmd.Parameters.AddWithValue("@alamat", alamat);
                        cmd.Parameters.AddWithValue("@umur", umur);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
            return "Data berhsil diperbarui";
        }
        public string DelPasienData(int idPasien)
        {
            string query = /*"UPDATE Pasien SET nama = @nama, nik = @nik, alamat = @alamat, umur = @umur WHERE pasien_id = @idPasien"*/ "DELETE FROM Pasien WHERE pasien_id = @idPasien";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idPasien", idPasien);
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
        public DataTable getDataByName(string nama)
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
        }
    }
}
