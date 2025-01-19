using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RentalPS
{
    public partial class FormKonsol : Form
    {
        // Data harga konsol per jam dan harga total
        private readonly Dictionary<string, (int HargaTotal, int HargaPerJam)> konsolHarga = new Dictionary<string, (int, int)>
        {
            { "PS1", (10000, 5000) },
            { "PS2", (15000, 7000) },
            { "PS3", (20000, 10000) },
            { "PS4", (25000, 15000) },
            { "PS5", (30000, 20000) }
        };

        private string konsolDipilih = null; // Konsol yang dipilih user

        public FormKonsol()
        {
            InitializeComponent();
        }

        private void FormKonsol_Load(object sender, EventArgs e)
        {
            // Isi daftar konsol
            listKonsol.Items.AddRange(konsolHarga.Keys.ToArray());
        }

        private void listKonsol_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tampilkan harga saat konsol dipilih
            if (listKonsol.SelectedItem != null)
            {
                konsolDipilih = listKonsol.SelectedItem.ToString();
                var harga = konsolHarga[konsolDipilih];
                lblHarga.Text = $"Harga Total: {harga.HargaTotal:C}\nHarga per Jam: {harga.HargaPerJam:C}";
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            // Pastikan ada konsol yang dipilih
            if (konsolDipilih == null)
            {
                MessageBox.Show("Pilih konsol terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kirim data ke Form Pembayaran
            var harga = konsolHarga[konsolDipilih];
            FormPembayaran formPembayaran = new FormPembayaran(konsolDipilih, harga.HargaTotal, harga.HargaPerJam);
            formPembayaran.ShowDialog();
        }
    }
}
