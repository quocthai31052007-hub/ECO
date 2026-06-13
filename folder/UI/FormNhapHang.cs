using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Hoặc System.Data.SqlClient tùy thuộc thư viện bạn đang dùng

namespace QLNongSan.UI
{
    public partial class FormNhapHang : Form
    {
        private readonly Application application;

        // Bảng tạm lưu chi tiết các mặt hàng chuẩn bị nhập kho
        private DataTable dtChiTietTam;

        public FormNhapHang(Application application)
        {
            this.application = application;
            InitializeComponent();
            KhoiTaoBangTam();
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            LoadComboboxNhanVien();
            LoadComboboxNhaCungCap();
            LoadComboboxSanPham();
            LamMoiForm();
        }

        // Tạo cấu trúc bảng tạm để quản lý danh sách sản phẩm trên GridView
        private void KhoiTaoBangTam()
        {
            dtChiTietTam = new DataTable();
            dtChiTietTam.Columns.Add("MaSP", typeof(string));
            dtChiTietTam.Columns.Add("TenSP", typeof(string));
            dtChiTietTam.Columns.Add("SoLuong", typeof(int));
            dtChiTietTam.Columns.Add("GiaNhap", typeof(decimal));

            // Cột tự động tính toán: Thành tiền = Số lượng * Giá nhập
            dtChiTietTam.Columns.Add("ThanhTien", typeof(decimal), "SoLuong * GiaNhap");

            dgvChiTiet.DataSource = dtChiTietTam;

            // Định dạng tiêu đề cột hiển thị lên màn hình
            dgvChiTiet.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
            dgvChiTiet.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dgvChiTiet.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvChiTiet.Columns["GiaNhap"].HeaderText = "Giá Nhập (VNĐ)";
            dgvChiTiet.Columns["ThanhTien"].HeaderText = "Thành Tiền (VNĐ)";

            // Định dạng hiển thị số tiền cho đẹp mắt
            dgvChiTiet.Columns["GiaNhap"].DefaultCellStyle.Format = "#,##0";
            dgvChiTiet.Columns["ThanhTien"].DefaultCellStyle.Format = "#,##0";
        }

        // Tự động tính tổng tiền từ bảng tạm và cập nhật lên giao diện
        // Tìm đoạn code này:
        private void TinhTongTienHiaDon()
        {
            decimal tongTien = 0;
            foreach (DataRow row in dtChiTietTam.Rows)
            {
                if (row["ThanhTien"] != DBNull.Value)
                {
                    // SỬA TẠI ĐÂY: Đổi 'toDecimal' thành 'ToDecimal' (Viết hoa chữ T)
                    tongTien += Convert.ToDecimal(row["ThanhTien"]);
                }
            }
            lblTongTien.Text = tongTien.ToString("#,##0") + " VNĐ";
        }

        // --- TẢI DỮ LIỆU LÊN CÁC COMBOBOX ---
        private void LoadComboboxNhanVien()
        {
            string query = "SELECT MaNV, HoTen FROM NhanVien"; // Đổi lại tên bảng/khóa nếu cần
            FillCombo(query, cboNhanVien, "HoTen", "MaNV");
        }

        private void LoadComboboxNhaCungCap()
        {
            string query = "SELECT MaNCC, TenNCC FROM NhaCungCap";
            FillCombo(query, cboNhaCungCap, "TenNCC", "MaNCC");
        }

        private void LoadComboboxSanPham()
        {
            string query = "SELECT MaSP, TenSP FROM SanPham";
            FillCombo(query, cboSanPham, "TenSP", "MaSP");
        }

        private void FillCombo(string query, ComboBox combo, string displayMember, string valueMember)
        {
            try
            {
                using (SqlConnection conn = application.database.GetConnection())
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    combo.DataSource = dt;
                    combo.DisplayMember = displayMember;
                    combo.ValueMember = valueMember;
                    combo.SelectedIndex = -1; // Để trống mặc định ban đầu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // --- XỬ LÝ SỰ KIỆN KHỐI NÚT CHỨC NĂNG ---

        // 1. Thêm sản phẩm vào lưới tạm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn sản phẩm!"); return; }
            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0) { MessageBox.Show("Số lượng phải là số nguyên dương!"); return; }
            if (!decimal.TryParse(txtGiaNhap.Text.Trim(), out decimal giaNhap) || giaNhap < 0) { MessageBox.Show("Giá nhập không hợp lệ!"); return; }

            string maSP = cboSanPham.SelectedValue.ToString();
            string tenSP = cboSanPham.Text;

            // Kiểm tra xem sản phẩm đã có trong danh sách chuẩn bị nhập chưa, nếu có thì cộng dồn số lượng
            foreach (DataRow row in dtChiTietTam.Rows)
            {
                if (row["MaSP"].ToString() == maSP)
                {
                    row["SoLuong"] = Convert.ToInt32(row["SoLuong"]) + soLuong;
                    row["GiaNhap"] = giaNhap; // Cập nhật lại giá nhập mới nhất
                    TinhTongTienHiaDon();
                    return;
                }
            }

            // Nếu là sản phẩm mới hoàn toàn thì thêm dòng mới vào bảng tạm
            dtChiTietTam.Rows.Add(maSP, tenSP, soLuong, giaNhap);
            TinhTongTienHiaDon();
        }

        // 2. Xóa sản phẩm được chọn ra khỏi lưới tạm
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null) { MessageBox.Show("Chọn một sản phẩm trên lưới dữ liệu để xóa!"); return; }

            if (MessageBox.Show("Xóa sản phẩm này khỏi danh sách nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvChiTiet.Rows.Remove(dgvChiTiet.CurrentRow);
                TinhTongTienHiaDon();
            }
        }

        // 3. Thực hiện lưu toàn bộ hóa đơn nhập (Master-Detail) vào Database
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPN.Text)) { MessageBox.Show("Vui lòng nhập Mã phiếu nhập!"); return; }
            if (cboNhanVien.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn Nhân viên lập phiếu!"); return; }
            if (cboNhaCungCap.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn Nhà cung cấp!"); return; }
            if (dtChiTietTam.Rows.Count == 0) { MessageBox.Show("Danh sách sản phẩm nhập đang trống. Vui lòng thêm sản phẩm trước!"); return; }

            using (SqlConnection conn = application.database.GetConnection())
            {
                conn.Open();
                // Sử dụng Transaction để đảm bảo an toàn: Thất bại một bước là hủy toàn bộ dữ liệu tránh lỗi rác
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // Bước 3.1: Lưu thông tin bảng chính (PhieuNhap)
                        // Bỏ MaPN ra khỏi INSERT, để SQL tự sinh
                        string sqlMaster = "INSERT INTO PhieuNhap (MaNV, MaNCC, NgayNhap) VALUES (@MaNV, @MaNCC, @NgayNhap)";
                        using (SqlCommand cmdMaster = new SqlCommand(sqlMaster, conn, trans))
                        {
                            cmdMaster.Parameters.AddWithValue("@MaNV", cboNhanVien.SelectedValue);
                            cmdMaster.Parameters.AddWithValue("@MaNCC", cboNhaCungCap.SelectedValue);
                            cmdMaster.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
                            cmdMaster.ExecuteNonQuery();
                        }

                        // Bước 3.2: Duyệt vòng lặp lưu chi tiết từng món hàng (ChiTietPhieuNhap)
                        string sqlDetail = "INSERT INTO ChiTietPhieuNhap (MaPN, MaSP, SoLuong, GiaNhap) VALUES (@MaPN, @MaSP, @SoLuong, @GiaNhap)";
                        foreach (DataRow row in dtChiTietTam.Rows)
                        {
                            using (SqlCommand cmdDetail = new SqlCommand(sqlDetail, conn, trans))
                            {
                                cmdDetail.Parameters.AddWithValue("@MaPN", txtMaPN.Text.Trim());
                                cmdDetail.Parameters.AddWithValue("@MaSP", row["MaSP"]);
                                cmdDetail.Parameters.AddWithValue("@SoLuong", row["SoLuong"]);
                                cmdDetail.Parameters.AddWithValue("@GiaNhap", row["GiaNhap"]);
                                cmdDetail.ExecuteNonQuery();
                            }
                        }

                        // Hoàn tất lưu dữ liệu thành công
                        trans.Commit();
                        MessageBox.Show("Lưu phiếu nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LamMoiForm();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback(); // Hủy bỏ thao tác nếu xuất hiện lỗi bất kỳ
                        MessageBox.Show("Lỗi hệ thống khi lưu phiếu nhập: " + ex.Message, "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 4. Làm mới sạch sẽ form để chuẩn bị lên phiếu nhập tiếp theo
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            // Tự động tạo mã phiếu nhập ngẫu nhiên theo thời gian thực (Tránh trùng lặp mã)
            txtMaPN.Text = "PN" + DateTime.Now.ToString("yyyyMMddHHmmss");

            cboNhanVien.SelectedIndex = -1;
            cboNhaCungCap.SelectedIndex = -1;
            cboSanPham.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtGiaNhap.Clear();
            dtpNgayNhap.Value = DateTime.Now;

            dtChiTietTam.Rows.Clear();
            TinhTongTienHiaDon();
        }
    }
}