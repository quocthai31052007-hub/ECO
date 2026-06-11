using System;
using System.Data;
using Microsoft.Data.SqlClient;
using QLNongSan.schemas;

namespace QLNongSan.repositories
{
    public class NhanVienDAL
    {
        private string connectionString = @"Data Source=(local);Initial Catalog=QuanLyNongSan;Integrated Security=True;TrustServerCertificate=True";

        // Cột thực tế: MaNV, HoTen, Username, Password, VaiTro
        public DataTable GetListNhanVien()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaNV, HoTen, Username, VaiTro FROM NhanVien";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                adapter.Fill(dt);
            return dt;
        }

        public string AddNhanVien(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.MaNV) || string.IsNullOrWhiteSpace(nv.TenNV))
                return "Vui lòng nhập Mã và Tên nhân viên!";
            string query = "INSERT INTO NhanVien (MaNV, HoTen, Username, Password, VaiTro) VALUES (@MaNV, @HoTen, @Username, @Password, @VaiTro)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                    cmd.Parameters.AddWithValue("@HoTen", nv.TenNV);
                    cmd.Parameters.AddWithValue("@Username", nv.MaNV);
                    cmd.Parameters.AddWithValue("@Password", "123456");
                    cmd.Parameters.AddWithValue("@VaiTro", nv.ChucVu ?? "Nhân viên");
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Thêm thất bại!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        public string UpdateNhanVien(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.MaNV)) return "Vui lòng chọn nhân viên!";
            string query = "UPDATE NhanVien SET HoTen=@HoTen, VaiTro=@VaiTro WHERE MaNV=@MaNV";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                    cmd.Parameters.AddWithValue("@HoTen", nv.TenNV);
                    cmd.Parameters.AddWithValue("@VaiTro", nv.ChucVu ?? "Nhân viên");
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Không tìm thấy!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        public string DeleteNhanVien(string maNV)
        {
            if (string.IsNullOrWhiteSpace(maNV)) return "Vui lòng chọn nhân viên!";
            string query = "DELETE FROM NhanVien WHERE MaNV=@MaNV";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Không tìm thấy!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }
    }
}