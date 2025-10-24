namespace Bai6_3
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMa = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelLop = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Text = "DANH SÁCH SINH VIÊN";
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Red;
            this.labelTitle.Location = new System.Drawing.Point(250, 10);
            this.labelTitle.Size = new System.Drawing.Size(350, 40);
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMa
            // 
            this.labelMa.Text = "Mã SV:";
            this.labelMa.Location = new System.Drawing.Point(40, 70);
            this.labelMa.Size = new System.Drawing.Size(80, 20);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(120, 68);
            this.txtMa.Size = new System.Drawing.Size(200, 22);
            // 
            // labelHoTen
            // 
            this.labelHoTen.Text = "Họ tên:";
            this.labelHoTen.Location = new System.Drawing.Point(40, 100);
            this.labelHoTen.Size = new System.Drawing.Size(80, 20);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(120, 98);
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.Text = "Địa chỉ:";
            this.labelDiaChi.Location = new System.Drawing.Point(40, 130);
            this.labelDiaChi.Size = new System.Drawing.Size(80, 20);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(120, 128);
            this.txtDiaChi.Size = new System.Drawing.Size(200, 22);
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.Text = "Ngày sinh:";
            this.labelNgaySinh.Location = new System.Drawing.Point(40, 160);
            this.labelNgaySinh.Size = new System.Drawing.Size(80, 20);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 158);
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 22);
            // 
            // labelLop
            // 
            this.labelLop.Text = "Lớp:";
            this.labelLop.Location = new System.Drawing.Point(40, 190);
            this.labelLop.Size = new System.Drawing.Size(80, 20);
            // 
            // cbLop
            // 
            this.cbLop.Location = new System.Drawing.Point(120, 188);
            this.cbLop.Size = new System.Drawing.Size(150, 24);
            this.cbLop.Items.AddRange(new object[] { "Lớp A", "Lớp B", "Lớp C" });
            this.cbLop.SelectedIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(400, 80);
            this.btnThem.Size = new System.Drawing.Size(100, 36);
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(400, 130);
            this.btnXoa.Size = new System.Drawing.Size(100, 36);
            this.btnXoa.Text = "Xóa Item";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(400, 180);
            this.btnThoat.Size = new System.Drawing.Size(100, 36);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(40, 240);
            this.dataGridView1.Size = new System.Drawing.Size(720, 220);
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMa, this.colTen, this.colDiaChi, this.colNgay, this.colLop});
            // 
            // Columns
            // 
            this.colMa.HeaderText = "Mã SV";
            this.colTen.HeaderText = "Họ và tên";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colNgay.HeaderText = "Ngày sinh";
            this.colLop.HeaderText = "Lớp";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelMa);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.labelHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelLop);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridView1);
            this.Text = "Danh sách sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMa;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelLop;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLop;
    }
}
