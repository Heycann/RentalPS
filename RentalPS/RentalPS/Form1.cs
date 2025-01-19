using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RentalPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Username dan password yang valid (contoh hardcoded)
            string validUsername = "admin";
            string validPassword = "12345";

            // Validasi login
            if (txtUsername.Text == validUsername && txtPassword.Text == validPassword)
            {
                MessageBox.Show("Login berhasil! Selamat datang di RentalPS.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Pindah ke form utama (MainForm)
                this.Hide(); // Sembunyikan form login
                MainForm mainForm = new MainForm(); // Form utama setelah login
                mainForm.Show();
            }
            else
            {
                lblError.Text = "Username atau Password salah!";
                lblError.Visible = true; // Tampilkan pesan error
            }
        }
    }
}
