using System;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        int[] a = new int[10];
        int sopt = 0;
        const int n = 10;

        public Form1()
        {
            InitializeComponent();
            btnIn.Enabled = false;
            btnSXTang.Enabled = false;
            btnSXGiam.Enabled = false;
            btnDemSoChan.Enabled = false;
            btnDemSoLe.Enabled = false;
            btnSoNguyenTo.Enabled = false;
            btnSHH.Enabled = false;
            btnSum.Enabled = false;
            btnUCLN.Enabled = false;
            btnTBMang.Enabled = false;
            btnMin.Enabled = false;
            btnMax.Enabled = false;
        }

        // CÁC PHƯƠNG THỨC
        public string InMang()
        {
            string chuoi = "";
            for (int i = 0; i < sopt; i++)
                chuoi += a[i] + " ";
            return chuoi;
        }

        public int TimMax()
        {
            int max = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }

        public int TimMin()
        {
            int min = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] < min)
                    min = a[i];
            return min;
        }

        public double TrungBinhMang()
        {
            int sum = 0;
            double tb;
            for (int i = 0; i < sopt; i++)
                sum += a[i];
            tb = (double)sum / (double)sopt;
            return tb;
        }

        public void SapXepTang()
        {
            Array.Sort(a, 0, sopt);
        }

        public void SapXepGiam()
        {
            Array.Sort(a, 0, sopt);
            Array.Reverse(a, 0, sopt);
        }

        public int TimUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }

        public bool KiemTraSNT(int so)
        {
            if (so <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(so); i++)
            {
                if (so % i == 0)
                    return false;
            }
            return true;
        }

        public int DemSNT()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (KiemTraSNT(a[i]))
                    dem++;
            }
            return dem;
        }

        public string InSNT()
        {
            string chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (KiemTraSNT(a[i]))
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }

        public bool KiemTraSoHoanHao(int so)
        {
            if (so <= 1) return false;
            int sum = 0;
            for (int i = 1; i <= so / 2; i++)
            {
                if (so % i == 0)
                    sum += i;
            }
            return sum == so;
        }

        public int DemSoChan()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 == 0)
                    dem++;
            }
            return dem;
        }

        public int DemSoLe()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 != 0)
                    dem++;
            }
            return dem;
        }

        public int TinhTongMang()
        {
            int sum = 0;
            for (int i = 0; i < sopt; i++)
                sum += a[i];
            return sum;
        }

        // SỰ KIỆN
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (sopt == n)
            {
                txtNhap.Text = "";
                MessageBox.Show("Mảng đầy", "Thông báo");
            }
            else
            {
                if (string.IsNullOrEmpty(txtNhap.Text))
                {
                    MessageBox.Show("Hãy nhập phần tử mảng", "Thông báo");
                }
                else
                {
                    a[sopt] = int.Parse(txtNhap.Text);
                    sopt++;
                    lblKQ.Text += txtNhap.Text + " ";
                    txtNhap.Clear();
                    txtNhap.Focus();

                    // Kích hoạt các nút khi có phần tử
                    if (sopt > 0)
                    {
                        btnIn.Enabled = true;
                        btnSXTang.Enabled = true;
                        btnSXGiam.Enabled = true;
                        btnDemSoChan.Enabled = true;
                        btnDemSoLe.Enabled = true;
                        btnSoNguyenTo.Enabled = true;
                        btnSHH.Enabled = true;
                        btnSum.Enabled = true;
                        btnUCLN.Enabled = sopt >= 2;
                        btnTBMang.Enabled = true;
                        btnMin.Enabled = true;
                        btnMax.Enabled = true;
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Các phần tử trong mảng là: \n" + InMang();
        }

        private void btnSXTang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                SapXepTang();
                lblKQ.Text = "Đã sắp xếp mảng tăng dần: " + InMang();
            }
        }

        private void btnSXGiam_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                SapXepGiam();
                lblKQ.Text = "Đã sắp xếp mảng giảm dần: " + InMang();
            }
        }

        private void btnSoNguyenTo_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + DemSNT().ToString() + " số nguyên tố là: " + InSNT();
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            if (sopt < 2)
                lblKQ.Text = "Cần ít nhất 2 phần tử để tìm UCLN!";
            else
                lblKQ.Text = "Ước chung lớn nhất 2 phần tử đầu " + a[0] + " và " + a[1] + " là " + TimUCLN(a[0], a[1]).ToString();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Tổng các phần tử trong mảng là: " + TinhTongMang().ToString();
        }

        private void btnTBMang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Trung bình các phần tử trong mảng là: " + TrungBinhMang().ToString("F2");
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Phần tử nhỏ nhất trong mảng là: " + TimMin().ToString();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Phần tử lớn nhất trong mảng là: " + TimMax().ToString();
        }

        private void btnDemSoChan_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Số phần tử chẵn trong mảng là: " + DemSoChan().ToString();
        }

        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Số phần tử lẻ trong mảng là: " + DemSoLe().ToString();
        }

        private void btnSHH_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                lblKQ.Text = "Mảng rỗng!";
                return;
            }

            string shh = "";
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (KiemTraSoHoanHao(a[i]))
                {
                    shh += a[i] + " ";
                    dem++;
                }
            }

            if (dem == 0)
                lblKQ.Text = "Không có số hoàn hảo trong mảng";
            else
                lblKQ.Text = "Mảng có " + dem + " số hoàn hảo là: " + shh;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sopt = 0;
           
            txtNhap.Focus();

            // Vô hiệu hóa các nút
            btnIn.Enabled = false;
            btnSXTang.Enabled = false;
            btnSXGiam.Enabled = false;
            btnDemSoChan.Enabled = false;
            btnDemSoLe.Enabled = false;
            btnSoNguyenTo.Enabled = false;
            btnSHH.Enabled = false;
            btnSum.Enabled = false;
            btnUCLN.Enabled = false;
            btnTBMang.Enabled = false;
            btnMin.Enabled = false;
            btnMax.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}