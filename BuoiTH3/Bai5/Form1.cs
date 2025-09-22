using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int TimMax(int so1, int so2)
        {
            if (so1 > so2)
                return so1;
            else
                return so2;
        }
        public
        string TimUocChung(int a, int b)
        {
            int max = TimMax(a, b);
            string chuoi = "";
            for (int i = 1; i <= max; i++)
            {
                if ((a % i == 0) && (b % i == 0))
                    chuoi += " " + i.ToString();
            }
            return chuoi;
        }
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }



        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(this.txtN.Text);
            b = int.Parse(this.txtM.Text);
            if (this.rdb1.Checked == true)
                this.txtKQ.Text = TimUocChung(a, b);
            if (this.rdb2.Checked == true)
                this.txtKQ.Text = timUCLN(a, b).ToString();
        }
    }
}
