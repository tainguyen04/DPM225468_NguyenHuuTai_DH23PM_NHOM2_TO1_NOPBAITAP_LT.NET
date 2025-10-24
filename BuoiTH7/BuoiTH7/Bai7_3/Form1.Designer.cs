namespace Bai7_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnMoDanhSach;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnBatDau;
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
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnMoDanhSach = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // picAnh
            // 
            this.picAnh.Dock = System.Windows.Forms.DockStyle.Top;
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.Location = new System.Drawing.Point(0, 0);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(800, 450);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(50, 470);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(100, 30);
            this.btnTruoc.Text = "<< Trước";
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnMoDanhSach
            // 
            this.btnMoDanhSach.Location = new System.Drawing.Point(180, 470);
            this.btnMoDanhSach.Name = "btnMoDanhSach";
            this.btnMoDanhSach.Size = new System.Drawing.Size(150, 30);
            this.btnMoDanhSach.Text = "Mở danh sách hình";
            this.btnMoDanhSach.Click += new System.EventHandler(this.btnMoDanhSach_Click);
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(360, 470);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(100, 30);
            this.btnSau.Text = "Sau >>";
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(500, 470);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(100, 30);
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(620, 470);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnMoDanhSach);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.picAnh);
            this.Name = "Form1";
            this.Text = "Trình Xem Ảnh";
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
