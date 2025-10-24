using System;
using System.Windows.Forms;

namespace Bai6_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idx = dataGridView1.Rows.Add();
            dataGridView1.Rows[idx].Cells[0].Value = txtMa.Text;
            dataGridView1.Rows[idx].Cells[1].Value = txtHoTen.Text;
            dataGridView1.Rows[idx].Cells[2].Value = dateTimePicker1.Value.ToShortDateString();
            dataGridView1.Rows[idx].Cells[3].Value = rdNam.Checked ? "Nam" : "Nữ";
            dataGridView1.Rows[idx].Cells[4].Value = txtDienThoai.Text;
            dataGridView1.Rows[idx].Cells[5].Value = cbQueQuan.Text;

            ClearInputs();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                dataGridView1.Rows.Remove(r);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 dòng để sửa.");
                return;
            }

            var r = dataGridView1.SelectedRows[0];
            r.Cells[0].Value = txtMa.Text;
            r.Cells[1].Value = txtHoTen.Text;
            r.Cells[2].Value = dateTimePicker1.Value.ToShortDateString();
            r.Cells[3].Value = rdNam.Checked ? "Nam" : "Nữ";
            r.Cells[4].Value = txtDienThoai.Text;
            r.Cells[5].Value = cbQueQuan.Text;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            var r = dataGridView1.SelectedRows[0];
            txtMa.Text = r.Cells[0].Value?.ToString();
            txtHoTen.Text = r.Cells[1].Value?.ToString();

            if (DateTime.TryParse(r.Cells[2].Value?.ToString(), out var d))
                dateTimePicker1.Value = d;
            else
                dateTimePicker1.Value = DateTime.Now;

            if ((r.Cells[3].Value?.ToString() ?? "") == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;

            txtDienThoai.Text = r.Cells[4].Value?.ToString();
            cbQueQuan.Text = r.Cells[5].Value?.ToString();
        }

        private void ClearInputs()
        {
            txtMa.Clear();
            txtHoTen.Clear();
            txtDienThoai.Clear();
            cbQueQuan.SelectedIndex = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
