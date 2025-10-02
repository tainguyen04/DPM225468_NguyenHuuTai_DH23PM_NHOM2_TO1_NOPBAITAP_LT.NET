using System;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form3 : Form
    {
        private int[] c;

        public Form3(int[] mang)
        {
            InitializeComponent();
            c = new int[mang.Length];
            Array.Copy(mang, c, mang.Length);
            TimMax();
        }

        private void TimMax()
        {
            int max = c[0];
            string mangStr = "";

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] > max)
                    max = c[i];
                mangStr += c[i] + " ";
            }

            lblMang.Text = "Mảng: " + mangStr;
            lblMax.Text = "Số lớn nhất: " + max.ToString();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}