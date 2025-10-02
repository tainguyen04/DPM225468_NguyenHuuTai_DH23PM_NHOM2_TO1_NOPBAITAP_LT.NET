using System;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form2 : Form
    {
        private int[] b;

        public Form2(int[] mang)
        {
            InitializeComponent();
            b = new int[mang.Length];
            Array.Copy(mang, b, mang.Length);
            TinhTong();
        }

        private void TinhTong()
        {
            int sum = 0;
            string mangStr = "";

            for (int i = 0; i < b.Length; i++)
            {
                sum += b[i];
                mangStr += b[i] + " ";
            }

            lblMang.Text = "Mảng: " + mangStr;
            lblTong.Text = "Tổng mảng: " + sum.ToString();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}