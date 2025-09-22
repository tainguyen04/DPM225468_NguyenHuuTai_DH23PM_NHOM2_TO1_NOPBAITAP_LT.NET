using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtKQ.Text = "Bạn đã chọn website ";
            txtKQ.Text += lstWeb.SelectedItem.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.lstWeb.Items.Add("Tuổi trẻ");
            this.lstWeb.Items.Add("Thanh niên");
            this.lstWeb.Items.Add("VNExpress");
            this.lstWeb.Items.Add("Dân trí");
            this.lstWeb.Items.Add("Công an");
            this.lstWeb.SelectedItem = "Tuổi trẻ";
        }
    }
}
