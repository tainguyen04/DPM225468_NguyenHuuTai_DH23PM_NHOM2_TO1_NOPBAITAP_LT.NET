using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTH11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet("dsQLHS");
        SqlDataAdapter daQueQuan;
        SqlDataAdapter daHocSinh;
        SqlConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=.\\Tai;Initial Catalog=QLHS;Integrated Security=True";

            try
            {
                conn.Open();

                // Dữ liệu combobox Quê quán
                string sQueryQueQuan = @"SELECT * FROM quequan";
                daQueQuan = new SqlDataAdapter(sQueryQueQuan, conn);
                daQueQuan.Fill(ds, "tblQueQuan");
                cboQueQuan.DataSource = ds.Tables["tblQueQuan"];
                cboQueQuan.DisplayMember = "tenqq";
                cboQueQuan.ValueMember = "maqq";

                // Dữ liệu datagrid Danh sách học sinh
                string sQueryHocSinh = @"SELECT h.*, q.tenqq FROM hocsinh h, quequan q WHERE h.maqq = q.maqq";
                daHocSinh = new SqlDataAdapter(sQueryHocSinh, conn);
                daHocSinh.Fill(ds, "tblHocSinh");
                dgvHocSinh.DataSource = ds.Tables["tblHocSinh"];

                // Đặt tiêu đề và định dạng cho các cột
                dgvHocSinh.Columns["mahs"].HeaderText = "Mã HS";
                dgvHocSinh.Columns["mahs"].Width = 60;
                dgvHocSinh.Columns["hoten"].HeaderText = "Họ tên";
                dgvHocSinh.Columns["hoten"].Width = 150;
                dgvHocSinh.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                dgvHocSinh.Columns["ngaysinh"].Width = 80;
                dgvHocSinh.Columns["gioitinh"].HeaderText = "Giới tính";
                dgvHocSinh.Columns["gioitinh"].Width = 60;
                dgvHocSinh.Columns["tenqq"].HeaderText = "Quê quán";
                dgvHocSinh.Columns["tenqq"].Width = 100;
                dgvHocSinh.Columns["maqq"].Visible = false;

                // Command Thêm học sinh
                string sThemHS = @"INSERT INTO hocsinh VALUES(@MaHS, @HoTen, @NgaySinh, @GioiTinh, @MaQQ)";
                SqlCommand cmThemHS = new SqlCommand(sThemHS, conn);
                cmThemHS.Parameters.Add("@MaHS", SqlDbType.NVarChar, 10, "mahs");
                cmThemHS.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50, "hoten");
                cmThemHS.Parameters.Add("@NgaySinh", SqlDbType.DateTime, 10, "ngaysinh");
                cmThemHS.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 3, "gioitinh");
                cmThemHS.Parameters.Add("@MaQQ", SqlDbType.NVarChar, 10, "maqq");
                daHocSinh.InsertCommand = cmThemHS;

                // Command Sửa học sinh
                string sSuaHS = @"UPDATE hocsinh SET hoten=@HoTen, ngaysinh=@NgaySinh, 
                                gioitinh=@GioiTinh, maqq=@MaQQ WHERE mahs=@MaHS";
                SqlCommand cmSuaHS = new SqlCommand(sSuaHS, conn);
                cmSuaHS.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50, "hoten");
                cmSuaHS.Parameters.Add("@NgaySinh", SqlDbType.DateTime, 10, "ngaysinh");
                cmSuaHS.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 3, "gioitinh");
                cmSuaHS.Parameters.Add("@MaQQ", SqlDbType.NVarChar, 10, "maqq");
                cmSuaHS.Parameters.Add("@MaHS", SqlDbType.NVarChar, 10, "mahs");
                daHocSinh.UpdateCommand = cmSuaHS;

                // Command Xóa học sinh
                string sXoaHS = @"DELETE FROM hocsinh WHERE mahs=@MaHS";
                SqlCommand cmXoaHS = new SqlCommand(sXoaHS, conn);
                cmXoaHS.Parameters.Add("@MaHS", SqlDbType.NVarChar, 10, "mahs");
                daHocSinh.DeleteCommand = cmXoaHS;

                conn.Close();

                // Vô hiệu hóa nút Lưu và Hủy ban đầu
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHocSinh.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvHocSinh.SelectedRows[0];
                txtMaHS.Text = dr.Cells["mahs"].Value.ToString();
                txtHoTen.Text = dr.Cells["hoten"].Value.ToString();

                if (DateTime.TryParse(dr.Cells["ngaysinh"].Value.ToString(), out DateTime ngaySinh))
                {
                    dtpNgaySinh.Value = ngaySinh;
                }

                if (dr.Cells["gioitinh"].Value.ToString() == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }

                cboQueQuan.SelectedValue = dr.Cells["maqq"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                // Kiểm tra mã học sinh không trùng
                foreach (DataRow row in ds.Tables["tblHocSinh"].Rows)
                {
                    if (row["mahs"].ToString() == txtMaHS.Text)
                    {
                        MessageBox.Show("Mã học sinh đã tồn tại!");
                        return;
                    }
                }

                // Thêm 1 dòng vào bảng tblHocSinh
                DataRow newRow = ds.Tables["tblHocSinh"].NewRow();
                newRow["mahs"] = txtMaHS.Text;
                newRow["hoten"] = txtHoTen.Text;
                newRow["ngaysinh"] = dtpNgaySinh.Value;
                newRow["gioitinh"] = radNam.Checked ? "Nam" : "Nữ";
                newRow["maqq"] = cboQueQuan.SelectedValue;
                newRow["tenqq"] = cboQueQuan.Text;

                ds.Tables["tblHocSinh"].Rows.Add(newRow);

                MessageBox.Show("Thêm học sinh thành công!");
                LamMoi();

                // Kích hoạt nút Lưu và Hủy
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.SelectedRows.Count > 0 && KiemTraDuLieu())
            {
                DataGridViewRow dr = dgvHocSinh.SelectedRows[0];
                dr.Cells["hoten"].Value = txtHoTen.Text;
                dr.Cells["ngaysinh"].Value = dtpNgaySinh.Value;
                dr.Cells["gioitinh"].Value = radNam.Checked ? "Nam" : "Nữ";
                dr.Cells["maqq"].Value = cboQueQuan.SelectedValue;
                dr.Cells["tenqq"].Value = cboQueQuan.Text;

                MessageBox.Show("Cập nhật thông tin thành công!");

                // Kích hoạt nút Lưu và Hủy
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học sinh cần sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa học sinh này?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgvHocSinh.Rows.RemoveAt(dgvHocSinh.SelectedRows[0].Index);
                    LamMoi();
                    MessageBox.Show("Xóa học sinh thành công!");

                    // Kích hoạt nút Lưu và Hủy
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học sinh cần xóa!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                daHocSinh.Update(ds, "tblHocSinh");
                conn.Close();
                MessageBox.Show("Lưu dữ liệu thành công!");

                // Vô hiệu hóa nút Lưu và Hủy
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy bỏ các thay đổi?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ds.Tables["tblHocSinh"].RejectChanges();
                LamMoi();
                MessageBox.Show("Đã hủy bỏ các thay đổi!");

                // Vô hiệu hóa nút Lưu và Hủy
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrEmpty(txtMaHS.Text))
            {
                MessageBox.Show("Vui lòng nhập mã học sinh!");
                txtMaHS.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return false;
            }

            return true;
        }

        private void LamMoi()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            radNam.Checked = true;
            if (cboQueQuan.Items.Count > 0)
                cboQueQuan.SelectedIndex = 0;
            txtMaHS.Focus();
        }
    }
}