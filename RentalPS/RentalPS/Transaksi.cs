using System;

public class Transaksi
{
    public string NamaKonsol { get; set; }
    public decimal HargaTotal { get; set; }
    public decimal JumlahBayar { get; set; }
    public string MetodePembayaran { get; set; }
    public DateTime TanggalTransaksi { get; set; }

    public Transaksi(string namaKonsol, decimal hargaTotal, decimal jumlahBayar, string metodePembayaran)
    {
        NamaKonsol = namaKonsol;
        HargaTotal = hargaTotal;
        JumlahBayar = jumlahBayar;
        MetodePembayaran = metodePembayaran;
        TanggalTransaksi = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{TanggalTransaksi}: {NamaKonsol} - Total: {HargaTotal:C}, Bayar: {JumlahBayar:C}, {MetodePembayaran}";
    }
}
