using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTH10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet("dsQLNV");
        SqlDataAdapter daChucVu;
        SqlDataAdapter daNhanVien;
        SqlConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=.\\Tai;Initial Catalog=QLNV;Integrated Security=True";

            try
            {
                conn.Open();

                // Dữ liệu combobox Chức vụ
                string sQueryChucVu = @"select * from chucvu";
                daChucVu = new SqlDataAdapter(sQueryChucVu, conn);
                daChucVu.Fill(ds, "tblChucVu");
                cboChucVu.DataSource = ds.Tables["tblChucVu"];
                cboChucVu.DisplayMember = "tencv";
                cboChucVu.ValueMember = "macv";

                // Dữ liệu datagrid Danh sách nhân viên
                string sQueryNhanVien = @"select n.*, c.tencv from nhanvien n, chucvu c where n.macv=c.macv";
                daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
                daNhanVien.Fill(ds, "tblDSNhanVien");
                dgDSNhanVien.DataSource = ds.Tables["tblDSNhanVien"];

                // Đặt tiêu đề và định dạng cho các cột
                dgDSNhanVien.Columns["manv"].HeaderText = "Mã số";
                dgDSNhanVien.Columns["manv"].Width = 60;
                dgDSNhanVien.Columns["holot"].HeaderText = "Họ lót";
                dgDSNhanVien.Columns["holot"].Width = 120;
                dgDSNhanVien.Columns["tennv"].HeaderText = "Tên";
                dgDSNhanVien.Columns["tennv"].Width = 80;
                dgDSNhanVien.Columns["phai"].HeaderText = "Giới tính";
                dgDSNhanVien.Columns["phai"].Width = 60;
                dgDSNhanVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                dgDSNhanVien.Columns["ngaysinh"].Width = 80;
                dgDSNhanVien.Columns["tencv"].HeaderText = "Chức vụ";
                dgDSNhanVien.Columns["tencv"].Width = 100;
                dgDSNhanVien.Columns["macv"].Visible = false;

                // Command Thêm nhân viên
                string sThemNV = @"insert into nhanvien values(@MaNV, @HoLot, @TenNV, @Phai, @NgaySinh, @MaCV)";
                SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
                cmThemNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
                cmThemNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
                cmThemNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
                cmThemNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
                cmThemNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10, "ngaysinh");
                cmThemNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");
                daNhanVien.InsertCommand = cmThemNV;

                // Command Sửa nhân viên
                string sSuaNV = @"update nhanvien set holot=@HoLot, tennv=@TenNV, phai=@Phai, 
                                ngaysinh=@NgaySinh, macv=@MaCV where manv=@MaNV";
                SqlCommand cmSuaNV = new SqlCommand(sSuaNV, conn);
                cmSuaNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
                cmSuaNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
                cmSuaNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
                cmSuaNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10, "ngaysinh");
                cmSuaNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");
                cmSuaNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
                daNhanVien.UpdateCommand = cmSuaNV;

                // Command Xóa nhân viên
                string sXoaNV = @"delete from nhanvien where manv=@MaNV";
                SqlCommand cmXoaNV = new SqlCommand(sXoaNV, conn);
                cmXoaNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
                daNhanVien.DeleteCommand = cmXoaNV;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void dgDSNhanVien_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
                txtMaNV.Text = dr.Cells["manv"].Value.ToString();
                txtHoLot.Text = dr.Cells["holot"].Value.ToString();
                txtTen.Text = dr.Cells["tennv"].Value.ToString();

                if (dr.Cells["phai"].Value.ToString() == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }

                dtpNgaySinh.Text = dr.Cells["ngaysinh"].Value.ToString();
                cboChucVu.SelectedValue = dr.Cells["macv"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                // Kiểm tra mã nhân viên không trùng
                foreach (DataRow row in ds.Tables["tblDSNhanVien"].Rows)
                {
                    if (row["manv"].ToString() == txtMaNV.Text)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!");
                        return;
                    }
                }

                // Thêm 1 dòng vào bảng tblDSNhanVien
                DataRow newRow = ds.Tables["tblDSNhanVien"].NewRow();
                newRow["manv"] = txtMaNV.Text;
                newRow["holot"] = txtHoLot.Text;
                newRow["tennv"] = txtTen.Text;
                newRow["phai"] = radNam.Checked ? "Nam" : "Nữ";
                newRow["ngaysinh"] = dtpNgaySinh.Value;
                newRow["macv"] = cboChucVu.SelectedValue;
                newRow["tencv"] = cboChucVu.Text;

                ds.Tables["tblDSNhanVien"].Rows.Add(newRow);

                MessageBox.Show("Thêm nhân viên thành công!");
                LamMoi();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.SelectedRows.Count > 0 && KiemTraDuLieu())
            {
                DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
                dr.Cells["holot"].Value = txtHoLot.Text;
                dr.Cells["tennv"].Value = txtTen.Text;
                dr.Cells["phai"].Value = radNam.Checked ? "Nam" : "Nữ";
                dr.Cells["ngaysinh"].Value = dtpNgaySinh.Value;
                dr.Cells["macv"].Value = cboChucVu.SelectedValue;
                dr.Cells["tencv"].Value = cboChucVu.Text;

                MessageBox.Show("Cập nhật thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgDSNhanVien.Rows.RemoveAt(dgDSNhanVien.SelectedRows[0].Index);
                    LamMoi();
                    MessageBox.Show("Xóa nhân viên thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                daNhanVien.Update(ds, "tblDSNhanVien");
                conn.Close();
                MessageBox.Show("Lưu dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblDSNhanVien"].RejectChanges();
            LamMoi();
            MessageBox.Show("Đã hủy bỏ các thay đổi!");
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
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!");
                txtMaNV.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtHoLot.Text))
            {
                MessageBox.Show("Vui lòng nhập họ lót!");
                txtHoLot.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên!");
                txtTen.Focus();
                return false;
            }

            return true;
        }

        private void LamMoi()
        {
            txtMaNV.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            radNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            if (cboChucVu.Items.Count > 0)
                cboChucVu.SelectedIndex = 0;
            txtMaNV.Focus();
        }
    }
}