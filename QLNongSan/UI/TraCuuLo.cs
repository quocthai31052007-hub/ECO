using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QLNongSan.schemas;

namespace QLNongSan.UI
{
    public partial class FormTraCuuLo : Form
    {
        private readonly Application application;
        private string? currentLookupId = null;
        private List<TraCuuLoDTO> ketQuaTimKiem;

        public FormTraCuuLo(Application application)
        {
            this.application = application;
            InitializeComponent();
        }

        private void onInitQRExport(object sender, EventArgs e)
        {
            try
            {
                if (currentLookupId == null)
                {
                    return;
                }
                var fileDialog = new SaveFileDialog
                {
                    Filter = "Bitmap File (*.png)|*.png"
                };
                fileDialog.ShowDialog();
                var fileName = fileDialog.FileName;
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Vui lòng chọn một file ảnh để xuất mã QR.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var dict = new Dictionary<string, string>
            {
                { "id", currentLookupId }
            };
                this.application.lookupQRService.CreateQRFile(dict, fileName);
            } catch (Exception ex)
            {
                MessageBox.Show("Không thể xuất mã QR: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTraCuuLo_Load(object sender, EventArgs e)
        {
            // Không load tất cả khi mở — chờ người dùng nhập tìm kiếm
        }

        // ─── TÌM KIẾM ───────────────────────────────────────────────────

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập mã lô hoặc tên lô cần tra cứu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ketQuaTimKiem = application.lookupRepository.TimKiemLo(tuKhoa);

                dgvKetQua.Rows.Clear();
                if (ketQuaTimKiem.Count == 0)
                {
                    lblKetQua.Text = "Không tìm thấy lô hàng nào phù hợp.";
                    lblKetQua.ForeColor = Color.Red;
                    pnlChiTiet.Visible = false;
                    return;
                }

                lblKetQua.Text = $"Tìm thấy {ketQuaTimKiem.Count} lô hàng:";
                lblKetQua.ForeColor = Color.Green;

                foreach (var lo in ketQuaTimKiem)
                {
                    dgvKetQua.Rows.Add(
                        lo.MaLo,
                        lo.TenLo,
                        lo.TenSanPham ?? "(Chưa cập nhật)",
                        lo.SoLuongNhap,
                        lo.NgayNhap,
                        lo.TrangThai
                    );
                }

                pnlChiTiet.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tra cứu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nhấn Enter trong ô tìm kiếm cũng kích hoạt tìm kiếm
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTimKiem_Click(sender, e);
        }

        // ─── CHỌN DÒNG → HIỆN CHI TIẾT ─────────────────────────────────

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || ketQuaTimKiem == null) return;

            var lo = ketQuaTimKiem[e.RowIndex];
            currentLookupId = lo.MaLo; // Cập nhật ID hiện tại để xuất QR chính xác
            HienThiChiTiet(lo);
        }

        private void HienThiChiTiet(TraCuuLoDTO lo)
        {
            lblChiTietMaLo.Text = "Mã lô: " + (lo.MaLo ?? "-");
            lblChiTietTenLo.Text = "Tên lô: " + (lo.TenLo ?? "-");
            lblChiTietSanPham.Text = "Sản phẩm: " + (lo.TenSanPham ?? "Chưa cập nhật");
            lblChiTietSoLuong.Text = "Số lượng nhập: " + lo.SoLuongNhap.ToString("#,##0");
            lblChiTietNguonGoc.Text = "Nơi nhập: " + (lo.DonViNhap ?? "-");
            lblChiTietNgayNhap.Text = "Ngày nhập: " + (lo.NgayNhap ?? "-");
            lblChiTietNgayMua.Text = "Ngày mua: " + (lo.NgayMua ?? "-");
            lblChiTietLienHe.Text = "Liên hệ: " + (lo.ThongTinLienHe ?? "-");
            lblChiTietMaPN.Text = "Mã phiếu nhập: " + (lo.MaPN ?? "-");
            lblChiTietGhiChu.Text = "Ghi chú: " + (lo.GhiChu ?? "-");

            // Màu trạng thái
            lblChiTietTrangThai.Text = "Trạng thái: " + (lo.TrangThai ?? "-");
            lblChiTietTrangThai.ForeColor = lo.TrangThai switch
            {
                "Còn hàng" => Color.Green,
                "Đã bán" => Color.Gray,
                "Hết hàng" => Color.Red,
                "Đang xử lý" => Color.Orange,
                _ => Color.Black
            };

            pnlChiTiet.Visible = true;
        }

        // ─── NÚT ĐÓNG ───────────────────────────────────────────────────

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}