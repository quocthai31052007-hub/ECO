namespace QLNongSan.schemas
{
    // DTO hiển thị thông tin lô hàng cho khách hàng tra cứu
    public class TraCuuLoDTO
    {
        public string MaLo { get; set; }
        public string TenLo { get; set; }
        public int SoLuongNhap { get; set; }
        public string NgayNhap { get; set; }
        public string? DonViNhap { get; set; }       // Nơi nhập hàng
        public string? NgayMua { get; set; }
        public string? TrangThai { get; set; }
        public string? GhiChu { get; set; }
        public string? TenSanPham { get; set; }      // JOIN từ SanPham
        public string? TenKhachHang { get; set; }    // JOIN từ KhachHang
        public string? ThongTinLienHe { get; set; }
        public string? MaPN { get; set; }
    }
}