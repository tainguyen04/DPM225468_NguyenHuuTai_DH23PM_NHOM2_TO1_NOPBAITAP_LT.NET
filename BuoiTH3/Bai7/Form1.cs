using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuItemTong_Click(object sender, EventArgs e)
        {
            int a =  int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int kq = a + b;
            txtKq.Text = kq.ToString();
        }

        private void mnuItemHieu_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int kq = a - b;
            txtKq.Text = kq.ToString();
        }

        private void mnuItemNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int kq = a * b;
            txtKq.Text = kq.ToString();
        }

        private void mnuItemChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            if (b == 0) 
            {
                MessageBox.Show("Không thể chia cho 0!");
            }
            else
            {
                int kq = a / b;
                txtKq.Text = kq.ToString();
            }
        }
    }
}
