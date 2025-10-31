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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void LamMo()
        {
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBanKinh.Enabled = false;
            txtCanh.Focus();
            txtCanh.Enabled = true;
            rdbHV.Checked = true;
        }
        public void ChonHCN()
        {
            txtCanh.Enabled = false;
            txtDai.Enabled = true;
            txtRong.Enabled = true;
            txtBanKinh.Enabled = false;
            txtDai.Focus();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
           
                LamMo();
            
        }

        private void rdbHCN_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbHCN.Checked)
            ChonHCN();
        }

        private void rdbHV_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbHV.Checked)
            LamMo();
        }

        private void rdbHT_CheckedChanged(object sender, EventArgs e)
        {
            if ((rdbHT.Checked)){
                txtCanh.Enabled = false;
                txtDai.Enabled = false;
                txtRong.Enabled = false;
                txtBanKinh.Enabled = true;
                txtBanKinh.Focus();
            }
            
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rdbHCN.Checked)
            {
                Form3 frm3 = new Form3(Convert.ToDecimal((txtDai.Text)), Convert.ToDecimal((txtRong.Text)));
                frm3.ShowDialog();
                
            }else if (rdbHV.Checked)
            {
                Form2 frm = new Form2(Convert.ToDecimal(txtCanh.Text));
                frm.ShowDialog();
                
            }
            else if (rdbHT.Checked)
            {
                Form4 frm4 = new Form4(Convert.ToDouble((txtBanKinh.Text)));
                frm4.ShowDialog();
            }
                
            

        }
    }
}
