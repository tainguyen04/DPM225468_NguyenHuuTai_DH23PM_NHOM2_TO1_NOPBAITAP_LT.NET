using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai7_4
{
    public partial class Form1 : Form
    {
        private List<Label> danhSachGhe = new List<Label>();
        private int giaVe = 100000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaoSoDoGhe();
        }

        private void TaoSoDoGhe()
        {
            int soGhe = 30;
            int xStart = 50, yStart = 60;
            int width = 40, height = 40;
            int margin = 10;
            int ghePerRow = 9;

            for (int i = 0; i < soGhe; i++)
            {
                Label lbl = new Label();
                lbl.Text = (i + 1).ToString();
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Size = new Size(width, height);
                lbl.BackColor = Color.White;
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.Font = new Font("Arial", 10, FontStyle.Bold);
                lbl.Location = new Point(xStart + (i % ghePerRow) * (width + margin),
                                         yStart + (i / ghePerRow) * (height + margin));
                lbl.Click += ChonGhe_Click;

                danhSachGhe.Add(lbl);
                this.Controls.Add(lbl);
            }
        }

        private void ChonGhe_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl.BackColor == Color.White)
            {
                lbl.BackColor = Color.Blue; // đang chọn
            }
            else if (lbl.BackColor == Color.Blue)
            {
                lbl.BackColor = Color.White; // bỏ chọn
            }
            else if (lbl.BackColor == Color.Yellow)
            {
                MessageBox.Show($"Ghế {lbl.Text} đã được bán!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CapNhatThanhTien();
        }

        private void CapNhatThanhTien()
        {
            int soLuongChon = 0;
            foreach (var ghe in danhSachGhe)
            {
                if (ghe.BackColor == Color.Blue)
                    soLuongChon++;
            }
            lblThanhTien.Text = (soLuongChon * giaVe).ToString("N0") + " VND";
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            foreach (var ghe in danhSachGhe)
            {
                if (ghe.BackColor == Color.Blue)
                {
                    ghe.BackColor = Color.Yellow; // đã bán
                }
            }
            lblThanhTien.Text = "0 VND";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (var ghe in danhSachGhe)
            {
                if (ghe.BackColor == Color.Blue)
                {
                    ghe.BackColor = Color.White; // hủy chọn
                }
            }
            lblThanhTien.Text = "0 VND";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
