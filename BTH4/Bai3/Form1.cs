using System;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        int[] a;
        int n;

        public Form1()
        {
            InitializeComponent();
            btnSum.Enabled = false;
            btnMax.Enabled = false;
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
                    MessageBox.Show("Mảng đã được tạo: " + InMang(), "Thông báo");
                    btnSum.Enabled = true;
                    btnMax.Enabled = true;
                }
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (a == null || a.Length == 0)
            {
                MessageBox.Show("Chưa tạo mảng!", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn tính tổng mảng không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form2 form2 = new Form2(a);
                form2.ShowDialog();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (a == null || a.Length == 0)
            {
                MessageBox.Show("Chưa tạo mảng!", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn tìm số lớn nhất không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form3 form3 = new Form3(a);
                form3.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}