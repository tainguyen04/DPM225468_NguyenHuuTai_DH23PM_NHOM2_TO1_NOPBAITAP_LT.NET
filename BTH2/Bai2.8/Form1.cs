using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtSoThuNhat.Text);
            int b = Convert.ToInt32(txtSoThuHai.Text);
            int tong = a + b;
            txtKetQua.Text = Convert.ToString(tong);
        }

        private void btnTinhHieu_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtSoThuNhat.Text);
            int b = Convert.ToInt32(txtSoThuHai.Text);
            int hieu = a - b;
            txtKetQua.Text = Convert.ToString(hieu);
        }

        private void btnTinhNhan_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtSoThuNhat.Text);
            int b = Convert.ToInt32(txtSoThuHai.Text);
            int nhan = a * b;
            txtKetQua.Text = Convert.ToString(nhan);
        }

        private void btnTinhChia_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtSoThuNhat.Text);
            int b = Convert.ToInt32(txtSoThuHai.Text);
            if (b == 0)
            {
                MessageBox.Show("Không thể chia 0");
            }
            else
            {
                int chia = a / b;
                txtKetQua.Text = Convert.ToString(chia);
            }
        }
    }
}
