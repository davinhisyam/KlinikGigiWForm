using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlinikGigi.Controllers;
using MySqlConnector;


namespace KlinikGigi
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            loginController login = new loginController();
            bool isAuthenticated = login.Authenticate(username, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                home homeForm = new home(); // Ganti dengan nama form home Anda
                homeForm.Show();
            }
            else
            {
                MessageBox.Show("Username atau Password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
