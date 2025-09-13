using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtN.Text);
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += 1 / i;
            }
            txtKetqua.Text = s.ToString();
        }
    }
}
