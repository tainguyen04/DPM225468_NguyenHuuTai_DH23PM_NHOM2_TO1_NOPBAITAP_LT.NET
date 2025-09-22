using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNhapChuoi.Text.Length > 0) 
            {
                lsbNhapChuoi.Items.Add(txtNhapChuoi.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống dữ liêu!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lsbNhapChuoi.SelectedItem != null)
            {
                lsbNhapChuoi.Items.Remove(lsbNhapChuoi.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.");
            }

        }

        private void lsbNhapChuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbNhapChuoi.SelectedItem != null)
            {
                txtHienThi.Text = lsbNhapChuoi.SelectedItem.ToString();
            }
            else
            {
                txtHienThi.Clear();
            }
        }

        private void btnChonMauChu_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtHienThi.ForeColor = colorDialog.Color;
            }
        }

        private void btnChonMauNen_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtHienThi.BackColor = colorDialog.Color;
            }
        }

        private void btnChonFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = txtHienThi.Font; 

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtHienThi.Font = fontDialog.Font;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
