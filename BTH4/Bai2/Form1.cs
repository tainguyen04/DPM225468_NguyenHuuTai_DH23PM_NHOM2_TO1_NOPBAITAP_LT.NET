using System;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        int[] a;
        int n;

        public Form1()
        {
            InitializeComponent();
            btnInmang.Enabled = false;
        }

        public void TaoMang(int n)
        {
            a = new int[n];
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rd.Next(-10, 101);
            }
        }

        public string InMang()
        {
            string chuoi = "";
            for (int i = 0; i < a.Length; i++)
                chuoi += a[i] + " ";
            return chuoi;
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNhap.Text))
            {
                MessageBox.Show("Hãy nhập số phần tử mảng", "Thông báo");
                txtNhap.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtNhap.Text);
                if (n <= 0)
                {
                    MessageBox.Show("Bạn vừa nhập n = " + n + ". Số phần tử mảng phải > 0", "Thông báo");
                    txtNhap.Focus();
                }
                else
                {
                    TaoMang(n);
                    lblKQ.Text = "Các phần tử của mảng: " + InMang();
                    btnInmang.Enabled = true;
                }
            }
        }

        private void btnInmang_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    result += a[i] + " ";
                }
            }
            lblKQ.Text = "Các phần tử số nguyên của mảng: " + result.Trim();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}