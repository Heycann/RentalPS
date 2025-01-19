using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentalPS
{
    public partial class FormRiwayatPembayaran : Form
    {
        public FormRiwayatPembayaran()
        {
            InitializeComponent();
        }

        private void FormRiwayatPembayaran_Load(object sender, EventArgs e)
        {
            // Menampilkan riwayat transaksi di ListBox
            foreach (var transaksi in FormPembayaran.RiwayatTransaksi)
            {
                listBoxRiwayat.Items.Add(transaksi.ToString());
            }
        }
    }
}
