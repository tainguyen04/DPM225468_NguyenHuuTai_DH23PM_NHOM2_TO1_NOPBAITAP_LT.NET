using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tạo các node A -> Z khi form load
            for (char c = 'A'; c <= 'Z'; c++)
            {
                treeView1.Nodes.Add(c.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text.Trim();
            string ten = txtTen.Text.Trim();

            if (string.IsNullOrEmpty(ho) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ và Tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char firstChar = char.ToUpper(ten[0]);
            TreeNode targetNode = null;

            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Text == firstChar.ToString())
                {
                    targetNode = node;
                    break;
                }
            }

            if (targetNode != null)
            {
                targetNode.Nodes.Add($"{ten}, {ho}");
                targetNode.Expand();
            }

            txtTen.Clear();
            txtHo.Clear();
            txtTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
