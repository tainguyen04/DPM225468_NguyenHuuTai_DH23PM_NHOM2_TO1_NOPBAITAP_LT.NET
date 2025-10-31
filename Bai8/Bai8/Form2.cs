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
    public partial class Form2 : Form
    {
        public decimal _canh;
        public Form2(decimal canh)
        {
            InitializeComponent();
            _canh = canh;
        }
        Form1 frm1 = new Form1();
        private void Form2_Load(object sender, EventArgs e)
        {
            txtDienTich.Text = (_canh*_canh).ToString();
            txtChuVi.Text = (4*_canh).ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
