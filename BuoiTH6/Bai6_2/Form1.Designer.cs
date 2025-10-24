namespace Bai6_2
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
            this.labelHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.rdLopA = new System.Windows.Forms.RadioButton();
            this.rdLopB = new System.Windows.Forms.RadioButton();
            this.labelLopA = new System.Windows.Forms.Label();
            this.labelLopB = new System.Windows.Forms.Label();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.btnChuyenMot = new System.Windows.Forms.Button();
            this.btnChuyenMotBack = new System.Windows.Forms.Button();
            this.btnChuyenAll = new System.Windows.Forms.Button();
            this.btnChuyenAllBack = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Text = "DANH SÁCH SINH VIÊN";
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTitle.Location = new System.Drawing.Point(230, 10);
            this.labelTitle.Size = new System.Drawing.Size(350, 40);
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHoTen
            // 
            this.labelHoTen.Text = "Họ tên:";
            this.labelHoTen.Location = new System.Drawing.Point(20, 60);
            this.labelHoTen.Size = new System.Drawing.Size(80, 20);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(100, 58);
            this.txtHoTen.Size = new System.Drawing.Size(350, 22);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(470, 55);
            this.btnThem.Size = new System.Drawing.Size(80, 26);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rdLopA
            // 
            this.rdLopA.Location = new System.Drawing.Point(580, 50);
            this.rdLopA.Text = "Lớp A";
            this.rdLopA.Checked = true;
            // 
            // rdLopB
            // 
            this.rdLopB.Location = new System.Drawing.Point(650, 50);
            this.rdLopB.Text = "Lớp B";
            // 
            // labelLopA
            // 
            this.labelLopA.Text = "Lớp A";
            this.labelLopA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelLopA.Location = new System.Drawing.Point(80, 95);
            this.labelLopA.Size = new System.Drawing.Size(100, 25);
            // 
            // labelLopB
            // 
            this.labelLopB.Text = "Lớp B";
            this.labelLopB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelLopB.Location = new System.Drawing.Point(590, 95);
            this.labelLopB.Size = new System.Drawing.Size(100, 25);
            // 
            // lstLopA
            // 
            this.lstLopA.Location = new System.Drawing.Point(20, 120);
            this.lstLopA.Size = new System.Drawing.Size(240, 240);
            // 
            // lstLopB
            // 
            this.lstLopB.Location = new System.Drawing.Point(520, 120);
            this.lstLopB.Size = new System.Drawing.Size(240, 240);
            // 
            // btnChuyenMot
            // 
            this.btnChuyenMot.Location = new System.Drawing.Point(300, 160);
            this.btnChuyenMot.Size = new System.Drawing.Size(60, 30);
            this.btnChuyenMot.Text = ">";
            this.btnChuyenMot.Click += new System.EventHandler(this.btnChuyenMot_Click);
            // 
            // btnChuyenMotBack
            // 
            this.btnChuyenMotBack.Location = new System.Drawing.Point(300, 200);
            this.btnChuyenMotBack.Size = new System.Drawing.Size(60, 30);
            this.btnChuyenMotBack.Text = "<";
            this.btnChuyenMotBack.Click += new System.EventHandler(this.btnChuyenMotBack_Click);
            // 
            // btnChuyenAll
            // 
            this.btnChuyenAll.Location = new System.Drawing.Point(300, 240);
            this.btnChuyenAll.Size = new System.Drawing.Size(60, 30);
            this.btnChuyenAll.Text = ">>";
            this.btnChuyenAll.Click += new System.EventHandler(this.btnChuyenAll_Click);
            // 
            // btnChuyenAllBack
            // 
            this.btnChuyenAllBack.Location = new System.Drawing.Point(300, 280);
            this.btnChuyenAllBack.Size = new System.Drawing.Size(60, 30);
            this.btnChuyenAllBack.Text = "<<";
            this.btnChuyenAllBack.Click += new System.EventHandler(this.btnChuyenAllBack_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(120, 380);
            this.btnTong.Size = new System.Drawing.Size(200, 36);
            this.btnTong.Text = "Tổng số sinh viên";
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(520, 380);
            this.btnThoat.Size = new System.Drawing.Size(80, 36);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.rdLopA);
            this.Controls.Add(this.rdLopB);
            this.Controls.Add(this.labelLopA);
            this.Controls.Add(this.labelLopB);
            this.Controls.Add(this.lstLopA);
            this.Controls.Add(this.lstLopB);
            this.Controls.Add(this.btnChuyenMot);
            this.Controls.Add(this.btnChuyenMotBack);
            this.Controls.Add(this.btnChuyenAll);
            this.Controls.Add(this.btnChuyenAllBack);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnThoat);
            this.Text = "Danh sách sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rdLopA;
        private System.Windows.Forms.RadioButton rdLopB;
        private System.Windows.Forms.Label labelLopA;
        private System.Windows.Forms.Label labelLopB;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.ListBox lstLopB;
        private System.Windows.Forms.Button btnChuyenMot;
        private System.Windows.Forms.Button btnChuyenMotBack;
        private System.Windows.Forms.Button btnChuyenAll;
        private System.Windows.Forms.Button btnChuyenAllBack;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnThoat;
    }
}
