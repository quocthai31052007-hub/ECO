using System;
using System.Data;
using Microsoft.Data.SqlClient;
using QLNongSan.schemas;

namespace QLNongSan.repositories
{
    public class BanHangDAL
    {
        private string connectionString = @"Data Source=(local);Initial Catalog=QuanLyNongSan;Integrated Security=True;TrustServerCertificate=True";

        public DataTable GetDanhSachSanPham()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaSP, TenSP, DVT, GiaBan FROM SanPham";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                adapter.Fill(dt);
            return dt;
        }

        // Dùng HoTen thay vì TenNV
        public DataTable GetDanhSachNhanVien()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaNV, HoTen FROM NhanVien";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                adapter.Fill(dt);
            return dt;
        }

        // Lưu vào HoaDon + ChiTietHoaDon (theo đúng schema)
        public string LuuPhieuBan(PhieuBanDTO phieu, DataTable chiTiet)
        {
            if (string.IsNullOrWhiteSpace(phieu.MaPB)) return "Vui lòng nhập Mã hóa đơn!";
            if (chiTiet == null || chiTiet.Rows.Count == 0) return "Chưa có sản phẩm!";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Insert HoaDon: MaHD, NgayLap, MaNV, TongTien, PhanHoi
                    string insertHD = @"INSERT INTO HoaDon (MaHD, NgayLap, MaNV, TongTien, PhanHoi)
                                        VALUES (@MaHD, @NgayLap, @MaNV, @TongTien, @PhanHoi)";
                    using (SqlCommand cmd = new SqlCommand(insertHD, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", phieu.MaPB);
                        cmd.Parameters.AddWithValue("@NgayLap", phieu.NgayBan);
                        cmd.Parameters.AddWithValue("@MaNV", phieu.NhanVienBan ?? "");
                        cmd.Parameters.AddWithValue("@TongTien", phieu.TongThanhToan);
                        cmd.Parameters.AddWithValue("@PhanHoi", "");
                        cmd.ExecuteNonQuery();
                    }

                    // Insert ChiTietHoaDon: MaHD, MaSP, SoLuong, DonGia
                    string insertCT = @"INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia)
                                        VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";
                    foreach (DataRow row in chiTiet.Rows)
                    {
                        using (SqlCommand cmd = new SqlCommand(insertCT, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@MaHD", phieu.MaPB);
                            cmd.Parameters.AddWithValue("@MaSP", row["MaSP"]);
                            cmd.Parameters.AddWithValue("@SoLuong", row["SoLuong"]);
                            cmd.Parameters.AddWithValue("@DonGia", row["GiaBan"]);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    return "SUCCESS";
                }
                catch (Exception ex) { transaction.Rollback(); return "Lỗi: " + ex.Message; }
            }
        }

        public DataRow GetSanPhamByTen(string tenSP)
        {
            string query = "SELECT MaSP, TenSP, DVT, GiaBan FROM SanPham WHERE TenSP=@TenSP";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TenSP", tenSP);
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        internal DataTable GetDanhSachKhachHang()
        {
            throw new NotImplementedException();
        }
    }
}