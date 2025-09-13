namespace Bai2._10
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
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinhDuongCheo = new System.Windows.Forms.Button();
            this.btnTinhDienTich = new System.Windows.Forms.Button();
            this.btnTinhChuVi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoThuHai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoThuNhat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(298, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 138);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(51, 79);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(107, 20);
            this.txtSoThuHai.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "b:";
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(51, 32);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(107, 20);
            this.txtSoThuNhat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "a:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(600, 330);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 52);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "HÌNH CHỮ NHẬT";
            // 
            // btnTinhDuongCheo
            // 
            this.btnTinhDuongCheo.Location = new System.Drawing.Point(421, 330);
            this.btnTinhDuongCheo.Name = "btnTinhDuongCheo";
            this.btnTinhDuongCheo.Size = new System.Drawing.Size(137, 52);
            this.btnTinhDuongCheo.TabIndex = 26;
            this.btnTinhDuongCheo.Text = "Đường chéo";
            this.btnTinhDuongCheo.UseVisualStyleBackColor = true;
            this.btnTinhDuongCheo.Click += new System.EventHandler(this.btnTinhDuongCheo_Click);
            // 
            // btnTinhDienTich
            // 
            this.btnTinhDienTich.Location = new System.Drawing.Point(251, 330);
            this.btnTinhDienTich.Name = "btnTinhDienTich";
            this.btnTinhDienTich.Size = new System.Drawing.Size(137, 52);
            this.btnTinhDienTich.TabIndex = 25;
            this.btnTinhDienTich.Text = "Diện tích";
            this.btnTinhDienTich.UseVisualStyleBackColor = true;
            this.btnTinhDienTich.Click += new System.EventHandler(this.btnTinhDienTich_Click);
            // 
            // btnTinhChuVi
            // 
            this.btnTinhChuVi.Location = new System.Drawing.Point(64, 330);
            this.btnTinhChuVi.Name = "btnTinhChuVi";
            this.btnTinhChuVi.Size = new System.Drawing.Size(137, 52);
            this.btnTinhChuVi.TabIndex = 24;
            this.btnTinhChuVi.Text = "Chu vi";
            this.btnTinhChuVi.UseVisualStyleBackColor = true;
            this.btnTinhChuVi.Click += new System.EventHandler(this.btnTinhChuVi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTinhDuongCheo);
            this.Controls.Add(this.btnTinhDienTich);
            this.Controls.Add(this.btnTinhChuVi);
            this.Name = "Form1";
            this.Text = "Bai2.10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinhDuongCheo;
        private System.Windows.Forms.Button btnTinhDienTich;
        private System.Windows.Forms.Button btnTinhChuVi;
    }
}

