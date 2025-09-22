namespace Bai6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhapChuoi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lsbNhapChuoi = new System.Windows.Forms.ListBox();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.btnChonMauChu = new System.Windows.Forms.Button();
            this.btnChonFont = new System.Windows.Forms.Button();
            this.btnChonMauNen = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhapChuoi);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập chuỗi";
            // 
            // txtNhapChuoi
            // 
            this.txtNhapChuoi.Location = new System.Drawing.Point(10, 19);
            this.txtNhapChuoi.Name = "txtNhapChuoi";
            this.txtNhapChuoi.Size = new System.Drawing.Size(152, 20);
            this.txtNhapChuoi.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(23, 85);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(121, 85);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lsbNhapChuoi
            // 
            this.lsbNhapChuoi.FormattingEnabled = true;
            this.lsbNhapChuoi.Location = new System.Drawing.Point(23, 129);
            this.lsbNhapChuoi.Name = "lsbNhapChuoi";
            this.lsbNhapChuoi.Size = new System.Drawing.Size(172, 121);
            this.lsbNhapChuoi.TabIndex = 3;
            this.lsbNhapChuoi.SelectedIndexChanged += new System.EventHandler(this.lsbNhapChuoi_SelectedIndexChanged);
            // 
            // txtHienThi
            // 
            this.txtHienThi.Location = new System.Drawing.Point(217, 23);
            this.txtHienThi.Multiline = true;
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.Size = new System.Drawing.Size(344, 118);
            this.txtHienThi.TabIndex = 1;
            // 
            // btnChonMauChu
            // 
            this.btnChonMauChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonMauChu.Location = new System.Drawing.Point(217, 164);
            this.btnChonMauChu.Name = "btnChonMauChu";
            this.btnChonMauChu.Size = new System.Drawing.Size(106, 34);
            this.btnChonMauChu.TabIndex = 4;
            this.btnChonMauChu.Text = "Chọn màu chữ";
            this.btnChonMauChu.UseVisualStyleBackColor = true;
            this.btnChonMauChu.Click += new System.EventHandler(this.btnChonMauChu_Click);
            // 
            // btnChonFont
            // 
            this.btnChonFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonFont.Location = new System.Drawing.Point(455, 164);
            this.btnChonFont.Name = "btnChonFont";
            this.btnChonFont.Size = new System.Drawing.Size(106, 34);
            this.btnChonFont.TabIndex = 5;
            this.btnChonFont.Text = "Chọn Font";
            this.btnChonFont.UseVisualStyleBackColor = true;
            this.btnChonFont.Click += new System.EventHandler(this.btnChonFont_Click);
            // 
            // btnChonMauNen
            // 
            this.btnChonMauNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonMauNen.Location = new System.Drawing.Point(335, 164);
            this.btnChonMauNen.Name = "btnChonMauNen";
            this.btnChonMauNen.Size = new System.Drawing.Size(106, 34);
            this.btnChonMauNen.TabIndex = 6;
            this.btnChonMauNen.Text = "Chọn màu nền";
            this.btnChonMauNen.UseVisualStyleBackColor = true;
            this.btnChonMauNen.Click += new System.EventHandler(this.btnChonMauNen_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(351, 216);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 34);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 260);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnChonMauNen);
            this.Controls.Add(this.btnChonFont);
            this.Controls.Add(this.btnChonMauChu);
            this.Controls.Add(this.txtHienThi);
            this.Controls.Add(this.lsbNhapChuoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhapChuoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox lsbNhapChuoi;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.Button btnChonMauChu;
        private System.Windows.Forms.Button btnChonFont;
        private System.Windows.Forms.Button btnChonMauNen;
        private System.Windows.Forms.Button btnDong;
    }
}

