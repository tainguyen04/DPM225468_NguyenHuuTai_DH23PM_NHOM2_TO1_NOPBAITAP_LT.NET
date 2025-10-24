namespace Bai3
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.labelKetQuaTuSo = new System.Windows.Forms.Label();
            this.txtKetQuaTuSo = new System.Windows.Forms.TextBox();
            this.labelKetQuaMauSo = new System.Windows.Forms.Label();
            this.txtKetQuaMauSo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTuSo2 = new System.Windows.Forms.Label();
            this.txtTuSo2 = new System.Windows.Forms.TextBox();
            this.labelMauSo2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMauSo2 = new System.Windows.Forms.TextBox();
            this.labelTuSo1 = new System.Windows.Forms.Label();
            this.txtTuSo1 = new System.Windows.Forms.TextBox();
            this.labelMauSo1 = new System.Windows.Forms.Label();
            this.txtMauSo1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(12, 19);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(70, 30);
            this.btnCong.TabIndex = 4;
            this.btnCong.Text = "Cộng";
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(92, 19);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(70, 30);
            this.btnTru.TabIndex = 5;
            this.btnTru.Text = "Trừ";
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(12, 76);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(70, 30);
            this.btnNhan.TabIndex = 6;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(92, 76);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(70, 30);
            this.btnChia.TabIndex = 7;
            this.btnChia.Text = "Chia";
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // labelKetQuaTuSo
            // 
            this.labelKetQuaTuSo.AutoSize = true;
            this.labelKetQuaTuSo.Location = new System.Drawing.Point(10, 25);
            this.labelKetQuaTuSo.Name = "labelKetQuaTuSo";
            this.labelKetQuaTuSo.Size = new System.Drawing.Size(36, 13);
            this.labelKetQuaTuSo.TabIndex = 0;
            this.labelKetQuaTuSo.Text = "Tử Số";
            // 
            // txtKetQuaTuSo
            // 
            this.txtKetQuaTuSo.Location = new System.Drawing.Point(70, 22);
            this.txtKetQuaTuSo.Name = "txtKetQuaTuSo";
            this.txtKetQuaTuSo.ReadOnly = true;
            this.txtKetQuaTuSo.Size = new System.Drawing.Size(60, 20);
            this.txtKetQuaTuSo.TabIndex = 1;
            // 
            // labelKetQuaMauSo
            // 
            this.labelKetQuaMauSo.AutoSize = true;
            this.labelKetQuaMauSo.Location = new System.Drawing.Point(10, 60);
            this.labelKetQuaMauSo.Name = "labelKetQuaMauSo";
            this.labelKetQuaMauSo.Size = new System.Drawing.Size(44, 13);
            this.labelKetQuaMauSo.TabIndex = 2;
            this.labelKetQuaMauSo.Text = "Mẫu Số";
            // 
            // txtKetQuaMauSo
            // 
            this.txtKetQuaMauSo.Location = new System.Drawing.Point(70, 57);
            this.txtKetQuaMauSo.Name = "txtKetQuaMauSo";
            this.txtKetQuaMauSo.ReadOnly = true;
            this.txtKetQuaMauSo.Size = new System.Drawing.Size(60, 20);
            this.txtKetQuaMauSo.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCong);
            this.groupBox4.Controls.Add(this.btnTru);
            this.groupBox4.Controls.Add(this.btnNhan);
            this.groupBox4.Controls.Add(this.btnChia);
            this.groupBox4.Location = new System.Drawing.Point(55, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 125);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phép tính";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Red;
            this.labelTitle.Location = new System.Drawing.Point(159, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(192, 24);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Phép Tính Phân Số";
            // 
            // labelTuSo2
            // 
            this.labelTuSo2.AutoSize = true;
            this.labelTuSo2.Location = new System.Drawing.Point(10, 25);
            this.labelTuSo2.Name = "labelTuSo2";
            this.labelTuSo2.Size = new System.Drawing.Size(36, 13);
            this.labelTuSo2.TabIndex = 0;
            this.labelTuSo2.Text = "Tử Số";
            // 
            // txtTuSo2
            // 
            this.txtTuSo2.Location = new System.Drawing.Point(70, 22);
            this.txtTuSo2.Name = "txtTuSo2";
            this.txtTuSo2.Size = new System.Drawing.Size(60, 20);
            this.txtTuSo2.TabIndex = 1;
            // 
            // labelMauSo2
            // 
            this.labelMauSo2.AutoSize = true;
            this.labelMauSo2.Location = new System.Drawing.Point(10, 60);
            this.labelMauSo2.Name = "labelMauSo2";
            this.labelMauSo2.Size = new System.Drawing.Size(44, 13);
            this.labelMauSo2.TabIndex = 2;
            this.labelMauSo2.Text = "Mẫu Số";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTuSo2);
            this.groupBox2.Controls.Add(this.txtTuSo2);
            this.groupBox2.Controls.Add(this.labelMauSo2);
            this.groupBox2.Controls.Add(this.txtMauSo2);
            this.groupBox2.Location = new System.Drawing.Point(306, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phân số 2";
            // 
            // txtMauSo2
            // 
            this.txtMauSo2.Location = new System.Drawing.Point(70, 57);
            this.txtMauSo2.Name = "txtMauSo2";
            this.txtMauSo2.Size = new System.Drawing.Size(60, 20);
            this.txtMauSo2.TabIndex = 3;
            // 
            // labelTuSo1
            // 
            this.labelTuSo1.AutoSize = true;
            this.labelTuSo1.Location = new System.Drawing.Point(10, 25);
            this.labelTuSo1.Name = "labelTuSo1";
            this.labelTuSo1.Size = new System.Drawing.Size(36, 13);
            this.labelTuSo1.TabIndex = 0;
            this.labelTuSo1.Text = "Tử Số";
            // 
            // txtTuSo1
            // 
            this.txtTuSo1.Location = new System.Drawing.Point(70, 22);
            this.txtTuSo1.Name = "txtTuSo1";
            this.txtTuSo1.Size = new System.Drawing.Size(60, 20);
            this.txtTuSo1.TabIndex = 1;
            // 
            // labelMauSo1
            // 
            this.labelMauSo1.AutoSize = true;
            this.labelMauSo1.Location = new System.Drawing.Point(10, 60);
            this.labelMauSo1.Name = "labelMauSo1";
            this.labelMauSo1.Size = new System.Drawing.Size(44, 13);
            this.labelMauSo1.TabIndex = 2;
            this.labelMauSo1.Text = "Mẫu Số";
            // 
            // txtMauSo1
            // 
            this.txtMauSo1.Location = new System.Drawing.Point(70, 57);
            this.txtMauSo1.Name = "txtMauSo1";
            this.txtMauSo1.Size = new System.Drawing.Size(60, 20);
            this.txtMauSo1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTuSo1);
            this.groupBox1.Controls.Add(this.txtTuSo1);
            this.groupBox1.Controls.Add(this.labelMauSo1);
            this.groupBox1.Controls.Add(this.txtMauSo1);
            this.groupBox1.Location = new System.Drawing.Point(55, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân số 1";
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(180, 324);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(70, 30);
            this.btnTiepTuc.TabIndex = 15;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(260, 324);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(70, 30);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelKetQuaTuSo);
            this.groupBox3.Controls.Add(this.txtKetQuaTuSo);
            this.groupBox3.Controls.Add(this.labelKetQuaMauSo);
            this.groupBox3.Controls.Add(this.txtKetQuaMauSo);
            this.groupBox3.Location = new System.Drawing.Point(306, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả cộng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 384);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Label labelKetQuaTuSo;
        private System.Windows.Forms.TextBox txtKetQuaTuSo;
        private System.Windows.Forms.Label labelKetQuaMauSo;
        private System.Windows.Forms.TextBox txtKetQuaMauSo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTuSo2;
        private System.Windows.Forms.TextBox txtTuSo2;
        private System.Windows.Forms.Label labelMauSo2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMauSo2;
        private System.Windows.Forms.Label labelTuSo1;
        private System.Windows.Forms.TextBox txtTuSo1;
        private System.Windows.Forms.Label labelMauSo1;
        private System.Windows.Forms.TextBox txtMauSo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}