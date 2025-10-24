using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool LayPhanSo(TextBox txtTuSo, TextBox txtMauSo, out int tuSo, out int mauSo)
        {
            tuSo = 0; mauSo = 0;
            if (!int.TryParse(txtTuSo.Text, out tuSo) || !int.TryParse(txtMauSo.Text, out mauSo))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.");
                return false;
            }
            if (mauSo == 0)
            {
                MessageBox.Show("Mẫu số không được bằng 0.");
                return false;
            }
            return true;
        }
        private int TimUSCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private void RutGonPhanSo(ref int tuSo, ref int mauSo)
        {
            int gcd = TimUSCLN(tuSo, mauSo);
            tuSo /= gcd;
            mauSo /= gcd;
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (!LayPhanSo(txtTuSo1, txtMauSo1, out int tu1, out int mau1)) return;
            if (!LayPhanSo(txtTuSo2, txtMauSo2, out int tu2, out int mau2)) return;

            int tu = tu1 * mau2 + tu2 * mau1;
            int mau = mau1 * mau2;

            RutGonPhanSo(ref tu, ref mau);

            txtKetQuaTuSo.Text = tu.ToString();
            txtKetQuaMauSo.Text = mau.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (!LayPhanSo(txtTuSo1, txtMauSo1, out int tu1, out int mau1)) return;
            if (!LayPhanSo(txtTuSo2, txtMauSo2, out int tu2, out int mau2)) return;

            int tu = tu1 * mau2 - tu2 * mau1;
            int mau = mau1 * mau2;

            RutGonPhanSo(ref tu, ref mau);

            txtKetQuaTuSo.Text = tu.ToString();
            txtKetQuaMauSo.Text = mau.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (!LayPhanSo(txtTuSo1, txtMauSo1, out int tu1, out int mau1)) return;
            if (!LayPhanSo(txtTuSo2, txtMauSo2, out int tu2, out int mau2)) return;

            int tu = tu1 * tu2;
            int mau = mau1 * mau2;

            RutGonPhanSo(ref tu, ref mau);

            txtKetQuaTuSo.Text = tu.ToString();
            txtKetQuaMauSo.Text = mau.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (!LayPhanSo(txtTuSo1, txtMauSo1, out int tu1, out int mau1)) return;
            if (!LayPhanSo(txtTuSo2, txtMauSo2, out int tu2, out int mau2)) return;

            if (tu2 == 0)
            {
                MessageBox.Show("Không thể chia cho phân số có tử số bằng 0.");
                return;
            }

            int tu = tu1 * mau2;
            int mau = mau1 * tu2;

            RutGonPhanSo(ref tu, ref mau);

            txtKetQuaTuSo.Text = tu.ToString();
            txtKetQuaMauSo.Text = mau.ToString();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtTuSo1.Clear();
            txtMauSo1.Clear();
            txtTuSo2.Clear();
            txtMauSo2.Clear();
            txtKetQuaTuSo.Clear();
            txtKetQuaMauSo.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
