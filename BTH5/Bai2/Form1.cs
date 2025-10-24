using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool KiemTraSoHoanHao(int n)
        {
            int tong = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    tong += i;
                }
            }
            return tong == n;
        }
        private List<int> TimSoHoanHaoNhoHon(int n)
        {
            List<int> danhSach = new List<int>();
            for (int i = 2; i < n; i++)
            {
                if (KiemTraSoHoanHao(i))
                {
                    danhSach.Add(i);
                }
            }
            return danhSach;
        }
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);

            if (KiemTraSoHoanHao(n))
            {
                txtKiemTra.Text = $"{n} là số hoàn hảo.";
                
            }
            else
            {
                txtKiemTra.Text = $"{n} không phải là số hoàn hảo.";
            }
            List<int> shh = TimSoHoanHaoNhoHon(n);
            txtTim.Text = string.Join(" ", shh);
        }
    }
}
