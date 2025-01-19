using System.Windows.Forms;

namespace RentalPS
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnKonsol;
        private Button btnPembayaran;
        private Button btnRiwayat;

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
            this.btnKonsol = new System.Windows.Forms.Button();
            this.btnPembayaran = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKonsol
            // 
            this.btnKonsol.Location = new System.Drawing.Point(50, 50);
            this.btnKonsol.Name = "btnKonsol";
            this.btnKonsol.Size = new System.Drawing.Size(100, 30);
            this.btnKonsol.TabIndex = 0;
            this.btnKonsol.Text = "Konsol";
            this.btnKonsol.UseVisualStyleBackColor = true;
            this.btnKonsol.Click += new System.EventHandler(this.btnKonsol_Click);
            // 
            // btnPembayaran
            // 
            this.btnPembayaran.Location = new System.Drawing.Point(200, 50);
            this.btnPembayaran.Name = "btnPembayaran";
            this.btnPembayaran.Size = new System.Drawing.Size(100, 30);
            this.btnPembayaran.TabIndex = 1;
            this.btnPembayaran.Text = "Pembayaran";
            this.btnPembayaran.UseVisualStyleBackColor = true;
            this.btnPembayaran.Click += new System.EventHandler(this.btnPembayaran_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.Location = new System.Drawing.Point(350, 50);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(150, 30);
            this.btnRiwayat.TabIndex = 2;
            this.btnRiwayat.Text = "Riwayat Pembayaran";
            this.btnRiwayat.UseVisualStyleBackColor = true;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 200);
            this.Controls.Add(this.btnRiwayat);
            this.Controls.Add(this.btnPembayaran);
            this.Controls.Add(this.btnKonsol);
            this.Name = "MainForm";
            this.Text = "RentalPS - Main Menu";
            this.ResumeLayout(false);
        }
    }
}
