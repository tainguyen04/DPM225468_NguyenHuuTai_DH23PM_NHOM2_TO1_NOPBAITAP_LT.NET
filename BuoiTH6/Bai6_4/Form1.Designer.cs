namespace Bai6_4
{
    partial class Form1
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
            this.labelMaSV = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelPhai = new System.Windows.Forms.Label();
            this.labelDienThoai = new System.Windows.Forms.Label();
            this.labelQueQuan = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.cbQueQuan = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Text = "QUẢN LÝ SINH VIÊN";
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Blue;
            this.labelTitle.Location = new System.Drawing.Point(220, 10);
            this.labelTitle.Size = new System.Drawing.Size(400, 40);
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaSV
            // 
            this.labelMaSV.Text = "Mã SV:";
            this.labelMaSV.Location = new System.Drawing.Point(40, 70);
            this.labelMaSV.Size = new System.Drawing.Size(80, 20);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(120, 68);
            this.txtMa.Size = new System.Drawing.Size(180, 22);
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
            this.txtHoTen.Size = new System.Drawing.Size(250, 22);
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.Text = "Ngày sinh:";
            this.labelNgaySinh.Location = new System.Drawing.Point(40, 130);
            this.labelNgaySinh.Size = new System.Drawing.Size(80, 20);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 128);
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 22);
            // 
            // labelPhai
            // 
            this.labelPhai.Text = "Phái:";
            this.labelPhai.Location = new System.Drawing.Point(400, 70);
            this.labelPhai.Size = new System.Drawing.Size(50, 20);
            // 
            // rdNam
            // 
            this.rdNam.Location = new System.Drawing.Point(460, 68);
            this.rdNam.Text = "Nam";
            this.rdNam.Checked = true;
            // 
            // rdNu
            // 
            this.rdNu.Location = new System.Drawing.Point(520, 68);
            this.rdNu.Text = "Nữ";
            // 
            // labelDienThoai
            // 
            this.labelDienThoai.Text = "Điện thoại:";
            this.labelDienThoai.Location = new System.Drawing.Point(400, 100);
            this.labelDienThoai.Size = new System.Drawing.Size(80, 20);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(480, 98);
            this.txtDienThoai.Size = new System.Drawing.Size(200, 22);
            // 
            // labelQueQuan
            // 
            this.labelQueQuan.Text = "Quê quán:";
            this.labelQueQuan.Location = new System.Drawing.Point(400, 130);
            this.labelQueQuan.Size = new System.Drawing.Size(80, 20);
            // 
            // cbQueQuan
            // 
            this.cbQueQuan.Location = new System.Drawing.Point(480, 128);
            this.cbQueQuan.Size = new System.Drawing.Size(180, 24);
            this.cbQueQuan.Items.AddRange(new object[] { "Cần Thơ", "Tiền Giang", "An Giang", "Vĩnh Long" });
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(120, 170);
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(220, 170);
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(320, 170);
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(420, 170);
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(40, 220);
            this.dataGridView1.Size = new System.Drawing.Size(720, 250);
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMa, this.colHoTen, this.colNgay, this.colPhai, this.colDT, this.colQue});
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Columns
            // 
            this.colMa.HeaderText = "Mã SV";
            this.colHoTen.HeaderText = "Họ tên";
            this.colNgay.HeaderText = "Ngày sinh";
            this.colPhai.HeaderText = "Phái";
            this.colDT.HeaderText = "Điện thoại";
            this.colQue.HeaderText = "Quê quán";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelMaSV);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.labelHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelPhai);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.labelDienThoai);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.labelQueQuan);
            this.Controls.Add(this.cbQueQuan);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridView1);
            this.Text = "Quản lý sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMaSV;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelPhai;
        private System.Windows.Forms.Label labelDienThoai;
        private System.Windows.Forms.Label labelQueQuan;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.ComboBox cbQueQuan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQue;
    }
}
