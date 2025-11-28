using System;
using System.Windows.Forms;

namespace Bth9
{
    public partial class Form3 : Form
    {
        private int n;

        public Form3(int n)
        {
            InitializeComponent();
            this.n = n;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Tạo mảng ngẫu nhiên
            Random rand = new Random();
            int[] arr = new int[n];
            string ketQua = "";

            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(n, n + 13); // Từ N đến N+12
            }

            // Hiển thị số chẵn
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    ketQua += num + " ";
                }
            }

            txtKetQua.Text = ketQua.Trim();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}