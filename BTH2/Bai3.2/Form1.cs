using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            int mua = Convert.ToInt32(txtMua.Text);
            if (mua == 1 || mua == 2 || mua == 3)
            {
                MessageBox.Show("Mùa Xuân");
            }
            else if (mua == 4 || mua == 5 || mua == 6) 
            {
                MessageBox.Show("Mùa Hạ");
            }
            else if (mua == 7 || mua == 8 || mua == 9)
            {
                MessageBox.Show("Mùa Thu");
            }
            else if (mua == 10 || mua == 11 || mua == 12)
            {
                MessageBox.Show("Mùa Đông");
            }
            else
            {
                MessageBox.Show("Nhập số từ 1 -> 12");
            }

        }
    }
}
