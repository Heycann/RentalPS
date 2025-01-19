using System.Windows.Forms;

namespace RentalPS
{
    partial class FormPembayaran
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblNamaKonsol;
        private TextBox txtNamaKonsol;
        private TextBox txtHargaTotal;
        private TextBox txtHargaPerJam;
        private Label lblHargaTotal;
        private Label lblHargaPerJam;
        private ComboBox cmbMetodePembayaran;
        private TextBox txtJumlahBayar;
        private Label lblJumlahBayar;
        private Button btnProsesPembayaran;
        private Label lblStatusPembayaran;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNamaKonsol = new System.Windows.Forms.Label();
            this.txtNamaKonsol = new System.Windows.Forms.TextBox();
            this.txtHargaTotal = new System.Windows.Forms.TextBox();
            this.txtHargaPerJam = new System.Windows.Forms.TextBox();
            this.lblHargaTotal = new System.Windows.Forms.Label();
            this.lblHargaPerJam = new System.Windows.Forms.Label();
            this.cmbMetodePembayaran = new System.Windows.Forms.ComboBox();
            this.txtJumlahBayar = new System.Windows.Forms.TextBox();
            this.lblJumlahBayar = new System.Windows.Forms.Label();
            this.btnProsesPembayaran = new System.Windows.Forms.Button();
            this.lblStatusPembayaran = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pembayaran";
            // 
            // lblNamaKonsol
            // 
            this.lblNamaKonsol.AutoSize = true;
            this.lblNamaKonsol.Location = new System.Drawing.Point(50, 60);
            this.lblNamaKonsol.Name = "lblNamaKonsol";
            this.lblNamaKonsol.Size = new System.Drawing.Size(92, 17);
            this.lblNamaKonsol.TabIndex = 1;
            this.lblNamaKonsol.Text = "Nama Konsol:";
            // 
            // txtNamaKonsol
            // 
            this.txtNamaKonsol.Location = new System.Drawing.Point(150, 60);
            this.txtNamaKonsol.Name = "txtNamaKonsol";
            this.txtNamaKonsol.ReadOnly = true;
            this.txtNamaKonsol.Size = new System.Drawing.Size(200, 22);
            this.txtNamaKonsol.TabIndex = 2;
            // 
            // txtHargaTotal
            // 
            this.txtHargaTotal.Location = new System.Drawing.Point(150, 100);
            this.txtHargaTotal.Name = "txtHargaTotal";
            this.txtHargaTotal.ReadOnly = true;
            this.txtHargaTotal.Size = new System.Drawing.Size(200, 22);
            this.txtHargaTotal.TabIndex = 4;
            // 
            // txtHargaPerJam
            // 
            this.txtHargaPerJam.Location = new System.Drawing.Point(150, 140);
            this.txtHargaPerJam.Name = "txtHargaPerJam";
            this.txtHargaPerJam.ReadOnly = true;
            this.txtHargaPerJam.Size = new System.Drawing.Size(200, 22);
            this.txtHargaPerJam.TabIndex = 6;
            // 
            // lblHargaTotal
            // 
            this.lblHargaTotal.AutoSize = true;
            this.lblHargaTotal.Location = new System.Drawing.Point(50, 100);
            this.lblHargaTotal.Name = "lblHargaTotal";
            this.lblHargaTotal.Size = new System.Drawing.Size(85, 17);
            this.lblHargaTotal.TabIndex = 3;
            this.lblHargaTotal.Text = "Harga Total:";
            // 
            // lblHargaPerJam
            // 
            this.lblHargaPerJam.AutoSize = true;
            this.lblHargaPerJam.Location = new System.Drawing.Point(50, 140);
            this.lblHargaPerJam.Name = "lblHargaPerJam";
            this.lblHargaPerJam.Size = new System.Drawing.Size(108, 17);
            this.lblHargaPerJam.TabIndex = 5;
            this.lblHargaPerJam.Text = "Harga per Jam:";
            // 
            // cmbMetodePembayaran
            // 
            this.cmbMetodePembayaran.FormattingEnabled = true;
            this.cmbMetodePembayaran.Location = new System.Drawing.Point(150, 180);
            this.cmbMetodePembayaran.Name = "cmbMetodePembayaran";
            this.cmbMetodePembayaran.Size = new System.Drawing.Size(200, 24);
            this.cmbMetodePembayaran.TabIndex = 7;
            // 
            // txtJumlahBayar
            // 
            this.txtJumlahBayar.Location = new System.Drawing.Point(150, 220);
            this.txtJumlahBayar.Name = "txtJumlahBayar";
            this.txtJumlahBayar.Size = new System.Drawing.Size(200, 22);
            this.txtJumlahBayar.TabIndex = 8;
            // 
            // lblJumlahBayar
            // 
            this.lblJumlahBayar.AutoSize = true;
            this.lblJumlahBayar.Location = new System.Drawing.Point(50, 220);
            this.lblJumlahBayar.Name = "lblJumlahBayar";
            this.lblJumlahBayar.Size = new System.Drawing.Size(94, 17);
            this.lblJumlahBayar.TabIndex = 9;
            this.lblJumlahBayar.Text = "Jumlah Bayar:";
            // 
            // btnProsesPembayaran
            // 
            this.btnProsesPembayaran.Location = new System.Drawing.Point(150, 260);
            this.btnProsesPembayaran.Name = "btnProsesPembayaran";
            this.btnProsesPembayaran.Size = new System.Drawing.Size(200, 30);
            this.btnProsesPembayaran.TabIndex = 10;
            this.btnProsesPembayaran.Text = "Proses Pembayaran";
            this.btnProsesPembayaran.UseVisualStyleBackColor = true;
            this.btnProsesPembayaran.Click += new System.EventHandler(this.btnProsesPembayaran_Click);
            // 
            // lblStatusPembayaran
            // 
            this.lblStatusPembayaran.AutoSize = true;
            this.lblStatusPembayaran.Location = new System.Drawing.Point(50, 300);
            this.lblStatusPembayaran.Name = "lblStatusPembayaran";
            this.lblStatusPembayaran.Size = new System.Drawing.Size(122, 17);
            this.lblStatusPembayaran.TabIndex = 11;
            this.lblStatusPembayaran.Text = "Status Pembayaran:";
            // 
            // FormPembayaran
            // 
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.lblStatusPembayaran);
            this.Controls.Add(this.btnProsesPembayaran);
            this.Controls.Add(this.lblJumlahBayar);
            this.Controls.Add(this.txtJumlahBayar);
            this.Controls.Add(this.cmbMetodePembayaran);
            this.Controls.Add(this.lblHargaPerJam);
            this.Controls.Add(this.txtHargaPerJam);
            this.Controls.Add(this.lblHargaTotal);
            this.Controls.Add(this.txtHargaTotal);
            this.Controls.Add(this.txtNamaKonsol);
            this.Controls.Add(this.lblNamaKonsol);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormPembayaran";
            this.Text = "Pembayaran";
            this.Load += new System.EventHandler(this.FormPembayaran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
