using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khi form khởi động, nạp cây thư mục gốc (ví dụ ổ D:)
            string rootPath = "Z:\\"; // Có thể đổi sang ổ khác
            DirectoryInfo dir = new DirectoryInfo(rootPath);
            TreeNode rootNode = new TreeNode(dir.Name) { Tag = dir };
            treeView1.Nodes.Add(rootNode);
            LoadDirectories(dir, rootNode);
        }

        private void LoadDirectories(DirectoryInfo dirInfo, TreeNode node)
        {
            try
            {
                foreach (var dir in dirInfo.GetDirectories())
                {
                    TreeNode subNode = new TreeNode(dir.Name) { Tag = dir };
                    node.Nodes.Add(subNode);
                    // Gọi đệ quy để nạp tiếp thư mục con
                    LoadDirectories(dir, subNode);
                }
            }
            catch
            {
                // Bỏ qua thư mục không truy cập được (vd: System)
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Khi chọn một thư mục trên TreeView
            flowLayoutPanel1.Controls.Clear();

            DirectoryInfo dir = (DirectoryInfo)e.Node.Tag;
            string[] imageFiles = Directory.GetFiles(dir.FullName, "*.*")
                .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
                         || f.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
                         || f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase)
                         || f.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                .ToArray();

            foreach (string file in imageFiles)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(file);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Width = 120;
                pic.Height = 90;
                pic.Margin = new Padding(5);
                pic.Tag = file; // Lưu đường dẫn file ảnh
                pic.Click += Pic_Click; // Gắn sự kiện click

                flowLayoutPanel1.Controls.Add(pic);
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            // Khi người dùng nhấn vào một ảnh nhỏ
            PictureBox pic = sender as PictureBox;
            string filePath = pic.Tag.ToString();
            pictureBoxMain.Image = Image.FromFile(filePath);
            pictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
