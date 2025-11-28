using System;
using System.Windows.Forms;

namespace Bth9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLamLai.Enabled = false;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu())
            {
                Form2 f2 = new Form2(int.Parse(txtN.Text));
                f2.ShowDialog();
                btnLamLai.Enabled = true;
            }
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu())
            {
                Form3 f3 = new Form3(int.Parse(txtN.Text));
                f3.ShowDialog();
                btnLamLai.Enabled = true;
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtN.Focus();
            btnLamLai.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool KiemTraNhapLieu()
        {
            if (string.IsNullOrEmpty(txtN.Text))
            {
                MessageBox.Show("Vui lòng nhập số N!");
                txtN.Focus();
                return false;
            }

            if (!int.TryParse(txtN.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương!");
                txtN.Focus();
                return false;
            }

            return true;
        }
    }
}
