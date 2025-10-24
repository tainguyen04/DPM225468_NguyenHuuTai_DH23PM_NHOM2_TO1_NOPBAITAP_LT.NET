using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bai7_3
{
    public partial class Form1 : Form
    {
        private List<string> danhSachHinh = new List<string>();
        private int viTriHienTai = 0;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 2000; // 2 giây đổi hình
            timer.Tick += Timer_Tick;
        }

        private void btnMoDanhSach_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                danhSachHinh.Clear();
                danhSachHinh.AddRange(ofd.FileNames);
                viTriHienTai = 0;
                HienThiHinh();
            }
        }

        private void HienThiHinh()
        {
            if (danhSachHinh.Count > 0 && viTriHienTai >= 0 && viTriHienTai < danhSachHinh.Count)
            {
                picAnh.Image = Image.FromFile(danhSachHinh[viTriHienTai]);
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (danhSachHinh.Count == 0) return;
            viTriHienTai = (viTriHienTai - 1 + danhSachHinh.Count) % danhSachHinh.Count;
            HienThiHinh();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (danhSachHinh.Count == 0) return;
            viTriHienTai = (viTriHienTai + 1) % danhSachHinh.Count;
            HienThiHinh();
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (danhSachHinh.Count > 0)
                timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            viTriHienTai = (viTriHienTai + 1) % danhSachHinh.Count;
            HienThiHinh();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
