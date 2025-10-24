namespace Bai7_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;

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
            this.lblTien = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(200, 10);
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.Text = "Chọn vị trí ghế";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTien
            // 
            this.lblTien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTien.Location = new System.Drawing.Point(100, 280);
            this.lblTien.Size = new System.Drawing.Size(100, 30);
            this.lblTien.Text = "Thành tiền:";
            this.lblTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblThanhTien.Location = new System.Drawing.Point(210, 280);
            this.lblThanhTien.Size = new System.Drawing.Size(200, 30);
            this.lblThanhTien.Text = "0 VND";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(150, 320);
            this.btnChon.Size = new System.Drawing.Size(100, 30);
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(280, 320);
            this.btnHuy.Size = new System.Drawing.Size(100, 30);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(410, 320);
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(650, 380);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lblTien);
            this.Controls.Add(this.lblTitle);
            this.Text = "Vé xe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }
    }
}
