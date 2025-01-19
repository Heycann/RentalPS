using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentalPS
{
    public partial class FormPembayaran : Form
    {
        private string konsol;
        private int hargaTotal;
        private int hargaPerJam;
        public static List<Transaksi> RiwayatTransaksi = new List<Transaksi>(); // Static untuk akses dari form lain

        public FormPembayaran(string konsol, int hargaTotal, int hargaPerJam)
        {
            InitializeComponent();
            this.konsol = konsol;
            this.hargaTotal = hargaTotal;
            this.hargaPerJam = hargaPerJam;
        }

        private void FormPembayaran_Load(object sender, EventArgs e)
        {
            txtNamaKonsol.Text = konsol;
            txtHargaTotal.Text = hargaTotal.ToString("C");
            txtHargaPerJam.Text = hargaPerJam.ToString("C");

            cmbMetodePembayaran.Items.Add("Cash");
            cmbMetodePembayaran.Items.Add("Card");
            cmbMetodePembayaran.Items.Add("E-Wallet");
            cmbMetodePembayaran.SelectedIndex = 0; // Pilih Cash secara default
        }

        private void btnProsesPembayaran_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJumlahBayar.Text))
            {
                MessageBox.Show("Masukkan jumlah pembayaran!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal jumlahBayar;
            if (!decimal.TryParse(txtJumlahBayar.Text, out jumlahBayar) || jumlahBayar < hargaTotal)
            {
                MessageBox.Show("Jumlah pembayaran tidak valid atau kurang dari harga total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string metodePembayaran = cmbMetodePembayaran.SelectedItem.ToString();

            // Simpan transaksi
            RiwayatTransaksi.Add(new Transaksi(konsol, hargaTotal, jumlahBayar, metodePembayaran));

            MessageBox.Show("Transaksi Berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Kembali ke form utama atau ke form riwayat pembayaran
            this.Close();  // Menutup form pembayaran
        }
    }
}
