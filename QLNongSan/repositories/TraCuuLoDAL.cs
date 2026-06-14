using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using QLNongSan.schemas;

namespace QLNongSan.Repositories
{
    using Databases;

    public class TraCuuLoDAL
    {
        public required SQLServerFactory factory;

        // ─── Tra cứu theo mã lô hoặc tên lô (tìm kiếm linh hoạt) ───
        public List<TraCuuLoDTO> TimKiemLo(string tuKhoa)
        {
            var list = new List<TraCuuLoDTO>();

            string query = @"
                SELECT 
                    tl.MaLo,
                    tl.TenLo,
                    tl.SoLuongNhap,
                    CONVERT(varchar, tl.NgayNhap, 103) AS NgayNhap,
                    tl.DonViNhap,
                    CONVERT(varchar, tl.NgayMua, 103)  AS NgayMua,
                    tl.TrangThai,
                    tl.GhiChu,
                    tl.ThongTinLienHe,
                    tl.MaPN,
                    sp.TenSP   AS TenSanPham,
                    kh.HoTen   AS TenKhachHang
                FROM ThongTinLo tl
                LEFT JOIN SanPham    sp ON sp.MaSP = tl.MaSP
                LEFT JOIN KhachHang  kh ON kh.MaKH = tl.MaKH
                WHERE tl.MaLo  LIKE @TuKhoa
                   OR tl.TenLo LIKE @TuKhoa
                ORDER BY tl.NgayNhap DESC";

            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa.Trim() + "%");
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TraCuuLoDTO
                        {
                            MaLo = reader["MaLo"]?.ToString()!,
                            TenLo = reader["TenLo"]?.ToString()!,
                            SoLuongNhap = reader["SoLuongNhap"] != System.DBNull.Value
                                                ? System.Convert.ToInt32(reader["SoLuongNhap"]) : 0,
                            NgayNhap = reader["NgayNhap"]?.ToString()!,
                            DonViNhap = reader["DonViNhap"]?.ToString(),
                            NgayMua = reader["NgayMua"]?.ToString(),
                            TrangThai = reader["TrangThai"]?.ToString(),
                            GhiChu = reader["GhiChu"]?.ToString(),
                            ThongTinLienHe = reader["ThongTinLienHe"]?.ToString(),
                            MaPN = reader["MaPN"]?.ToString(),
                            TenSanPham = reader["TenSanPham"]?.ToString(),
                            TenKhachHang = reader["TenKhachHang"]?.ToString(),
                        });
                    }
                }
            }
            return list;
        }

        // ─── Lấy chi tiết 1 lô theo mã chính xác ───
        public TraCuuLoDTO LayChiTietLo(string maLo)
        {
            string query = @"
                SELECT 
                    tl.MaLo,
                    tl.TenLo,
                    tl.SoLuongNhap,
                    CONVERT(varchar, tl.NgayNhap, 103) AS NgayNhap,
                    tl.DonViNhap,
                    CONVERT(varchar, tl.NgayMua, 103)  AS NgayMua,
                    tl.TrangThai,
                    tl.GhiChu,
                    tl.ThongTinLienHe,
                    tl.MaPN,
                    sp.TenSP   AS TenSanPham,
                    kh.HoTen   AS TenKhachHang
                FROM ThongTinLo tl
                LEFT JOIN SanPham   sp ON sp.MaSP = tl.MaSP
                LEFT JOIN KhachHang kh ON kh.MaKH = tl.MaKH
                WHERE tl.MaLo = @MaLo";

            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaLo", maLo);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new TraCuuLoDTO
                        {
                            MaLo = reader["MaLo"]?.ToString(),
                            TenLo = reader["TenLo"]?.ToString(),
                            SoLuongNhap = reader["SoLuongNhap"] != System.DBNull.Value
                                                ? System.Convert.ToInt32(reader["SoLuongNhap"]) : 0,
                            NgayNhap = reader["NgayNhap"]?.ToString(),
                            DonViNhap = reader["DonViNhap"]?.ToString(),
                            NgayMua = reader["NgayMua"]?.ToString(),
                            TrangThai = reader["TrangThai"]?.ToString(),
                            GhiChu = reader["GhiChu"]?.ToString(),
                            ThongTinLienHe = reader["ThongTinLienHe"]?.ToString(),
                            MaPN = reader["MaPN"]?.ToString(),
                            TenSanPham = reader["TenSanPham"]?.ToString(),
                            TenKhachHang = reader["TenKhachHang"]?.ToString(),
                        };
                    }
                }
            }
            return null;
        }
    }
}