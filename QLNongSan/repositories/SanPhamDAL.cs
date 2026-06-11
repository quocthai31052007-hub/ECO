using System;
using System.Data;
using Microsoft.Data.SqlClient;
using QLNongSan.schemas;

namespace QLNongSan.repositories
{
    public class SanPhamDAL
    {
        private string connectionString = @"Data Source=(local);Initial Catalog=QuanLyNongSan;Integrated Security=True;TrustServerCertificate=True";

        // Lấy toàn bộ sản phẩm
        public DataTable GetAllSanPham()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT MaSP as [Mã SP], TenSP as [Tên sản phẩm], DVT as [ĐVT],
                             GiaBan as [Giá bán], SoLuongTon as [Tồn kho], MaLoai as [Loại hàng]
                             FROM SanPham";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                adapter.Fill(dt);
            return dt;
        }

        // Thêm sản phẩm
        public string AddSanPham(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP) || string.IsNullOrWhiteSpace(sp.TenSP))
                return "Vui lòng nhập Mã và Tên sản phẩm!";

            string query = @"INSERT INTO SanPham (MaSP, TenSP, DVT, GiaBan, SoLuongTon, MaLoai)
                             VALUES (@MaSP, @TenSP, @DVT, @GiaBan, @SoLuongTon, @MaLoai)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                    cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                    cmd.Parameters.AddWithValue("@DVT", sp.DVT ?? "");
                    cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                    cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
                    cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoai ?? "");
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Thêm thất bại!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        // Sửa sản phẩm
        public string UpdateSanPham(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP)) return "Vui lòng chọn sản phẩm!";
            string query = @"UPDATE SanPham SET TenSP=@TenSP, DVT=@DVT, GiaBan=@GiaBan,
                             SoLuongTon=@SoLuongTon, MaLoai=@MaLoai WHERE MaSP=@MaSP";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                    cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                    cmd.Parameters.AddWithValue("@DVT", sp.DVT ?? "");
                    cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                    cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
                    cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoai ?? "");
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Không tìm thấy!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        // Xóa sản phẩm
        public string DeleteSanPham(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP)) return "Vui lòng chọn sản phẩm!";
            string query = "DELETE FROM SanPham WHERE MaSP=@MaSP";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Không tìm thấy!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        // Lấy danh sách loại hàng cho ComboBox
        public DataTable GetDanhSachLoaiHang()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaLoai, TenLoai FROM LoaiHang";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                adapter.Fill(dt);
            return dt;
        }

        internal object? GetListSanPham()
        {
            throw new NotImplementedException();
        }
    }
}