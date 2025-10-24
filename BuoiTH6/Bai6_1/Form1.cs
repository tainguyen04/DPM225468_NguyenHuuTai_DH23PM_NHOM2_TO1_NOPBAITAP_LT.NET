using System;
using System.IO;
using System.Windows.Forms;
namespace Bai6_1
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }
        private void btnFont_Click(object sender, EventArgs e) { if (fontDialog1.ShowDialog() == DialogResult.OK) richTextBox1.Font = fontDialog1.Font; }
        private void btnColor_Click(object sender, EventArgs e) { if (colorDialog1.ShowDialog() == DialogResult.OK) richTextBox1.ForeColor = colorDialog1.Color; }
        private void btnOpen_Click(object sender, EventArgs e) { if (openFileDialog1.ShowDialog() == DialogResult.OK) { try { richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName); } catch { MessageBox.Show("Không thể mở file."); } } }
        private void btnSave_Click(object sender, EventArgs e) { if (saveFileDialog1.ShowDialog() == DialogResult.OK) { try { File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text); } catch { MessageBox.Show("Không thể lưu file."); } } }
        private void btnThoat_Click(object sender, EventArgs e) { this.Close(); }
    }
}
