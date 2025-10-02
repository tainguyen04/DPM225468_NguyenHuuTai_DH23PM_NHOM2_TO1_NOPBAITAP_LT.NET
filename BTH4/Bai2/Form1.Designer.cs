using System.Windows.Forms;
namespace Bai2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNhap;
        private Label lblKQ;
        private Button btnTaoMang;
        private Button btnInmang;
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
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.btnInmang = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(233, 22);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(88, 26);
            this.txtNhap.TabIndex = 0;
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblKQ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKQ.Location = new System.Drawing.Point(29, 69);
            this.lblKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(474, 49);
            this.lblKQ.TabIndex = 1;
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(329, 18);
            this.btnTaoMang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(174, 35);
            this.btnTaoMang.TabIndex = 2;
            this.btnTaoMang.Text = "Tạo mảng Random";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // btnInmang
            // 
            this.btnInmang.Location = new System.Drawing.Point(111, 131);
            this.btnInmang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInmang.Name = "btnInmang";
            this.btnInmang.Size = new System.Drawing.Size(112, 35);
            this.btnInmang.TabIndex = 3;
            this.btnInmang.Text = "In Mảng";
            this.btnInmang.UseVisualStyleBackColor = true;
            this.btnInmang.Click += new System.EventHandler(this.btnInmang_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(310, 131);
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
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập số phần tử mảng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInmang);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtNhap);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Bài 2 - Tạo mảng ngẫu nhiên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
    }
}