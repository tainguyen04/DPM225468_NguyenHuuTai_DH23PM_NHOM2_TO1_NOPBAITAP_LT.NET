namespace Bai7_5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cboShape;
        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.GroupBox grpBorder;
        private System.Windows.Forms.Panel pnlBorderColor;
        private System.Windows.Forms.Label lblBorderColor;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.GroupBox grpFill;
        private System.Windows.Forms.Panel pnlFillColor;
        private System.Windows.Forms.Label lblFillColor;
        private System.Windows.Forms.Panel pnlDraw;

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
            this.cboShape = new System.Windows.Forms.ComboBox();
            this.lblShape = new System.Windows.Forms.Label();
            this.grpBorder = new System.Windows.Forms.GroupBox();
            this.pnlBorderColor = new System.Windows.Forms.Panel();
            this.lblBorderColor = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.grpFill = new System.Windows.Forms.GroupBox();
            this.pnlFillColor = new System.Windows.Forms.Panel();
            this.lblFillColor = new System.Windows.Forms.Label();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.grpBorder.SuspendLayout();
            this.grpFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShape
            // 
            this.lblShape.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblShape.Location = new System.Drawing.Point(40, 20);
            this.lblShape.Size = new System.Drawing.Size(150, 25);
            this.lblShape.Text = "Chọn hình vẽ";
            // 
            // cboShape
            // 
            this.cboShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShape.Location = new System.Drawing.Point(200, 20);
            this.cboShape.Size = new System.Drawing.Size(200, 25);
            // 
            // grpBorder
            // 
            this.grpBorder.Controls.Add(this.pnlBorderColor);
            this.grpBorder.Controls.Add(this.lblBorderColor);
            this.grpBorder.Controls.Add(this.lblSize);
            this.grpBorder.Controls.Add(this.txtSize);
            this.grpBorder.Location = new System.Drawing.Point(40, 60);
            this.grpBorder.Size = new System.Drawing.Size(250, 100);
            this.grpBorder.Text = "Border";
            // 
            // lblBorderColor
            // 
            this.lblBorderColor.Location = new System.Drawing.Point(10, 25);
            this.lblBorderColor.Size = new System.Drawing.Size(50, 25);
            this.lblBorderColor.Text = "Color";
            // 
            // pnlBorderColor
            // 
            this.pnlBorderColor.BackColor = System.Drawing.Color.Blue;
            this.pnlBorderColor.Location = new System.Drawing.Point(70, 25);
            this.pnlBorderColor.Size = new System.Drawing.Size(60, 25);
            this.pnlBorderColor.Click += new System.EventHandler(this.pnlBorderColor_Click);
            // 
            // lblSize
            // 
            this.lblSize.Location = new System.Drawing.Point(140, 25);
            this.lblSize.Size = new System.Drawing.Size(40, 25);
            this.lblSize.Text = "Size";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(180, 25);
            this.txtSize.Size = new System.Drawing.Size(50, 25);
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // grpFill
            // 
            this.grpFill.Controls.Add(this.pnlFillColor);
            this.grpFill.Controls.Add(this.lblFillColor);
            this.grpFill.Location = new System.Drawing.Point(40, 180);
            this.grpFill.Size = new System.Drawing.Size(250, 70);
            this.grpFill.Text = "Fill";
            // 
            // lblFillColor
            // 
            this.lblFillColor.Location = new System.Drawing.Point(10, 30);
            this.lblFillColor.Size = new System.Drawing.Size(50, 25);
            this.lblFillColor.Text = "Color";
            // 
            // pnlFillColor
            // 
            this.pnlFillColor.BackColor = System.Drawing.Color.Red;
            this.pnlFillColor.Location = new System.Drawing.Point(70, 30);
            this.pnlFillColor.Size = new System.Drawing.Size(60, 25);
            this.pnlFillColor.Click += new System.EventHandler(this.pnlFillColor_Click);
            // 
            // pnlDraw
            // 
            this.pnlDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDraw.Location = new System.Drawing.Point(320, 60);
            this.pnlDraw.Size = new System.Drawing.Size(300, 200);
            this.pnlDraw.BackColor = System.Drawing.Color.White;
            this.pnlDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseDown);
            this.pnlDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseUp);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(660, 300);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.grpFill);
            this.Controls.Add(this.grpBorder);
            this.Controls.Add(this.cboShape);
            this.Controls.Add(this.lblShape);
            this.Text = "Vẽ hình cơ bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBorder.ResumeLayout(false);
            this.grpBorder.PerformLayout();
            this.grpFill.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
