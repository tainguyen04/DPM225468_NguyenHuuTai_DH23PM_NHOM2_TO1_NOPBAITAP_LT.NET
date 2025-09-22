using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string thongBao = "Tên đăng nhập là:";
            thongBao += txtUser.Text;
            thongBao += "\n\rMật khẩu là:";
            thongBao += txtPass.Text;
            if( chkNho.Checked == true)
            {
                thongBao += "\n\rBạn có ghi nhớ.";
            }
            MessageBox.Show(thongBao,"Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
            
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if( traloi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
