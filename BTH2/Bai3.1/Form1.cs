using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtThamSoX.Text);
            if(x >= 2)
            {
                double kq = -8 * (x * x * x) - 12 * x - 1;
                txtKetQua.Text = kq.ToString();
            }else if(x > 1 && x < 2)
            {
                double kq = (x * x) - 6 * x - 19;
                txtKetQua.Text = kq.ToString();
            }
            else
            {
                double kq =7 * x;
                txtKetQua.Text = kq.ToString();
            }
        }
    }
}
