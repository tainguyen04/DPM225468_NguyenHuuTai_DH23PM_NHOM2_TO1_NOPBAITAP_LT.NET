using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form4 : Form
    {
        public double _bankinh;
        public Form4(double bankinh)
        {
            InitializeComponent();
            _bankinh = bankinh;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtChuVi.Text = (2 * 3.14 * _bankinh).ToString();
            txtDienTich.Text = (3.14 *_bankinh*_bankinh).ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
