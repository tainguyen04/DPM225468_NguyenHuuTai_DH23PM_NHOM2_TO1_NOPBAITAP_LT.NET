using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdbHV.CheckedChanged += RadioButton_Changed;
            rdbHT.CheckedChanged += RadioButton_Changed;
            rdbHCN.CheckedChanged += RadioButton_Changed;
            rdbHTG.CheckedChanged += RadioButton_Changed;
        }

        private void RadioButton_Changed(object sender, EventArgs e)
        {
            gbHinhVuong.Visible = false;
            gbHinhTron.Visible = false;
            grHCN.Visible = false;
            grHTG.Visible = false;



            // Hiển thị GroupBox được chọn
            if (rdbHV.Checked)
            {
                gbHinhVuong.Visible = true;
            }
            else if (rdbHT.Checked)
            {
                gbHinhTron.Visible = true;
            }
            else if (rdbHCN.Checked)
            {
                grHCN.Visible = true;
            }
            else if (rdbHTG.Checked)
            {
                grHTG.Visible = true;
            }

            // Tùy chọn: Gọi hàm Reset để xóa dữ liệu cũ khi chuyển hình
            ResetControls();

        }

        private void ResetControls()
        {
            // Hình Vuông: txtCanh, txtCVHV, txtDTHV
            txtCanh.Text = "";
            txtCVHV.Text = "";
            txtDTHV.Text = "";

            // Hình Tròn: txtBanKinh, txtCVHT, txtDTHT
            txtBanKinh.Text = "";
            txtCVHT.Text = "";
            txtDTHT.Text = "";

            // Hình Chữ Nhật (HCN): txtDai, txtRong, txtCVHCN, txtDTHCN
            txtDai.Text = "";
            txtRong.Text = "";
            txtCVHCN.Text = "";
            txtDTHCN.Text = "";

            // Hình Tam Giác (TG): txtCanh1, txtCanh2, txtCanh3, txtCVHTG, txtDTHTG, txtTG_Loai
            txtCanh1.Text = "";
            txtCanh2.Text = "";
            txtCanh3.Text = "";
            txtCVHTG.Text = "";
            txtDTHTG.Text = "";
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {

            if (rdbHV.Checked)
            {
                TinhHinhVuong();
            }
            else if (rdbHT.Checked)
            {
                TinhHinhTron();
            }
            else if (rdbHCN.Checked)
            {
                TinhHinhChuNhat();
            }
            else if (rdbHTG.Checked)
            {
                TinhHinhTamGiac();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một loại hình để tính toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void TinhHinhTamGiac()
        {
            // Giả sử có txtTG_CanhA, txtTG_CanhB, txtTG_CanhC
            if (double.TryParse(txtCanh1.Text, out double a) && a > 0 &&
                double.TryParse(txtCanh2.Text, out double b) && b > 0 &&
                double.TryParse(txtCanh3.Text, out double c) && c > 0)
            {
                // 1. Kiểm tra điều kiện tồn tại tam giác: Tổng hai cạnh bất kỳ lớn hơn cạnh còn lại
                if (a + b > c && a + c > b && b + c > a)
                {
                    // Tính toán
                    double chuVi = a + b + c;
                    double p = chuVi / 2; // Nửa chu vi
                    double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                    txtCVHTG.Text = chuVi.ToString("F2");
                    txtDTHTG.Text = dienTich.ToString("F2");


                }
                else
                {
                    MessageBox.Show("Ba cạnh nhập vào không tạo thành một tam giác.", "Lỗi Tam Giác");

                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập 3 cạnh hợp lệ (số dương).", "Lỗi Nhập Liệu");
            }
        }



        private void TinhHinhVuong()
        {
            if (double.TryParse(txtCanh.Text, out double a) && a > 0)
            {
                double chuVi = 4 * a;
                double dienTich = a * a;
                txtCVHV.Text = chuVi.ToString("F2"); // Hiển thị 2 chữ số thập phân
                txtDTHV.Text = dienTich.ToString("F2");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập cạnh hợp lệ (số dương).", "Lỗi Nhập Liệu");
                txtCanh.Focus();
            }
        }

        private void TinhHinhChuNhat()
        {
            // Giả sử có txtHCN_ChieuDai (a) và txtHCN_ChieuRong (b)
            if (double.TryParse(txtDai.Text, out double a) && a > 0 &&
                double.TryParse(txtRong.Text, out double b) && b > 0)
            {
                double chuVi = 2 * (a + b);
                double dienTich = a * b;
                txtCVHCN.Text = chuVi.ToString("F2");
                txtDTHCN.Text = dienTich.ToString("F2");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập chiều dài và chiều rộng hợp lệ (số dương).", "Lỗi Nhập Liệu");
            }
        }

        private void TinhHinhTron()
        {
            if (double.TryParse(txtBanKinh.Text, out double r) && r > 0)
            {
                double chuVi = 2 * Math.PI * r;
                double dienTich = Math.PI * r * r;
                txtCVHT.Text = chuVi.ToString("F2");
                txtDTHT.Text = dienTich.ToString("F2");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập bán kính hợp lệ (số dương).", "Lỗi Nhập Liệu");
                txtBanKinh.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
