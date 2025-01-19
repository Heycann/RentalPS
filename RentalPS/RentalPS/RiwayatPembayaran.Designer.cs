using System.Windows.Forms;

namespace RentalPS
{
    partial class FormRiwayatPembayaran
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxRiwayat;
        private Label lblRiwayatPembayaran;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblRiwayatPembayaran = new System.Windows.Forms.Label();
            this.listBoxRiwayat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblRiwayatPembayaran
            // 
            this.lblRiwayatPembayaran.AutoSize = true;
            this.lblRiwayatPembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblRiwayatPembayaran.Location = new System.Drawing.Point(50, 20);
            this.lblRiwayatPembayaran.Name = "lblRiwayatPembayaran";
            this.lblRiwayatPembayaran.Size = new System.Drawing.Size(170, 25);
            this.lblRiwayatPembayaran.TabIndex = 0;
            this.lblRiwayatPembayaran.Text = "Riwayat Pembayaran";
            // 
            // listBoxRiwayat
            // 
            this.listBoxRiwayat.FormattingEnabled = true;
            this.listBoxRiwayat.ItemHeight = 16;
            this.listBoxRiwayat.Location = new System.Drawing.Point(50, 60);
            this.listBoxRiwayat.Name = "listBoxRiwayat";
            this.listBoxRiwayat.Size = new System.Drawing.Size(350, 180);
            this.listBoxRiwayat.TabIndex = 1;
            // 
            // FormRiwayatPembayaran
            // 
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.listBoxRiwayat);
            this.Controls.Add(this.lblRiwayatPembayaran);
            this.Name = "FormRiwayatPembayaran";
            this.Text = "Riwayat Pembayaran";
            this.Load += new System.EventHandler(this.FormRiwayatPembayaran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
