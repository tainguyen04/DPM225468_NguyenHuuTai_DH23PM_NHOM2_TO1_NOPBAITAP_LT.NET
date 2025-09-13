using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtSoThuNhat.Text);
            double b = Convert.ToDouble(txtSoThuHai.Text);
            double c = Convert.ToDouble(txtSoThuBa.Text);
            double delta = (b * b) - 4 * a * c;
            if (a == 0 && b == 0 && c == 0)
            {
                txtKetQua.Text = "PT có vô số nghiệm!"; 
            }
            
            else if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                string s = string.Format("PT có 2 nghiệm: x1={0},x2={1}", x1, x2);
                txtKetQua.Text = s;
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                txtKetQua.Text = string.Format("PT có nghiệm kép:{0}", x);
            }
            else
                txtKetQua.Text = "PT vô nghiệm!";
        }
    }
}
