using System;
using System.Data;
using Microsoft.Data.SqlClient;
using QLNongSan.schemas;

namespace QLNongSan.repositories
{
    public class LoaiHangDAL
    {
        private string connectionString = @"Data Source=(local);Initial Catalog=QuanLyNongSan;Integrated Security=True;TrustServerCertificate=True";

        public DataTable GetListLoaiHang()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaLoai, TenLoai FROM LoaiHang";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                adapter.Fill(dt);
            return dt;
        }

        public string AddLoaiHang(LoaiHangDTO lh)
        {
            if (string.IsNullOrWhiteSpace(lh.TenLoai))
                return "Vui lòng nhập đầy đủ thông tin!";
            string query = "INSERT INTO LoaiHang (TenLoai) VALUES (@TenLoai)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@TenLoai", lh.TenLoai);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Thêm thất bại!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        public string UpdateLoaiHang(LoaiHangDTO lh)
        {
            if (string.IsNullOrWhiteSpace(lh.MaLoai)) return "Vui lòng chọn loại hàng!";
            string query = "UPDATE LoaiHang SET TenLoai=@TenLoai WHERE MaLoai=@MaLoai";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaLoai", lh.MaLoai);
                    cmd.Parameters.AddWithValue("@TenLoai", lh.TenLoai);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Không tìm thấy!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        public string DeleteLoaiHang(string maLoai)
        {
            if (string.IsNullOrWhiteSpace(maLoai)) return "Vui lòng chọn loại hàng!";
            string query = "DELETE FROM LoaiHang WHERE MaLoai=@MaLoai";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Không tìm thấy!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }
    }
}