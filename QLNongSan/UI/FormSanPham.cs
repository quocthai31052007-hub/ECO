using System;
using System.Windows.Forms;
using QLNongSan.repositories; // Khai báo tầng xử lý database
using QLNongSan.schemas;      // Khai báo tầng đối tượng dữ liệu

namespace QLNongSan.UI
{
    public partial class FormSanPham : Form
    {
        // Khai báo đối tượng DAL để tương tác với cơ sở dữ liệu
        private SanPhamDAL sanPhamDAL = new SanPhamDAL();

        public FormSanPham()
        {
            InitializeComponent();

            // Đăng ký các sự kiện từ code để đảm bảo nút bấm và Form hoạt động
            this.Load += FormSanPham_Load;
            this.btnThem.Click += btnThem_Click;
            this.btnSua.Click += btnSua_Click;
            this.btnXoa.Click += btnXoa_Click;
            this.btnLamMoi.Click += btnLamMoi_Click;
        }

        // 1. Sự kiện Load Form - Tự động tải dữ liệu và căn chỉnh bảng
        private void FormSanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();

            // Tự động căn chỉnh các cột lấp đầy khoảng trống của DataGridView
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Hàm tải dữ liệu lên DataGridView
        private void HienThiDanhSachSanPham()
        {
            try
            {
                dgvSanPham.DataSource = sanPhamDAL.GetListSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách sản phẩm: " + ex.Message, "Lỗi");
            }
        }

        // 2. Sự kiện nút THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaSP.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm!");
                    return;
                }

                SanPhamDTO sp = new SanPhamDTO
                {
                    MaSP = txtMaSP.Text.Trim(),
                    TenSP = txtTenSP.Text.Trim(),
                    LoaiHang = cboLoaiHang.Text,
                    SoLuongTon = int.Parse(txtSoLuongTon.Text.Trim()),
                    GiaBan = decimal.Parse(txtGiaBan.Text.Trim())
                };

                string ketQua = sanPhamDAL.AddSanPham(sp);

                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Thêm sản phẩm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSachSanPham();
                    btnLamMoi.PerformClick();
                }
                else
                {
                    MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho 'Số lượng tồn' và 'Giá bán'!", "Sai định dạng");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Hệ thống");
            }
        }

        // 3. Sự kiện nút SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaSP.Text))
                {
                    MessageBox.Show("Vui lòng chọn hoặc nhập mã sản phẩm cần sửa!", "Thông báo");
                    return;
                }

                SanPhamDTO sp = new SanPhamDTO
                {
                    MaSP = txtMaSP.Text.Trim(),
                    TenSP = txtTenSP.Text.Trim(),
                    LoaiHang = cboLoaiHang.Text,
                    SoLuongTon = int.Parse(txtSoLuongTon.Text.Trim()),
                    GiaBan = decimal.Parse(txtGiaBan.Text.Trim())
                };

                // Giả định bạn đã viết hàm UpdateSanPham trong SanPhamDAL
                string ketQua = sanPhamDAL.UpdateSanPham(sp);

                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSachSanPham();
                    btnLamMoi.PerformClick();
                }
                else
                {
                    MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message);
            }
        }

        // 4. Sự kiện nút XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = txtMaSP.Text.Trim();
                if (string.IsNullOrEmpty(maSP))
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm cần xóa!", "Thông báo");
                    return;
                }

                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // Giả định bạn đã viết hàm DeleteSanPham trong SanPhamDAL
                    string ketQua = sanPhamDAL.DeleteSanPham(maSP);

                    if (ketQua == "SUCCESS")
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo");
                        HienThiDanhSachSanPham();
                        btnLamMoi.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message);
            }
        }

        // 5. Sự kiện nút LÀM MỚI
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboLoaiHang.SelectedIndex = -1;
            txtSoLuongTon.Clear();
            txtGiaBan.Clear();
            txtMaSP.Focus();
        }
    }
}