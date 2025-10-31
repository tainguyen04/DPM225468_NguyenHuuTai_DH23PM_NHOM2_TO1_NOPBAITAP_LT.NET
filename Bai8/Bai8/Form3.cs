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
    public partial class Form3 : Form
    {
        public decimal _dai, _rong;

        private void Form3_Load(object sender, EventArgs e)
        {
            txtChuVi.Text = (2 * (_dai + _rong)).ToString();
            txtDienTich.Text = (_dai*_rong).ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form3(decimal dai, decimal rong)
        {
            InitializeComponent();
            _dai = dai;
            _rong = rong;
        }
    }
}
