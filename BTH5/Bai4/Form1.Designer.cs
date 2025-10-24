namespace Bai4
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
            this.rdbHCN = new System.Windows.Forms.RadioButton();
            this.rdbHV = new System.Windows.Forms.RadioButton();
            this.rdbHTG = new System.Windows.Forms.RadioButton();
            this.rdbHT = new System.Windows.Forms.RadioButton();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbHinhTron = new System.Windows.Forms.GroupBox();
            this.grHCN = new System.Windows.Forms.GroupBox();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDTHCN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCVHCN = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDai = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDTHT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCVHT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbHinhVuong = new System.Windows.Forms.GroupBox();
            this.txtDTHV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCVHV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCanh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grHTG = new System.Windows.Forms.GroupBox();
            this.txtCanh3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCanh2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDTHTG = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCVHTG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCanh1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbHinhTron.SuspendLayout();
            this.grHCN.SuspendLayout();
            this.gbHinhVuong.SuspendLayout();
            this.grHTG.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbHCN);
            this.groupBox1.Controls.Add(this.rdbHV);
            this.groupBox1.Controls.Add(this.rdbHTG);
            this.groupBox1.Controls.Add(this.rdbHT);
            this.groupBox1.Location = new System.Drawing.Point(55, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rdbHCN
            // 
            this.rdbHCN.AutoSize = true;
            this.rdbHCN.Location = new System.Drawing.Point(154, 52);
            this.rdbHCN.Name = "rdbHCN";
            this.rdbHCN.Size = new System.Drawing.Size(95, 17);
            this.rdbHCN.TabIndex = 3;
            this.rdbHCN.TabStop = true;
            this.rdbHCN.Text = "Hình Chữ Nhật";
            this.rdbHCN.UseVisualStyleBackColor = true;
            this.rdbHCN.CheckedChanged += new System.EventHandler(this.RadioButton_Changed);
            // 
            // rdbHV
            // 
            this.rdbHV.AutoSize = true;
            this.rdbHV.Location = new System.Drawing.Point(26, 49);
            this.rdbHV.Name = "rdbHV";
            this.rdbHV.Size = new System.Drawing.Size(81, 17);
            this.rdbHV.TabIndex = 2;
            this.rdbHV.TabStop = true;
            this.rdbHV.Text = "Hình Vuông";
            this.rdbHV.UseVisualStyleBackColor = true;
            this.rdbHV.CheckedChanged += new System.EventHandler(this.RadioButton_Changed);
            // 
            // rdbHTG
            // 
            this.rdbHTG.AutoSize = true;
            this.rdbHTG.Location = new System.Drawing.Point(154, 26);
            this.rdbHTG.Name = "rdbHTG";
            this.rdbHTG.Size = new System.Drawing.Size(96, 17);
            this.rdbHTG.TabIndex = 1;
            this.rdbHTG.TabStop = true;
            this.rdbHTG.Text = "Hình Tam Giác";
            this.rdbHTG.UseVisualStyleBackColor = true;
            this.rdbHTG.CheckedChanged += new System.EventHandler(this.RadioButton_Changed);
            // 
            // rdbHT
            // 
            this.rdbHT.AutoSize = true;
            this.rdbHT.Location = new System.Drawing.Point(26, 26);
            this.rdbHT.Name = "rdbHT";
            this.rdbHT.Size = new System.Drawing.Size(72, 17);
            this.rdbHT.TabIndex = 0;
            this.rdbHT.TabStop = true;
            this.rdbHT.Text = "Hình Tròn";
            this.rdbHT.UseVisualStyleBackColor = true;
            this.rdbHT.CheckedChanged += new System.EventHandler(this.RadioButton_Changed);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(57, 250);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(75, 23);
            this.btnThucHien.TabIndex = 1;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(157, 250);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(263, 250);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(64, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm Chu Vi và Diện Tích";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(65, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "     Hình Tròn - Hình Vuông\r\nHình Tam Giác - Hình Chữ Nhật\r\n";
            // 
            // gbHinhTron
            // 
            this.gbHinhTron.Controls.Add(this.txtDTHT);
            this.gbHinhTron.Controls.Add(this.label5);
            this.gbHinhTron.Controls.Add(this.txtCVHT);
            this.gbHinhTron.Controls.Add(this.label4);
            this.gbHinhTron.Controls.Add(this.txtBanKinh);
            this.gbHinhTron.Controls.Add(this.label3);
            this.gbHinhTron.Location = new System.Drawing.Point(12, 293);
            this.gbHinhTron.Name = "gbHinhTron";
            this.gbHinhTron.Size = new System.Drawing.Size(257, 166);
            this.gbHinhTron.TabIndex = 6;
            this.gbHinhTron.TabStop = false;
            this.gbHinhTron.Text = "Hình Tròn";
            this.gbHinhTron.Visible = false;
            // 
            // grHCN
            // 
            this.grHCN.Controls.Add(this.txtRong);
            this.grHCN.Controls.Add(this.label17);
            this.grHCN.Controls.Add(this.txtDTHCN);
            this.grHCN.Controls.Add(this.label14);
            this.grHCN.Controls.Add(this.txtCVHCN);
            this.grHCN.Controls.Add(this.label15);
            this.grHCN.Controls.Add(this.txtDai);
            this.grHCN.Controls.Add(this.label16);
            this.grHCN.Location = new System.Drawing.Point(12, 290);
            this.grHCN.Name = "grHCN";
            this.grHCN.Size = new System.Drawing.Size(257, 166);
            this.grHCN.TabIndex = 8;
            this.grHCN.TabStop = false;
            this.grHCN.Text = "Hình Chữ Nhật";
            this.grHCN.Visible = false;
            // 
            // txtRong
            // 
            this.txtRong.Location = new System.Drawing.Point(74, 49);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(104, 20);
            this.txtRong.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Rộng:";
            // 
            // txtDTHCN
            // 
            this.txtDTHCN.Location = new System.Drawing.Point(74, 106);
            this.txtDTHCN.Name = "txtDTHCN";
            this.txtDTHCN.Size = new System.Drawing.Size(104, 20);
            this.txtDTHCN.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Diện Tích: ";
            // 
            // txtCVHCN
            // 
            this.txtCVHCN.Location = new System.Drawing.Point(74, 80);
            this.txtCVHCN.Name = "txtCVHCN";
            this.txtCVHCN.Size = new System.Drawing.Size(104, 20);
            this.txtCVHCN.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Chu Vi: ";
            // 
            // txtDai
            // 
            this.txtDai.Location = new System.Drawing.Point(74, 24);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(104, 20);
            this.txtDai.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Dài:";
            // 
            // txtDTHT
            // 
            this.txtDTHT.Location = new System.Drawing.Point(74, 106);
            this.txtDTHT.Name = "txtDTHT";
            this.txtDTHT.Size = new System.Drawing.Size(104, 20);
            this.txtDTHT.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Diện Tích: ";
            // 
            // txtCVHT
            // 
            this.txtCVHT.Location = new System.Drawing.Point(74, 66);
            this.txtCVHT.Name = "txtCVHT";
            this.txtCVHT.Size = new System.Drawing.Size(104, 20);
            this.txtCVHT.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chu Vi: ";
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(74, 24);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(104, 20);
            this.txtBanKinh.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bán kính: ";
            // 
            // gbHinhVuong
            // 
            this.gbHinhVuong.Controls.Add(this.txtDTHV);
            this.gbHinhVuong.Controls.Add(this.label6);
            this.gbHinhVuong.Controls.Add(this.txtCVHV);
            this.gbHinhVuong.Controls.Add(this.label7);
            this.gbHinhVuong.Controls.Add(this.txtCanh);
            this.gbHinhVuong.Controls.Add(this.label8);
            this.gbHinhVuong.Location = new System.Drawing.Point(12, 293);
            this.gbHinhVuong.Name = "gbHinhVuong";
            this.gbHinhVuong.Size = new System.Drawing.Size(257, 166);
            this.gbHinhVuong.TabIndex = 7;
            this.gbHinhVuong.TabStop = false;
            this.gbHinhVuong.Text = "Hình Vuông";
            this.gbHinhVuong.Visible = false;
            // 
            // txtDTHV
            // 
            this.txtDTHV.Location = new System.Drawing.Point(74, 106);
            this.txtDTHV.Name = "txtDTHV";
            this.txtDTHV.Size = new System.Drawing.Size(104, 20);
            this.txtDTHV.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Diện Tích: ";
            // 
            // txtCVHV
            // 
            this.txtCVHV.Location = new System.Drawing.Point(74, 66);
            this.txtCVHV.Name = "txtCVHV";
            this.txtCVHV.Size = new System.Drawing.Size(104, 20);
            this.txtCVHV.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Chu Vi: ";
            // 
            // txtCanh
            // 
            this.txtCanh.Location = new System.Drawing.Point(74, 24);
            this.txtCanh.Name = "txtCanh";
            this.txtCanh.Size = new System.Drawing.Size(104, 20);
            this.txtCanh.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cạnh:";
            // 
            // grHTG
            // 
            this.grHTG.Controls.Add(this.txtCanh3);
            this.grHTG.Controls.Add(this.label13);
            this.grHTG.Controls.Add(this.txtCanh2);
            this.grHTG.Controls.Add(this.label12);
            this.grHTG.Controls.Add(this.txtDTHTG);
            this.grHTG.Controls.Add(this.label9);
            this.grHTG.Controls.Add(this.txtCVHTG);
            this.grHTG.Controls.Add(this.label10);
            this.grHTG.Controls.Add(this.txtCanh1);
            this.grHTG.Controls.Add(this.label11);
            this.grHTG.Location = new System.Drawing.Point(12, 296);
            this.grHTG.Name = "grHTG";
            this.grHTG.Size = new System.Drawing.Size(257, 166);
            this.grHTG.TabIndex = 8;
            this.grHTG.TabStop = false;
            this.grHTG.Text = "Hình Tam giác";
            this.grHTG.Visible = false;
            // 
            // txtCanh3
            // 
            this.txtCanh3.Location = new System.Drawing.Point(74, 74);
            this.txtCanh3.Name = "txtCanh3";
            this.txtCanh3.Size = new System.Drawing.Size(104, 20);
            this.txtCanh3.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Cạnh 3:";
            // 
            // txtCanh2
            // 
            this.txtCanh2.Location = new System.Drawing.Point(74, 48);
            this.txtCanh2.Name = "txtCanh2";
            this.txtCanh2.Size = new System.Drawing.Size(104, 20);
            this.txtCanh2.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Cạnh 2:";
            // 
            // txtDTHTG
            // 
            this.txtDTHTG.Location = new System.Drawing.Point(74, 129);
            this.txtDTHTG.Name = "txtDTHTG";
            this.txtDTHTG.Size = new System.Drawing.Size(104, 20);
            this.txtDTHTG.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Diện Tích: ";
            // 
            // txtCVHTG
            // 
            this.txtCVHTG.Location = new System.Drawing.Point(74, 100);
            this.txtCVHTG.Name = "txtCVHTG";
            this.txtCVHTG.Size = new System.Drawing.Size(104, 20);
            this.txtCVHTG.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Chu Vi: ";
            // 
            // txtCanh1
            // 
            this.txtCanh1.Location = new System.Drawing.Point(74, 24);
            this.txtCanh1.Name = "txtCanh1";
            this.txtCanh1.Size = new System.Drawing.Size(104, 20);
            this.txtCanh1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cạnh 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 458);
            this.Controls.Add(this.grHCN);
            this.Controls.Add(this.gbHinhTron);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grHTG);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbHinhVuong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbHinhTron.ResumeLayout(false);
            this.gbHinhTron.PerformLayout();
            this.grHCN.ResumeLayout(false);
            this.grHCN.PerformLayout();
            this.gbHinhVuong.ResumeLayout(false);
            this.gbHinhVuong.PerformLayout();
            this.grHTG.ResumeLayout(false);
            this.grHTG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbHCN;
        private System.Windows.Forms.RadioButton rdbHV;
        private System.Windows.Forms.RadioButton rdbHTG;
        private System.Windows.Forms.RadioButton rdbHT;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbHinhTron;
        private System.Windows.Forms.TextBox txtDTHT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCVHT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbHinhVuong;
        private System.Windows.Forms.TextBox txtDTHV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCVHV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCanh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grHTG;
        private System.Windows.Forms.TextBox txtCanh3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCanh2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDTHTG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCVHTG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCanh1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grHCN;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDTHCN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCVHCN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDai;
        private System.Windows.Forms.Label label16;
    }
}

