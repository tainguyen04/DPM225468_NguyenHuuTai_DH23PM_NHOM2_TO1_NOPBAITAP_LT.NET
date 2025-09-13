using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int ngay = Convert.ToInt32(txtNgay.Text);
            int thang = Convert.ToInt32(txtThang.Text);
            if( thang == 1 || thang == 3 || thang == 7 || thang == 8 || thang == 10|| thang == 12)
            {
                if(ngay >= 1 && ngay <= 31)
                {
                    MessageBox.Show("Ngày hợp lệ!");
                }
                else
                {
                    MessageBox.Show("Ngày không hợp lệ!");
                }
            }
            else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                if (ngay >= 1 && ngay <= 30)
                {
                    MessageBox.Show("Ngày hợp lệ!");
                }
                else 
                {
                    MessageBox.Show("Ngày không hợp lệ!");
                }
            }else if(thang == 2)
            {
                if(ngay >= 1 && (ngay <= 28 || ngay <= 29))
                {
                    MessageBox.Show("Ngày hợp lệ!");
                }
                else
                {
                    MessageBox.Show("Ngày không hợp lệ!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số ngày:1->31 hoặc số tháng:1->12");
            }
        }
    }
}
