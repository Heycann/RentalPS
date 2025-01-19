using System;
using System.Windows.Forms;

namespace RentalPS
{
    partial class FormKonsol
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private ListBox listKonsol;
        private Button btnKembali;
        private Label lblHarga;
        private Button btnBayar;

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
            this.listKonsol = new System.Windows.Forms.ListBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.lblHarga = new System.Windows.Forms.Label();
            this.btnBayar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Daftar Konsol";
            // 
            // listKonsol
            // 
            this.listKonsol.FormattingEnabled = true;
            this.listKonsol.ItemHeight = 16;
            this.listKonsol.Location = new System.Drawing.Point(50, 60);
            this.listKonsol.Name = "listKonsol";
            this.listKonsol.Size = new System.Drawing.Size(200, 100);
            this.listKonsol.TabIndex = 1;
            this.listKonsol.SelectedIndexChanged += new System.EventHandler(this.listKonsol_SelectedIndexChanged);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(50, 220);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(100, 30);
            this.btnKembali.TabIndex = 2;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHarga.Location = new System.Drawing.Point(50, 170);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(120, 20);
            this.lblHarga.TabIndex = 3;
            this.lblHarga.Text = "Harga: -";
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(150, 220);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(100, 30);
            this.btnBayar.TabIndex = 4;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // FormKonsol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 270);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.listKonsol);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormKonsol";
            this.Text = "Daftar Konsol";
            this.Load += new System.EventHandler(this.FormKonsol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Add your logic here for the Kembali button click event
        }
    }
}
