using System.Windows.Forms;
namespace Bai3
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMang;
        private Label lblTong;
        private Button btnQuayLai;

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
            this.lblMang = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMang
            // 
            this.lblMang.AutoSize = true;
            this.lblMang.Location = new System.Drawing.Point(12, 20);
            this.lblMang.Name = "lblMang";
            this.lblMang.Size = new System.Drawing.Size(40, 13);
            this.lblMang.TabIndex = 0;
            this.lblMang.Text = "Mảng: ";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(12, 50);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(35, 13);
            this.lblTong.TabIndex = 1;
            this.lblTong.Text = "Tổng:";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(100, 80);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 2;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.lblMang);
            this.Name = "Form2";
            this.Text = "Tính tổng mảng";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}