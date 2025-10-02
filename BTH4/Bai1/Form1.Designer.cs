using System.Windows.Forms;

namespace Bai1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNhap;
        private Label lblKQ;
        private Button btnNhap;
        private Button btnIn;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnSXGiam;
        private Button btnSXTang;
        private Button btnDemSoChan;
        private Button btnDemSoLe;
        private Button btnSoNguyenTo;
        private Button btnSHH;
        private Button btnSum;
        private Button btnUCLN;
        private Button btnTBMang;
        private Button btnMin;
        private Button btnMax;

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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSXTang = new System.Windows.Forms.Button();
            this.btnSXGiam = new System.Windows.Forms.Button();
            this.btnDemSoChan = new System.Windows.Forms.Button();
            this.btnDemSoLe = new System.Windows.Forms.Button();
            this.btnSoNguyenTo = new System.Windows.Forms.Button();
            this.btnSHH = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnUCLN = new System.Windows.Forms.Button();
            this.btnTBMang = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(229, 14);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(127, 26);
            this.txtNhap.TabIndex = 0;
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblKQ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKQ.Location = new System.Drawing.Point(93, 56);
            this.lblKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(511, 95);
            this.lblKQ.TabIndex = 1;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(93, 10);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(128, 35);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập 1 phần tử";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(364, 10);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(112, 35);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In Mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(484, 10);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 35);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(619, 10);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 35);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSXTang
            // 
            this.btnSXTang.Location = new System.Drawing.Point(619, 101);
            this.btnSXTang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSXTang.Name = "btnSXTang";
            this.btnSXTang.Size = new System.Drawing.Size(129, 35);
            this.btnSXTang.TabIndex = 6;
            this.btnSXTang.Text = "Sắp xếp tăng";
            this.btnSXTang.UseVisualStyleBackColor = true;
            this.btnSXTang.Click += new System.EventHandler(this.btnSXTang_Click);
            // 
            // btnSXGiam
            // 
            this.btnSXGiam.Location = new System.Drawing.Point(619, 56);
            this.btnSXGiam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSXGiam.Name = "btnSXGiam";
            this.btnSXGiam.Size = new System.Drawing.Size(129, 35);
            this.btnSXGiam.TabIndex = 7;
            this.btnSXGiam.Text = "Sắp xếp giảm";
            this.btnSXGiam.UseVisualStyleBackColor = true;
            this.btnSXGiam.Click += new System.EventHandler(this.btnSXGiam_Click);
            // 
            // btnDemSoChan
            // 
            this.btnDemSoChan.Location = new System.Drawing.Point(93, 156);
            this.btnDemSoChan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDemSoChan.Name = "btnDemSoChan";
            this.btnDemSoChan.Size = new System.Drawing.Size(128, 35);
            this.btnDemSoChan.TabIndex = 8;
            this.btnDemSoChan.Text = "Đếm Chẵn";
            this.btnDemSoChan.UseVisualStyleBackColor = true;
            this.btnDemSoChan.Click += new System.EventHandler(this.btnDemSoChan_Click);
            // 
            // btnDemSoLe
            // 
            this.btnDemSoLe.Location = new System.Drawing.Point(229, 156);
            this.btnDemSoLe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDemSoLe.Name = "btnDemSoLe";
            this.btnDemSoLe.Size = new System.Drawing.Size(112, 35);
            this.btnDemSoLe.TabIndex = 9;
            this.btnDemSoLe.Text = "Đếm Lẻ";
            this.btnDemSoLe.UseVisualStyleBackColor = true;
            this.btnDemSoLe.Click += new System.EventHandler(this.btnDemSoLe_Click);
            // 
            // btnSoNguyenTo
            // 
            this.btnSoNguyenTo.Location = new System.Drawing.Point(349, 156);
            this.btnSoNguyenTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSoNguyenTo.Name = "btnSoNguyenTo";
            this.btnSoNguyenTo.Size = new System.Drawing.Size(127, 35);
            this.btnSoNguyenTo.TabIndex = 10;
            this.btnSoNguyenTo.Text = "Số nguyên tố";
            this.btnSoNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoNguyenTo.Click += new System.EventHandler(this.btnSoNguyenTo_Click);
            // 
            // btnSHH
            // 
            this.btnSHH.Location = new System.Drawing.Point(484, 156);
            this.btnSHH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSHH.Name = "btnSHH";
            this.btnSHH.Size = new System.Drawing.Size(120, 35);
            this.btnSHH.TabIndex = 11;
            this.btnSHH.Text = "Số Hoàn Hảo";
            this.btnSHH.UseVisualStyleBackColor = true;
            this.btnSHH.Click += new System.EventHandler(this.btnSHH_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(619, 156);
            this.btnSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(129, 35);
            this.btnSum.TabIndex = 12;
            this.btnSum.Text = "Tổng mảng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnUCLN
            // 
            this.btnUCLN.Location = new System.Drawing.Point(93, 213);
            this.btnUCLN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUCLN.Name = "btnUCLN";
            this.btnUCLN.Size = new System.Drawing.Size(236, 35);
            this.btnUCLN.TabIndex = 13;
            this.btnUCLN.Text = "UCLN 2 phần tử đầu tiên";
            this.btnUCLN.UseVisualStyleBackColor = true;
            this.btnUCLN.Click += new System.EventHandler(this.btnUCLN_Click);
            // 
            // btnTBMang
            // 
            this.btnTBMang.Location = new System.Drawing.Point(337, 213);
            this.btnTBMang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTBMang.Name = "btnTBMang";
            this.btnTBMang.Size = new System.Drawing.Size(139, 35);
            this.btnTBMang.TabIndex = 14;
            this.btnTBMang.Text = "Trung bình mảng";
            this.btnTBMang.UseVisualStyleBackColor = true;
            this.btnTBMang.Click += new System.EventHandler(this.btnTBMang_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(484, 213);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(120, 35);
            this.btnMin.TabIndex = 15;
            this.btnMin.Text = "Số nhỏ nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(619, 212);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(129, 35);
            this.btnMax.TabIndex = 16;
            this.btnMax.Text = "Số lớn nhất";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 282);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnTBMang);
            this.Controls.Add(this.btnUCLN);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnSHH);
            this.Controls.Add(this.btnSoNguyenTo);
            this.Controls.Add(this.btnDemSoLe);
            this.Controls.Add(this.btnDemSoChan);
            this.Controls.Add(this.btnSXGiam);
            this.Controls.Add(this.btnSXTang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtNhap);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Bài 1 - Quản lý mảng số nguyên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
