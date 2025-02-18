﻿using MySql.Data.MySqlClient;
using System;

using System.Data;

namespace KlinikGigi.Models
{
    internal class riwayatModel
    {
        private string connectionString = "Server=127.0.0.1;Database=klinikGigi;User Id=root;Password=1234;";

        public DataTable GetRiwayatData()
        {
            string query = "SELECT p.pembayaran_id, p.total_biaya, p.tanggal_pembayaran, p.metode_pembayaran, pa.nama AS nama_pasien FROM Pembayaran AS p JOIN Pasien AS pa ON pa.pasien_id = p.pasien_id";
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
    }
}
