namespace Bai8
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
            this.cboHoTen = new System.Windows.Forms.ComboBox();
            this.btnHienLoiChao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // cboHoTen
            // 
            this.cboHoTen.FormattingEnabled = true;
            this.cboHoTen.Items.AddRange(new object[] {
            "Nguyễn Hữu Tài",
            "Lê Hữu Toàn",
            "Nguyễn Thành Hiếu"});
            this.cboHoTen.Location = new System.Drawing.Point(156, 60);
            this.cboHoTen.Name = "cboHoTen";
            this.cboHoTen.Size = new System.Drawing.Size(180, 21);
            this.cboHoTen.TabIndex = 1;
            // 
            // btnHienLoiChao
            // 
            this.btnHienLoiChao.Location = new System.Drawing.Point(123, 122);
            this.btnHienLoiChao.Name = "btnHienLoiChao";
            this.btnHienLoiChao.Size = new System.Drawing.Size(156, 41);
            this.btnHienLoiChao.TabIndex = 2;
            this.btnHienLoiChao.Text = "Hiện lời chào";
            this.btnHienLoiChao.UseVisualStyleBackColor = true;
            this.btnHienLoiChao.Click += new System.EventHandler(this.btnHienLoiChao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 202);
            this.Controls.Add(this.btnHienLoiChao);
            this.Controls.Add(this.cboHoTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHoTen;
        private System.Windows.Forms.Button btnHienLoiChao;
    }
}

