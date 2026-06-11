namespace QLNongSan.schemas
{
    // Phiếu bán hàng (header)
    public class PhieuBanDTO
    {
        public string MaPB { get; set; }
        public string KhachHang { get; set; }
        public string NhanVienBan { get; set; }
        public string NgayBan { get; set; }
        public string PhuongThucTT { get; set; }
        public decimal TongThanhToan { get; set; }
    }

    // Chi tiết từng sản phẩm trong phiếu bán
    public class ChiTietBanDTO
    {
        public string MaPB { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DVT { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public decimal ChietKhau { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
