using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhChuVi_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtSoThuNhat.Text);
            double b = Convert.ToDouble(txtSoThuHai.Text);
            double p = (a+b)*2;
            txtKetQua.Text = p.ToString();
        }

        private void btnTinhDienTich_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtSoThuNhat.Text);
            double b = Convert.ToDouble(txtSoThuHai.Text);
            double s = a * b ;
            txtKetQua.Text = s.ToString();
        }

        private void btnTinhDuongCheo_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtSoThuNhat.Text);
            double b = Convert.ToDouble(txtSoThuHai.Text);
            double temp = (a*a) + (b*b);
            double d = Math.Sqrt(temp);
            txtKetQua.Text = d.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
