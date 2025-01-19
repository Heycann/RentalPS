using System;
using System.Windows.Forms;

namespace RentalPS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnKonsol_Click(object sender, EventArgs e)
        {
            // Buka Form Konsol
            FormKonsol formKonsol = new FormKonsol();
            formKonsol.ShowDialog();
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            // Buka Form Pembayaran
            string konsol = "PS4"; // Example value
            int hargaTotal = 100000; // Example value
            int hargaPerJam = 5000; // Example value

            FormPembayaran formPembayaran = new FormPembayaran(konsol, hargaTotal, hargaPerJam);
            formPembayaran.ShowDialog();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            // Buka Form Riwayat Pembayaran
            FormRiwayatPembayaran formRiwayat = new FormRiwayatPembayaran();
            formRiwayat.ShowDialog();
        }
    }
}
