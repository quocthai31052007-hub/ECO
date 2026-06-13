using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QLNongSan.repositories;
using QLNongSan.schemas;

namespace QLNongSan.UI
{
    public partial class FormNhanVien : Form
    {
        private NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public FormNhanVien()
        {
            InitializeComponent();
            DinhDangBieuMauLuo();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            HienThiData();
        }

        private void DinhDangBieuMauLuo()
        {
            // Cấu hình giao diện nền sáng phẳng (Light Mode) giống hệt ảnh mẫu Khách hàng
            dgvNhanVien.EnableHeadersVisualStyles = false;

            // Tiêu đề cột nền màu xám nhạt mịn, chữ đen thanh lịch
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(225, 228, 232);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

            // Hàng dữ liệu nền trắng, chữ đen gọn gàng
            dgvNhanVien.DefaultCellStyle.BackColor = Color.White;
            dgvNhanVien.DefaultCellStyle.ForeColor = Color.Black;
            dgvNhanVien.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Màu xanh khi click chọn dòng
            dgvNhanVien.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvNhanVien.DefaultCellStyle.SelectionForeColor = Color.White;

            // Đường lưới mảnh phân tách ô dữ liệu
            dgvNhanVien.GridColor = Color.FromArgb(220, 220, 220);
        }

        private void HienThiData()
        {
            try
            {
                if (dgvNhanVien == null) return;

                // BƯỚC 1: Xóa sạch các cột cũ bị lỗi cấu hình trong giao diện Design
                dgvNhanVien.DataSource = null;
                dgvNhanVien.Columns.Clear();

                // BƯỚC 2: Gọi tầng DAL để lấy DataTable chứa đủ 6 trường (gồm cả SDT và DiaChi)
                DataTable dt = nhanVienDAL.GetListNhanVien();

                if (dt != null)
                {
                    // BƯỚC 3: Khóa tính năng tự tạo cột thô lộn xộn của WinForms
                    dgvNhanVien.AutoGenerateColumns = false;

                    // BƯỚC 4: Tự tay định nghĩa và gán DataPropertyName khớp 100% với SQL câu lệnh SELECT

                    // 1. Cột Mã nhân viên
                    DataGridViewTextBoxColumn colMaNV = new DataGridViewTextBoxColumn();
                    colMaNV.DataPropertyName = "MaNV"; // Tên cột trong SQL
                    colMaNV.HeaderText = "Mã NV";
                    colMaNV.Name = "MaNV";
                    colMaNV.Width = 70;

                    // 2. Cột Họ và tên
                    DataGridViewTextBoxColumn colHoTen = new DataGridViewTextBoxColumn();
                    colHoTen.DataPropertyName = "HoTen"; // Tên cột trong SQL
                    colHoTen.HeaderText = "Họ và Tên";
                    colHoTen.Name = "HoTen";
                    colHoTen.Width = 160;

                    // 3. Cột Số điện thoại (Ép map trực tiếp vào trường dữ liệu "SDT")
                    DataGridViewTextBoxColumn colSDT = new DataGridViewTextBoxColumn();
                    colSDT.DataPropertyName = "SDT"; // Tên cột chính xác trong ảnh image_6ad87d.png của bạn
                    colSDT.HeaderText = "Số Điện Thoại";
                    colSDT.Name = "SDT";
                    colSDT.Width = 120;

                    // 4. Cột Chức vụ (Map vào trường VaiTro của SQL)
                    DataGridViewTextBoxColumn colChucVu = new DataGridViewTextBoxColumn();
                    colChucVu.DataPropertyName = "VaiTro"; // Tên cột trong SQL
                    colChucVu.HeaderText = "Chức Vụ";
                    colChucVu.Name = "VaiTro";
                    colChucVu.Width = 100;

                    // 5. Cột Địa chỉ (Ép map trực tiếp vào trường dữ liệu "DiaChi")
                    DataGridViewTextBoxColumn colDiaChi = new DataGridViewTextBoxColumn();
                    colDiaChi.DataPropertyName = "DiaChi"; // Tên cột chính xác trong ảnh image_6ad87d.png của bạn
                    colDiaChi.HeaderText = "Địa Chỉ";
                    colDiaChi.Name = "DiaChi";
                    colDiaChi.Width = 180;

                    // BƯỚC 5: Thêm các cột chuẩn này vào lưới DataGridView
                    dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] {
                colMaNV,
                colHoTen,
                colSDT,
                colChucVu,
                colDiaChi
            });

                    // BƯỚC 6: Đổ dữ liệu sạch vào bảng
                    dgvNhanVien.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private NhanVienDTO LayDuLieuForm()
        {
            return new NhanVienDTO
            {
                MaNV = txtMaNV.Text.Trim(),
                TenNV = txtHoTen.Text.Trim(),
                ChucVu = txtChucVu.Text.Trim(),

                // PHẢI BỔ SUNG 2 DÒNG NÀY để hứng dữ liệu người dùng gõ trên giao diện
                SDT = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };
        }

        private void LamMoiForm()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtChucVu.Clear();
            txtDiaChi.Clear();
            txtMaNV.ReadOnly = false;
            txtMaNV.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Mã nhân viên và Họ tên!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhanVienDTO nv = LayDuLieuForm();
            string ketQua = nhanVienDAL.AddNhanVien(nv);

            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiData();
                LamMoiForm();
            }
            else
            {
                MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần chỉnh sửa từ bảng!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhanVienDTO nv = LayDuLieuForm();
            string ketQua = nhanVienDAL.UpdateNhanVien(nv);

            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiData();
                LamMoiForm();
            }
            else
            {
                MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Hãy chọn nhân viên từ bảng dữ liệu để xóa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Xác nhận xóa nhân viên [{txtHoTen.Text}] khỏi hệ thống?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string ketQua = nhanVienDAL.DeleteNhanVien(txtMaNV.Text.Trim());

                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiData();
                    LamMoiForm();
                }
                // Bắt lỗi xung đột dữ liệu khóa ngoại (Lỗi trong ảnh của bạn)
                else if (ketQua.Contains("REFERENCE constraint") || ketQua.Contains("FK__HoaDon"))
                {
                    MessageBox.Show("Không thể xóa nhân viên này vì họ đã lập hóa đơn bán hàng!\nĐể đảm bảo an toàn dữ liệu, bạn không thể xóa hoàn toàn.",
                                    "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNhanVien.CurrentRow != null)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                // Gán Mã NV
                if (dgvNhanVien.Columns.Contains("MaNV")) txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
                else if (dgvNhanVien.Columns.Contains("colMaNV")) txtMaNV.Text = row.Cells["colMaNV"].Value?.ToString();

                // Gán Họ Tên
                if (dgvNhanVien.Columns.Contains("HoTen")) txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                else if (dgvNhanVien.Columns.Contains("colHoTen")) txtHoTen.Text = row.Cells["colHoTen"].Value?.ToString();

                // Gán Số Điện Thoại (Đã sửa đổi & tối ưu)
                if (dgvNhanVien.Columns.Contains("SDT")) txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                else if (dgvNhanVien.Columns.Contains("SoDienThoai")) txtSDT.Text = row.Cells["SoDienThoai"].Value?.ToString();
                else if (dgvNhanVien.Columns.Contains("colSDT")) txtSDT.Text = row.Cells["colSDT"].Value?.ToString();

                // Gán Chức Vụ
                if (dgvNhanVien.Columns.Contains("ChucVu")) txtChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                else if (dgvNhanVien.Columns.Contains("colChucVu")) txtChucVu.Text = row.Cells["colChucVu"].Value?.ToString();

                // Gán Địa Chỉ (Đã bổ sung cột thiếu)
                if (dgvNhanVien.Columns.Contains("DiaChi")) txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                else if (dgvNhanVien.Columns.Contains("colDiaChi")) txtDiaChi.Text = row.Cells["colDiaChi"].Value?.ToString();
            }
        }
    }
}