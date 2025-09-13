namespace Bai2._5
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.btnTinhHieu = new System.Windows.Forms.Button();
            this.btnTinhNhan = new System.Windows.Forms.Button();
            this.btnTinhChia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÉP TOÁN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoThuHai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoThuNhat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(287, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 138);
            this.groupBox1.TabIndex = 1;
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
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(53, 276);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(137, 52);
            this.btnTinhTong.TabIndex = 2;
            this.btnTinhTong.Text = "Tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // btnTinhHieu
            // 
            this.btnTinhHieu.Location = new System.Drawing.Point(240, 276);
            this.btnTinhHieu.Name = "btnTinhHieu";
            this.btnTinhHieu.Size = new System.Drawing.Size(137, 52);
            this.btnTinhHieu.TabIndex = 3;
            this.btnTinhHieu.Text = "Hiệu";
            this.btnTinhHieu.UseVisualStyleBackColor = true;
            this.btnTinhHieu.Click += new System.EventHandler(this.btnTinhHieu_Click);
            // 
            // btnTinhNhan
            // 
            this.btnTinhNhan.Location = new System.Drawing.Point(410, 276);
            this.btnTinhNhan.Name = "btnTinhNhan";
            this.btnTinhNhan.Size = new System.Drawing.Size(137, 52);
            this.btnTinhNhan.TabIndex = 4;
            this.btnTinhNhan.Text = "Nhân";
            this.btnTinhNhan.UseVisualStyleBackColor = true;
            this.btnTinhNhan.Click += new System.EventHandler(this.btnTinhNhan_Click);
            // 
            // btnTinhChia
            // 
            this.btnTinhChia.Location = new System.Drawing.Point(589, 276);
            this.btnTinhChia.Name = "btnTinhChia";
            this.btnTinhChia.Size = new System.Drawing.Size(137, 52);
            this.btnTinhChia.TabIndex = 5;
            this.btnTinhChia.Text = "Chia";
            this.btnTinhChia.UseVisualStyleBackColor = true;
            this.btnTinhChia.Click += new System.EventHandler(this.btnTinhChia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinhChia);
            this.Controls.Add(this.btnTinhNhan);
            this.Controls.Add(this.btnTinhHieu);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai2.5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button btnTinhHieu;
        private System.Windows.Forms.Button btnTinhNhan;
        private System.Windows.Forms.Button btnTinhChia;
    }
}

