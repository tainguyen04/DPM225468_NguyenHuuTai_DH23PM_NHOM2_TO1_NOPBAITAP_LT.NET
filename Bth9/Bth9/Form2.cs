using System;
using System.Windows.Forms;

namespace Bth9
{
    public partial class Form2 : Form
    {
        private int n;

        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblKetQua.Text = KiemTraSoHoanHao(n) ?
                $"{n} là số hoàn hảo" :
                $"{n} không phải số hoàn hảo";
        }

        private bool KiemTraSoHoanHao(int num)
        {
            if (num <= 1) return false;

            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    sum += i;
            }
            return sum == num;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}