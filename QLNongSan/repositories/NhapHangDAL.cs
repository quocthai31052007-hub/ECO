using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QLNongSan.schemas;

namespace QLNongSan.Repositories
{
    using Databases;
    public class NhapHangDAL
    {
        public required SQLServerFactory factory;

        public List<SanPhamDTO> GetSanPhamList()
        {
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            string query = "SELECT MaSP, TenSP FROM SanPham";
            using (SqlConnection conn = factory.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(new SanPhamDTO { MaSP = reader["MaSP"].ToString(), TenSP = reader["TenSP"].ToString() });
            }
            return list;
        }

        // Dùng HoTen thay vì TenNV
        public List<NhanVienDTO> GetNhanVienList()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            string query = "SELECT MaNV, HoTen FROM NhanVien";
            using (SqlConnection conn = factory.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(new NhanVienDTO { MaNV = reader["MaNV"].ToString(), TenNV = reader["HoTen"].ToString() });
            }
            return list;
        }

        public string TaoMaPhieuNhap()
        {
            string newCode = "PN001";
            string query = "SELECT TOP 1 MaPN FROM PhieuNhap ORDER BY MaPN DESC";

            using (SqlConnection conn = factory.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastCode = result.ToString();

                    // Kiểm tra độ dài trước khi Substring
                    if (lastCode.Length >= 2)
                    {
                        string numberPart = lastCode.Substring(2); // Bỏ "PN"
                        if (int.TryParse(numberPart, out int number))
                        {
                            newCode = "PN" + (number + 1).ToString("D3");
                        }
                    }
                }
            }
            return newCode;
        }

        // Dùng DonGiaNhap thay vì GiaNhap
        public bool LuuPhieuNhap(PhieuNhapDTO phieuNhap, List<ChiTietPhieuNhapDTO> chiTietList)
        {
            using (SqlConnection conn = factory.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string sqlPhieu = @"INSERT INTO PhieuNhap (MaPN, NgayNhap, MaNV, GhiChu)
                                        VALUES (@MaPN, @NgayNhap, @MaNV, @GhiChu)";
                    SqlCommand cmdPhieu = new SqlCommand(sqlPhieu, conn, transaction);
                    cmdPhieu.Parameters.AddWithValue("@MaPN", phieuNhap.MaPN);
                    cmdPhieu.Parameters.AddWithValue("@NgayNhap", phieuNhap.NgayNhap);
                    cmdPhieu.Parameters.AddWithValue("@MaNV", phieuNhap.MaNV);
                    cmdPhieu.Parameters.AddWithValue("@GhiChu", phieuNhap.GhiChu ?? "");
                    cmdPhieu.ExecuteNonQuery();

                    string sqlChiTiet = @"INSERT INTO ChiTietPhieuNhap (MaPN, MaSP, SoLuong, DonGiaNhap, HanSuDung)
                                          VALUES (@MaPN, @MaSP, @SoLuong, @DonGiaNhap, @HanSuDung)";
                    foreach (var ct in chiTietList)
                    {
                        SqlCommand cmdCT = new SqlCommand(sqlChiTiet, conn, transaction);
                        cmdCT.Parameters.AddWithValue("@MaPN", ct.MaPN);
                        cmdCT.Parameters.AddWithValue("@MaSP", ct.MaSP);
                        cmdCT.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                        cmdCT.Parameters.AddWithValue("@DonGiaNhap", ct.GiaNhap);
                        cmdCT.Parameters.AddWithValue("@HanSuDung", ct.HanSuDung);
                        cmdCT.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch { transaction.Rollback(); return false; }
            }
        }

        internal static string SavePhieuNhap(string maPN, string? maNV, string? maNCC, DateTime ngayNhap, DataTable dtChiTietTam)
        {
            throw new NotImplementedException();
        }
    }
}