using System.Windows.Forms;
namespace Bai3
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMang;
        private Label lblMax;
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
            this.lblMax = new System.Windows.Forms.Label();
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
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(12, 50);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(30, 13);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "Max:";
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMang);
            this.Name = "Form3";
            this.Text = "Tìm số lớn nhất";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}