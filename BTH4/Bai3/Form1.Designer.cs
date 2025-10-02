using System.Windows.Forms;
namespace Bai3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNhap;
        private Button btnTaoMang;
        private Button btnSum;
        private Button btnMax;
        private Button btnThoat;

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
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(237, 23);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(101, 26);
            this.txtNhap.TabIndex = 0;
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(344, 19);
            this.btnTaoMang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(160, 35);
            this.btnTaoMang.TabIndex = 1;
            this.btnTaoMang.Text = "Tạo mảng Random";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(77, 77);
            this.btnSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(112, 35);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "Tính tổng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(226, 77);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(112, 35);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "Số lớn nhất";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(384, 77);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 35);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập số phần tử mảng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 152);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.txtNhap);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Bài 3 - Ứng dụng đa form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
    }
}

