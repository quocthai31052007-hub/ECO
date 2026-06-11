namespace QLNongSan.schemas
{
    public class ThongTinLoDTO
    {
        public string MaLo { get; set; }
        public string TenLo { get; set; }

        // Thông tin nhập lô
        public int SoLuongNhap { get; set; }
        public string NgayNhap { get; set; }
        public string DonViNhap { get; set; }

        // Thông tin người mua lô
        public string MaKH { get; set; }
        public string HoTenKH { get; set; }   // Join từ KhachHang
        public string NgayMua { get; set; }
        public string ThongTinLienHe { get; set; }

        public string TrangThai { get; set; }
        public string GhiChu { get; set; }

        public ThongTinLoDTO() { }
    }
}