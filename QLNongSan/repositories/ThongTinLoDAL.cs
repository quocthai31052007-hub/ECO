using System;
using System.Data;
using Microsoft.Data.SqlClient;
using QLNongSan.schemas;

namespace QLNongSan.repositories
{
    public class ThongTinLoDAL
    {
        private string connectionString = @"Data Source=(local);Initial Catalog=QuanLyNongSan;Integrated Security=True;TrustServerCertificate=True";

        // Lấy danh sách lô + thông tin khách hàng
        public DataTable GetListLo()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT l.MaLo, l.TenLo, l.SoLuongNhap, l.NgayNhap, l.DonViNhap,
                             k.HoTen as HoTenKH, k.SDT as SDT_KH,
                             l.NgayMua, l.ThongTinLienHe, l.TrangThai, l.GhiChu
                             FROM ThongTinLo l
                             LEFT JOIN KhachHang k ON l.MaKH = k.MaKH";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                adapter.Fill(dt);
            return dt;
        }

        public string AddLo(ThongTinLoDTO lo)
        {
            if (string.IsNullOrWhiteSpace(lo.MaLo) || string.IsNullOrWhiteSpace(lo.TenLo))
                return "Vui lòng nhập Mã và Tên lô!";
            string query = @"INSERT INTO ThongTinLo (MaLo, TenLo, SoLuongNhap, NgayNhap, DonViNhap,
                             MaKH, NgayMua, ThongTinLienHe, TrangThai, GhiChu)
                             VALUES (@MaLo, @TenLo, @SoLuongNhap, @NgayNhap, @DonViNhap,
                             @MaKH, @NgayMua, @ThongTinLienHe, @TrangThai, @GhiChu)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaLo", lo.MaLo);
                    cmd.Parameters.AddWithValue("@TenLo", lo.TenLo);
                    cmd.Parameters.AddWithValue("@SoLuongNhap", lo.SoLuongNhap);
                    cmd.Parameters.AddWithValue("@NgayNhap", lo.NgayNhap);
                    cmd.Parameters.AddWithValue("@DonViNhap", lo.DonViNhap ?? "");
                    cmd.Parameters.AddWithValue("@MaKH", string.IsNullOrEmpty(lo.MaKH) ? (object)DBNull.Value : lo.MaKH);
                    cmd.Parameters.AddWithValue("@NgayMua", string.IsNullOrEmpty(lo.NgayMua) ? (object)DBNull.Value : lo.NgayMua);
                    cmd.Parameters.AddWithValue("@ThongTinLienHe", lo.ThongTinLienHe ?? "");
                    cmd.Parameters.AddWithValue("@TrangThai", lo.TrangThai ?? "Còn hàng");
                    cmd.Parameters.AddWithValue("@GhiChu", lo.GhiChu ?? "");
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Thêm thất bại!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        public string UpdateLo(ThongTinLoDTO lo)
        {
            if (string.IsNullOrWhiteSpace(lo.MaLo)) return "Vui lòng chọn lô!";
            string query = @"UPDATE ThongTinLo SET TenLo=@TenLo, SoLuongNhap=@SoLuongNhap,
                             NgayNhap=@NgayNhap, DonViNhap=@DonViNhap, MaKH=@MaKH,
                             NgayMua=@NgayMua, ThongTinLienHe=@ThongTinLienHe,
                             TrangThai=@TrangThai, GhiChu=@GhiChu WHERE MaLo=@MaLo";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaLo", lo.MaLo);
                    cmd.Parameters.AddWithValue("@TenLo", lo.TenLo);
                    cmd.Parameters.AddWithValue("@SoLuongNhap", lo.SoLuongNhap);
                    cmd.Parameters.AddWithValue("@NgayNhap", lo.NgayNhap);
                    cmd.Parameters.AddWithValue("@DonViNhap", lo.DonViNhap ?? "");
                    cmd.Parameters.AddWithValue("@MaKH", string.IsNullOrEmpty(lo.MaKH) ? (object)DBNull.Value : lo.MaKH);
                    cmd.Parameters.AddWithValue("@NgayMua", string.IsNullOrEmpty(lo.NgayMua) ? (object)DBNull.Value : lo.NgayMua);
                    cmd.Parameters.AddWithValue("@ThongTinLienHe", lo.ThongTinLienHe ?? "");
                    cmd.Parameters.AddWithValue("@TrangThai", lo.TrangThai ?? "Còn hàng");
                    cmd.Parameters.AddWithValue("@GhiChu", lo.GhiChu ?? "");
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Không tìm thấy!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        public string DeleteLo(string maLo)
        {
            if (string.IsNullOrWhiteSpace(maLo)) return "Vui lòng chọn lô!";
            string query = "DELETE FROM ThongTinLo WHERE MaLo=@MaLo";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaLo", maLo);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Không tìm thấy!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        // Lấy danh sách khách hàng cho ComboBox
        public DataTable GetDanhSachKhachHang()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaKH, HoTen FROM KhachHang";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                adapter.Fill(dt);
            return dt;
        }
    }
}